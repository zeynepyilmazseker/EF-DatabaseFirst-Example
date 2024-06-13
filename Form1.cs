using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SınavOgrenciEFProject
{
    public partial class Form1 : Form
    {
        static string connection = "Data Source=DESKTOP-8JJLI3A;Initial Catalog=DbSınavOgrenci;Integrated Security=True";
        DbSınavOgrenciEntities db = new DbSınavOgrenciEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOgrList_Click(object sender, EventArgs e)
        {
            //bu kısım klasik ADO.NET komutları ile yazılmıştır.
            SqlConnection con = new SqlConnection(connection);
            SqlCommand komut = new SqlCommand("select * from TBLOGRENCI", con);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnDersList_Click(object sender, EventArgs e)
        {
            //DBFIRST Yaklaşımı ile ENTITYFRAMEWORK kullanılarak yazılmıştır.
            dataGridView1.DataSource = db.TBLDERSLER.ToList();
            dataGridView1.Columns[2].Visible = false;
        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = db.TBLNOTLAR.ToList();
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.notid,
                            item.ogrenciid,
                            item.TBLOGRENCI.ogrenciAd,
                            item.TBLOGRENCI.ogrenciSoyad,
                            item.TBLDERSLER.dersAd,
                            item.sınav1,
                            item.sınav2,
                            item.sınav3,
                            item.ortalama,
                            item.durum
                        };
            //süslü parantez içindeki değerleri tablodan seçer.
            dataGridView1.DataSource = query.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI ogr = new TBLOGRENCI();
            ogr.ogrenciAd = txtOgrAd.Text;
            ogr.ogrenciSoyad = txtOgrSoyad.Text;
            //insert karşılığı Add()
            db.TBLOGRENCI.Add(ogr);
            //executenonquery karşılığı
            db.SaveChanges();
            MessageBox.Show("Öğrenci Listeye Eklenmiştir.");


        }

        private void BtnDersKaydet_Click(object sender, EventArgs e)
        {
            TBLDERSLER ders = new TBLDERSLER();
            ders.dersAd = TxtDersAd.Text;
            db.TBLDERSLER.Add(ders);
            db.SaveChanges();
            MessageBox.Show("Ders Listeye Eklenmiştir.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrId.Text);
            var ogr = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(ogr);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silindi.");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrId.Text);
            var ogr = db.TBLOGRENCI.Find(id);
            ogr.ogrenciAd = txtOgrAd.Text;
            ogr.ogrenciSoyad = txtOgrSoyad.Text;

            db.SaveChanges();
            MessageBox.Show("Öğrenci güncellendi.");
        }

        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NotListesi();

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.ogrenciAd == txtOgrAd.Text & x.ogrenciSoyad == txtOgrSoyad.Text).ToList();
        }

        private void txtOgrAd_TextChanged(object sender, EventArgs e)
        {
            string arananDeger = txtOgrAd.Text;
            var degerler = from item in db.TBLOGRENCI
                           where item.ogrenciAd.Contains(arananDeger)
                           select item;
            dataGridView1.DataSource = degerler.ToList();

        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (RBAdaGore.Checked)
            {
                List<TBLOGRENCI> ogrenciler = db.TBLOGRENCI.OrderBy(ogr => ogr.ogrenciAd).ToList();

                dataGridView1.DataSource = ogrenciler;
            }

            else if (RBZdenAya.Checked)
            {
                List<TBLOGRENCI> ogrenciler = db.TBLOGRENCI.OrderByDescending(ogr => ogr.ogrenciAd).ToList();
                dataGridView1.DataSource = ogrenciler;

            }

            else if (RBIlk3Kayit.Checked)
            {
                List<TBLOGRENCI> ogrenciler = db.TBLOGRENCI.OrderBy(p => p.ogrenciAd).Take(3).ToList();
                dataGridView1.DataSource = ogrenciler;
            }

            else if (RBIDyeGore.Checked)
            {
                List<TBLOGRENCI> ogrenciler = db.TBLOGRENCI.Where(p => p.ogrenciid == 5).ToList();
                dataGridView1.DataSource = ogrenciler;

            }

            else if (RBAdiAileBaslayan.Checked)
            {
                List<TBLOGRENCI> ogrenciler = db.TBLOGRENCI.Where(p => p.ogrenciAd.StartsWith("A")).ToList();
                dataGridView1.DataSource = ogrenciler;

            }

            else if (RBAileBitenler.Checked)
            {
                List<TBLOGRENCI> ogrenciler = db.TBLOGRENCI.Where(p => p.ogrenciAd.EndsWith("A")).ToList();
                dataGridView1.DataSource = ogrenciler;
            }

            else if (RBDegerVarMi.Checked)
            {
                bool degerVarMi = db.TBLOGRENCI.Any();
                MessageBox.Show(degerVarMi.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (RBCount.Checked)
            {
                int count = db.TBLOGRENCI.Count();
                MessageBox.Show(count.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (RBSınav1ToplamPuam.Checked)
            {
                int sumExam1 = (int)db.TBLNOTLAR.Sum(p => p.sınav1);
                MessageBox.Show(sumExam1.ToString(), "sınav 1 toplamı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (RBsinav1Ort.Checked)
            {
                double ort = (double)db.TBLNOTLAR.Average(p => p.sınav1);
                // MessageBox.Show(ort.ToString(), "Sınav1 Ortalaması:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = db.TBLNOTLAR.Where(p => p.sınav1 >= ort).ToList();
            }
            else if (RBMaxSınav1.Checked)
            {
                var maxNot = db.TBLNOTLAR.Max(p => p.sınav1);
                MessageBox.Show(maxNot.ToString(), "Max Sınav1 Notu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (RBMaxGradeStudent.Checked)
            {
                var maxNot = db.TBLNOTLAR.Max(p => p.sınav1);
                var maxNotDetails = db.TBLNOTLAR.Where(p => p.sınav1 == maxNot).Select(
                    p => new
                    {
                        p.sınav1,
                        p.TBLOGRENCI.ogrenciAd,
                        p.TBLOGRENCI.ogrenciSoyad
                    }).FirstOrDefault();

                MessageBox.Show($"En yüksek not {maxNotDetails.sınav1} ile {maxNotDetails.ogrenciAd} {maxNotDetails.ogrenciSoyad} isimli öğrenciye aittir.");

            }


        }

        //JOIN İŞLEMİ
        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from table1 in db.TBLNOTLAR
                        join table2 in db.TBLOGRENCI
                        on table1.ogrenciid equals table2.ogrenciid
                        join table3 in db.TBLDERSLER
                        on table1.dersid equals table3.dersid
                        select new
                        {
                            //ogrenci,sınav1,sınav2 burada tablodaki sütun isimleri olacak.
                            //seçilen değerler de kayıtlar olacak.
                            ogrenciad = table2.ogrenciAd + " " + table2.ogrenciSoyad,
                            ders = table3.dersAd,
                            sınav1 = table1.sınav1,
                            sınav2 = table1.sınav2,
                            sınav3 = table1.sınav3,
                            ortalama = table1.ortalama

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
