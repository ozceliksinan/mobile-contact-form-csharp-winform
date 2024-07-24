namespace TelefonRehberi.WFUI
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.grpbox_kayit = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_yeni_kayit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.txt_emailadres = new System.Windows.Forms.TextBox();
            this.txt_telefonII = new System.Windows.Forms.TextBox();
            this.txt_telefonI = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_data_alver_durum = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_JsonDataVer = new System.Windows.Forms.Button();
            this.btn_csv = new System.Windows.Forms.Button();
            this.btn_xml_ver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpbox_kayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_liste);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Listesi";
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 15;
            this.lst_liste.Location = new System.Drawing.Point(7, 23);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(295, 574);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.SelectedIndexChanged += new System.EventHandler(this.lst_liste_SelectedIndexChanged);
            this.lst_liste.DoubleClick += new System.EventHandler(this.lst_liste_DoubleClick);
            // 
            // grpbox_kayit
            // 
            this.grpbox_kayit.Controls.Add(this.btn_sil);
            this.grpbox_kayit.Controls.Add(this.btn_guncelle);
            this.grpbox_kayit.Controls.Add(this.btn_yeni_kayit);
            this.grpbox_kayit.Controls.Add(this.tabControl1);
            this.grpbox_kayit.Location = new System.Drawing.Point(327, 24);
            this.grpbox_kayit.Name = "grpbox_kayit";
            this.grpbox_kayit.Size = new System.Drawing.Size(924, 450);
            this.grpbox_kayit.TabIndex = 1;
            this.grpbox_kayit.TabStop = false;
            this.grpbox_kayit.Text = "Yeni Rehber Kaydı";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(463, 401);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(437, 43);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Kayıt Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(14, 400);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(442, 44);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yeni_kayit
            // 
            this.btn_yeni_kayit.Location = new System.Drawing.Point(14, 348);
            this.btn_yeni_kayit.Name = "btn_yeni_kayit";
            this.btn_yeni_kayit.Size = new System.Drawing.Size(886, 46);
            this.btn_yeni_kayit.TabIndex = 2;
            this.btn_yeni_kayit.Text = "Yeni Kayıt Ekle";
            this.btn_yeni_kayit.UseVisualStyleBackColor = true;
            this.btn_yeni_kayit.Click += new System.EventHandler(this.btn_yeni_kayit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.txt_emailadres);
            this.tabPage1.Controls.Add(this.txt_telefonII);
            this.tabPage1.Controls.Add(this.txt_telefonI);
            this.tabPage1.Controls.Add(this.txt_soyisim);
            this.tabPage1.Controls.Add(this.txt_isim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(414, 20);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(439, 240);
            this.txt_adres.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Website";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-Mail Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyisim";
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(135, 237);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(100, 23);
            this.txt_website.TabIndex = 6;
            // 
            // txt_emailadres
            // 
            this.txt_emailadres.Location = new System.Drawing.Point(135, 194);
            this.txt_emailadres.Name = "txt_emailadres";
            this.txt_emailadres.Size = new System.Drawing.Size(100, 23);
            this.txt_emailadres.TabIndex = 5;
            // 
            // txt_telefonII
            // 
            this.txt_telefonII.Location = new System.Drawing.Point(135, 149);
            this.txt_telefonII.Name = "txt_telefonII";
            this.txt_telefonII.Size = new System.Drawing.Size(100, 23);
            this.txt_telefonII.TabIndex = 4;
            // 
            // txt_telefonI
            // 
            this.txt_telefonI.Location = new System.Drawing.Point(135, 106);
            this.txt_telefonI.Name = "txt_telefonI";
            this.txt_telefonI.Size = new System.Drawing.Size(100, 23);
            this.txt_telefonI.TabIndex = 3;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(135, 64);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 23);
            this.txt_soyisim.TabIndex = 2;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(135, 20);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 23);
            this.txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_aciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(13, 16);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(856, 264);
            this.txt_aciklama.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_data_alver_durum);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btn_JsonDataVer);
            this.groupBox3.Controls.Add(this.btn_csv);
            this.groupBox3.Controls.Add(this.btn_xml_ver);
            this.groupBox3.Location = new System.Drawing.Point(327, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(924, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Al / Ver";
            // 
            // lbl_data_alver_durum
            // 
            this.lbl_data_alver_durum.AutoSize = true;
            this.lbl_data_alver_durum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data_alver_durum.Location = new System.Drawing.Point(645, 48);
            this.lbl_data_alver_durum.Name = "lbl_data_alver_durum";
            this.lbl_data_alver_durum.Size = new System.Drawing.Size(106, 13);
            this.lbl_data_alver_durum.TabIndex = 4;
            this.lbl_data_alver_durum.Text = "Durum: Beklemede";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "XML Al";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_JsonDataVer
            // 
            this.btn_JsonDataVer.Location = new System.Drawing.Point(331, 32);
            this.btn_JsonDataVer.Name = "btn_JsonDataVer";
            this.btn_JsonDataVer.Size = new System.Drawing.Size(125, 62);
            this.btn_JsonDataVer.TabIndex = 2;
            this.btn_JsonDataVer.Text = "Json Ver";
            this.btn_JsonDataVer.UseVisualStyleBackColor = true;
            this.btn_JsonDataVer.Click += new System.EventHandler(this.btn_JsonDataVer_Click);
            // 
            // btn_csv
            // 
            this.btn_csv.Location = new System.Drawing.Point(168, 32);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(121, 62);
            this.btn_csv.TabIndex = 1;
            this.btn_csv.Text = "CSV Ver";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // btn_xml_ver
            // 
            this.btn_xml_ver.Location = new System.Drawing.Point(14, 32);
            this.btn_xml_ver.Name = "btn_xml_ver";
            this.btn_xml_ver.Size = new System.Drawing.Size(121, 62);
            this.btn_xml_ver.TabIndex = 0;
            this.btn_xml_ver.Text = "XML Ver";
            this.btn_xml_ver.UseVisualStyleBackColor = true;
            this.btn_xml_ver.Click += new System.EventHandler(this.btn_xml_ver_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 637);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbox_kayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpbox_kayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbox_kayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.TextBox txt_emailadres;
        private System.Windows.Forms.TextBox txt_telefonII;
        private System.Windows.Forms.TextBox txt_telefonI;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_yeni_kayit;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_data_alver_durum;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_JsonDataVer;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Button btn_xml_ver;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
    }
}