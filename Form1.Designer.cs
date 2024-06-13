namespace SınavOgrenciEFProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOgrList = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnDersList = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnOrt = new System.Windows.Forms.Button();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.BtnDersKaydet = new System.Windows.Forms.Button();
            this.BtnProsedur = new System.Windows.Forms.Button();
            this.RBAdaGore = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.RBZdenAya = new System.Windows.Forms.RadioButton();
            this.RBIlk3Kayit = new System.Windows.Forms.RadioButton();
            this.RBIDyeGore = new System.Windows.Forms.RadioButton();
            this.RBAdiAileBaslayan = new System.Windows.Forms.RadioButton();
            this.RBAileBitenler = new System.Windows.Forms.RadioButton();
            this.RBDegerVarMi = new System.Windows.Forms.RadioButton();
            this.RBCount = new System.Windows.Forms.RadioButton();
            this.RBSınav1ToplamPuam = new System.Windows.Forms.RadioButton();
            this.RBsinav1Ort = new System.Windows.Forms.RadioButton();
            this.RBMaxSınav1 = new System.Windows.Forms.RadioButton();
            this.RBMaxGradeStudent = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1251, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnOgrList
            // 
            this.BtnOgrList.Location = new System.Drawing.Point(6, 171);
            this.BtnOgrList.Name = "BtnOgrList";
            this.BtnOgrList.Size = new System.Drawing.Size(117, 23);
            this.BtnOgrList.TabIndex = 1;
            this.BtnOgrList.Text = "Öğrenci Listele";
            this.BtnOgrList.UseVisualStyleBackColor = true;
            this.BtnOgrList.Click += new System.EventHandler(this.BtnOgrList_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(6, 210);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(117, 23);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Öğrenci Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(162, 171);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(117, 23);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Öğrenci Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(162, 210);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(117, 23);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Öğrenci Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(6, 241);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(117, 23);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Öğrenci Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnDersList
            // 
            this.BtnDersList.Location = new System.Drawing.Point(162, 107);
            this.BtnDersList.Name = "BtnDersList";
            this.BtnDersList.Size = new System.Drawing.Size(117, 23);
            this.BtnDersList.TabIndex = 6;
            this.BtnDersList.Text = "Ders Listesi";
            this.BtnDersList.UseVisualStyleBackColor = true;
            this.BtnDersList.Click += new System.EventHandler(this.BtnDersList_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(3, 297);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(254, 23);
            this.BtnNotListesi.TabIndex = 7;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFoto);
            this.groupBox1.Controls.Add(this.txtOgrSoyad);
            this.groupBox1.Controls.Add(this.txtOgrAd);
            this.groupBox1.Controls.Add(this.BtnBul);
            this.groupBox1.Controls.Add(this.txtOgrId);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnOgrList);
            this.groupBox1.Location = new System.Drawing.Point(36, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 270);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİLER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnProsedur);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.BtnNotListesi);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.BtnJoin);
            this.groupBox2.Controls.Add(this.BtnOrt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(848, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 457);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOTLAR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDersKaydet);
            this.groupBox3.Controls.Add(this.TxtDersAd);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BtnDersList);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(437, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 268);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DERSLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FOTOĞRAF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ıd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DERS ADI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SINAV1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "SINAV2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "SINAV3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "ORTALAMA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "DURUM";
            // 
            // BtnOrt
            // 
            this.BtnOrt.Location = new System.Drawing.Point(2, 239);
            this.BtnOrt.Name = "BtnOrt";
            this.BtnOrt.Size = new System.Drawing.Size(258, 23);
            this.BtnOrt.TabIndex = 5;
            this.BtnOrt.Text = "ORTALAMA";
            this.BtnOrt.UseVisualStyleBackColor = true;
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(0, 268);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(257, 23);
            this.BtnJoin.TabIndex = 6;
            this.BtnJoin.Text = "Join İşlemi İle Getir";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // txtOgrId
            // 
            this.txtOgrId.Location = new System.Drawing.Point(99, 8);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(100, 20);
            this.txtOgrId.TabIndex = 4;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(99, 60);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrAd.TabIndex = 5;
            this.txtOgrAd.TextChanged += new System.EventHandler(this.txtOgrAd_TextChanged);
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(99, 96);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgrSoyad.TabIndex = 6;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(99, 134);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(100, 20);
            this.txtFoto.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(133, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(133, 65);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(100, 20);
            this.TxtDersAd.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(153, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(153, 68);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(153, 118);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(153, 160);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(153, 195);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 11;
            // 
            // BtnDersKaydet
            // 
            this.BtnDersKaydet.Location = new System.Drawing.Point(23, 107);
            this.BtnDersKaydet.Name = "BtnDersKaydet";
            this.BtnDersKaydet.Size = new System.Drawing.Size(118, 23);
            this.BtnDersKaydet.TabIndex = 11;
            this.BtnDersKaydet.Text = "Ders Kaydet";
            this.BtnDersKaydet.UseVisualStyleBackColor = true;
            this.BtnDersKaydet.Click += new System.EventHandler(this.BtnDersKaydet_Click);
            // 
            // BtnProsedur
            // 
            this.BtnProsedur.Location = new System.Drawing.Point(0, 326);
            this.BtnProsedur.Name = "BtnProsedur";
            this.BtnProsedur.Size = new System.Drawing.Size(260, 23);
            this.BtnProsedur.TabIndex = 12;
            this.BtnProsedur.Text = "PROSEDÜR";
            this.BtnProsedur.UseVisualStyleBackColor = true;
            this.BtnProsedur.Click += new System.EventHandler(this.BtnProsedur_Click);
            // 
            // RBAdaGore
            // 
            this.RBAdaGore.AutoSize = true;
            this.RBAdaGore.Location = new System.Drawing.Point(42, 616);
            this.RBAdaGore.Name = "RBAdaGore";
            this.RBAdaGore.Size = new System.Drawing.Size(131, 17);
            this.RBAdaGore.TabIndex = 11;
            this.RBAdaGore.TabStop = true;
            this.RBAdaGore.Text = "Ada Göre Sırala(A-->Z)";
            this.RBAdaGore.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(711, 610);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(131, 23);
            this.BtnLinqEntity.TabIndex = 12;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // RBZdenAya
            // 
            this.RBZdenAya.AutoSize = true;
            this.RBZdenAya.Location = new System.Drawing.Point(42, 639);
            this.RBZdenAya.Name = "RBZdenAya";
            this.RBZdenAya.Size = new System.Drawing.Size(131, 17);
            this.RBZdenAya.TabIndex = 13;
            this.RBZdenAya.TabStop = true;
            this.RBZdenAya.Text = "Ada Göre Sırala(Z-->A)";
            this.RBZdenAya.UseVisualStyleBackColor = true;
            // 
            // RBIlk3Kayit
            // 
            this.RBIlk3Kayit.AutoSize = true;
            this.RBIlk3Kayit.Location = new System.Drawing.Point(42, 663);
            this.RBIlk3Kayit.Name = "RBIlk3Kayit";
            this.RBIlk3Kayit.Size = new System.Drawing.Size(71, 17);
            this.RBIlk3Kayit.TabIndex = 14;
            this.RBIlk3Kayit.TabStop = true;
            this.RBIlk3Kayit.Text = "İlk 3 Kayıt";
            this.RBIlk3Kayit.UseVisualStyleBackColor = true;
            // 
            // RBIDyeGore
            // 
            this.RBIDyeGore.AutoSize = true;
            this.RBIDyeGore.Location = new System.Drawing.Point(198, 616);
            this.RBIDyeGore.Name = "RBIDyeGore";
            this.RBIDyeGore.Size = new System.Drawing.Size(119, 17);
            this.RBIDyeGore.TabIndex = 15;
            this.RBIDyeGore.TabStop = true;
            this.RBIDyeGore.Text = "IDye Göre Veri Getir";
            this.RBIDyeGore.UseVisualStyleBackColor = true;
            // 
            // RBAdiAileBaslayan
            // 
            this.RBAdiAileBaslayan.AutoSize = true;
            this.RBAdiAileBaslayan.Location = new System.Drawing.Point(198, 645);
            this.RBAdiAileBaslayan.Name = "RBAdiAileBaslayan";
            this.RBAdiAileBaslayan.Size = new System.Drawing.Size(109, 17);
            this.RBAdiAileBaslayan.TabIndex = 16;
            this.RBAdiAileBaslayan.TabStop = true;
            this.RBAdiAileBaslayan.Text = "Adı A ile Başlayan";
            this.RBAdiAileBaslayan.UseVisualStyleBackColor = true;
            // 
            // RBAileBitenler
            // 
            this.RBAileBitenler.AutoSize = true;
            this.RBAileBitenler.Location = new System.Drawing.Point(198, 669);
            this.RBAileBitenler.Name = "RBAileBitenler";
            this.RBAileBitenler.Size = new System.Drawing.Size(101, 17);
            this.RBAileBitenler.TabIndex = 17;
            this.RBAileBitenler.TabStop = true;
            this.RBAileBitenler.Text = "Adı A ile Bitenler";
            this.RBAileBitenler.UseVisualStyleBackColor = true;
            // 
            // RBDegerVarMi
            // 
            this.RBDegerVarMi.AutoSize = true;
            this.RBDegerVarMi.Location = new System.Drawing.Point(346, 616);
            this.RBDegerVarMi.Name = "RBDegerVarMi";
            this.RBDegerVarMi.Size = new System.Drawing.Size(124, 17);
            this.RBDegerVarMi.TabIndex = 18;
            this.RBDegerVarMi.TabStop = true;
            this.RBDegerVarMi.Text = "Listede Değer Var Mı";
            this.RBDegerVarMi.UseVisualStyleBackColor = true;
            // 
            // RBCount
            // 
            this.RBCount.AutoSize = true;
            this.RBCount.Location = new System.Drawing.Point(346, 645);
            this.RBCount.Name = "RBCount";
            this.RBCount.Size = new System.Drawing.Size(128, 17);
            this.RBCount.TabIndex = 19;
            this.RBCount.TabStop = true;
            this.RBCount.Text = "Toplam Eleman Sayısı";
            this.RBCount.UseVisualStyleBackColor = true;
            // 
            // RBSınav1ToplamPuam
            // 
            this.RBSınav1ToplamPuam.AutoSize = true;
            this.RBSınav1ToplamPuam.Location = new System.Drawing.Point(346, 669);
            this.RBSınav1ToplamPuam.Name = "RBSınav1ToplamPuam";
            this.RBSınav1ToplamPuam.Size = new System.Drawing.Size(124, 17);
            this.RBSınav1ToplamPuam.TabIndex = 20;
            this.RBSınav1ToplamPuam.TabStop = true;
            this.RBSınav1ToplamPuam.Text = "Sınav1 Toplam Puan";
            this.RBSınav1ToplamPuam.UseVisualStyleBackColor = true;
            // 
            // RBsinav1Ort
            // 
            this.RBsinav1Ort.AutoSize = true;
            this.RBsinav1Ort.Location = new System.Drawing.Point(495, 616);
            this.RBsinav1Ort.Name = "RBsinav1Ort";
            this.RBsinav1Ort.Size = new System.Drawing.Size(99, 17);
            this.RBsinav1Ort.TabIndex = 21;
            this.RBsinav1Ort.TabStop = true;
            this.RBsinav1Ort.Text = "sınav1 ortalama";
            this.RBsinav1Ort.UseVisualStyleBackColor = true;
            // 
            // RBMaxSınav1
            // 
            this.RBMaxSınav1.AutoSize = true;
            this.RBMaxSınav1.Location = new System.Drawing.Point(495, 648);
            this.RBMaxSınav1.Name = "RBMaxSınav1";
            this.RBMaxSınav1.Size = new System.Drawing.Size(139, 17);
            this.RBMaxSınav1.TabIndex = 22;
            this.RBMaxSınav1.TabStop = true;
            this.RBMaxSınav1.Text = "En Yüksek Sınav1 Notu";
            this.RBMaxSınav1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBMaxSınav1.UseVisualStyleBackColor = true;
            // 
            // RBMaxGradeStudent
            // 
            this.RBMaxGradeStudent.AutoSize = true;
            this.RBMaxGradeStudent.Location = new System.Drawing.Point(495, 683);
            this.RBMaxGradeStudent.Name = "RBMaxGradeStudent";
            this.RBMaxGradeStudent.Size = new System.Drawing.Size(173, 17);
            this.RBMaxGradeStudent.TabIndex = 23;
            this.RBMaxGradeStudent.TabStop = true;
            this.RBMaxGradeStudent.Text = "En Yüksek Nota Sahip Öğrenci";
            this.RBMaxGradeStudent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 838);
            this.Controls.Add(this.RBMaxGradeStudent);
            this.Controls.Add(this.RBMaxSınav1);
            this.Controls.Add(this.RBsinav1Ort);
            this.Controls.Add(this.RBSınav1ToplamPuam);
            this.Controls.Add(this.RBCount);
            this.Controls.Add(this.RBDegerVarMi);
            this.Controls.Add(this.RBAileBitenler);
            this.Controls.Add(this.RBAdiAileBaslayan);
            this.Controls.Add(this.RBIDyeGore);
            this.Controls.Add(this.RBIlk3Kayit);
            this.Controls.Add(this.RBZdenAya);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.RBAdaGore);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOgrList;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnDersList;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.Button BtnOrt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button BtnDersKaydet;
        private System.Windows.Forms.Button BtnProsedur;
        private System.Windows.Forms.RadioButton RBAdaGore;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton RBZdenAya;
        private System.Windows.Forms.RadioButton RBIlk3Kayit;
        private System.Windows.Forms.RadioButton RBIDyeGore;
        private System.Windows.Forms.RadioButton RBAdiAileBaslayan;
        private System.Windows.Forms.RadioButton RBAileBitenler;
        private System.Windows.Forms.RadioButton RBDegerVarMi;
        private System.Windows.Forms.RadioButton RBCount;
        private System.Windows.Forms.RadioButton RBSınav1ToplamPuam;
        private System.Windows.Forms.RadioButton RBsinav1Ort;
        private System.Windows.Forms.RadioButton RBMaxSınav1;
        private System.Windows.Forms.RadioButton RBMaxGradeStudent;
    }
}

