namespace WinFormsApp2025_kutuphane.Resources
{
    partial class Form_kitaplar
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
            dataGridView_kitaplar = new DataGridView();
            Column_baslik = new DataGridViewTextBoxColumn();
            Column_yazar = new DataGridViewTextBoxColumn();
            Column_kitaptur = new DataGridViewComboBoxColumn();
            Column_sayfa = new DataGridViewTextBoxColumn();
            Column_yayinYili = new DataGridViewTextBoxColumn();
            Column_oduncAlma = new DataGridViewCheckBoxColumn();
            Column_Guncelle = new DataGridViewButtonColumn();
            Column_Sil = new DataGridViewButtonColumn();
            flowLayoutPanel_bilgiEkranı = new FlowLayoutPanel();
            label1 = new Label();
            label_Toplam_Kitap = new Label();
            label3 = new Label();
            flowLayoutPanel_bilgi = new FlowLayoutPanel();
            button_yenikitap = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            textBox_ara = new TextBox();
            button_ara = new Button();
            comboBox_araTur = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_kitaplar).BeginInit();
            flowLayoutPanel_bilgiEkranı.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_kitaplar
            // 
            dataGridView_kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_kitaplar.Columns.AddRange(new DataGridViewColumn[] { Column_baslik, Column_yazar, Column_kitaptur, Column_sayfa, Column_yayinYili, Column_oduncAlma, Column_Guncelle, Column_Sil });
            dataGridView_kitaplar.Location = new Point(0, 51);
            dataGridView_kitaplar.Margin = new Padding(2);
            dataGridView_kitaplar.Name = "dataGridView_kitaplar";
            dataGridView_kitaplar.RowHeadersWidth = 62;
            dataGridView_kitaplar.Size = new Size(1278, 495);
            dataGridView_kitaplar.TabIndex = 0;
            dataGridView_kitaplar.CellContentClick += dataGridView_kitaplar_CellContentClick;
            dataGridView_kitaplar.CellValueChanged += dataGridView_kitaplar_CellValueChanged;
            // 
            // Column_baslik
            // 
            Column_baslik.HeaderText = "Kitabın Adı";
            Column_baslik.MinimumWidth = 8;
            Column_baslik.Name = "Column_baslik";
            Column_baslik.Width = 150;
            // 
            // Column_yazar
            // 
            Column_yazar.HeaderText = "Yazarı";
            Column_yazar.MinimumWidth = 8;
            Column_yazar.Name = "Column_yazar";
            Column_yazar.Width = 150;
            // 
            // Column_kitaptur
            // 
            Column_kitaptur.HeaderText = "Kitabın Türü";
            Column_kitaptur.MinimumWidth = 8;
            Column_kitaptur.Name = "Column_kitaptur";
            Column_kitaptur.Width = 150;
            // 
            // Column_sayfa
            // 
            Column_sayfa.HeaderText = "Sayfa Sayısı";
            Column_sayfa.MinimumWidth = 8;
            Column_sayfa.Name = "Column_sayfa";
            Column_sayfa.Width = 150;
            // 
            // Column_yayinYili
            // 
            Column_yayinYili.HeaderText = "Yayın Tarihi";
            Column_yayinYili.MinimumWidth = 8;
            Column_yayinYili.Name = "Column_yayinYili";
            Column_yayinYili.Width = 150;
            // 
            // Column_oduncAlma
            // 
            Column_oduncAlma.DataPropertyName = "OduncAlindiMi";
            Column_oduncAlma.HeaderText = "Ödünç";
            Column_oduncAlma.MinimumWidth = 8;
            Column_oduncAlma.Name = "Column_oduncAlma";
            Column_oduncAlma.Width = 150;
            // 
            // Column_Guncelle
            // 
            Column_Guncelle.HeaderText = "Güncelle";
            Column_Guncelle.MinimumWidth = 8;
            Column_Guncelle.Name = "Column_Guncelle";
            Column_Guncelle.Text = "GÜNCELLE";
            Column_Guncelle.UseColumnTextForButtonValue = true;
            Column_Guncelle.Width = 150;
            // 
            // Column_Sil
            // 
            Column_Sil.HeaderText = "Sil";
            Column_Sil.MinimumWidth = 8;
            Column_Sil.Name = "Column_Sil";
            Column_Sil.Text = "SİL";
            Column_Sil.UseColumnTextForButtonValue = true;
            Column_Sil.Width = 150;
            // 
            // flowLayoutPanel_bilgiEkranı
            // 
            flowLayoutPanel_bilgiEkranı.Controls.Add(label1);
            flowLayoutPanel_bilgiEkranı.Controls.Add(label_Toplam_Kitap);
            flowLayoutPanel_bilgiEkranı.Controls.Add(label3);
            flowLayoutPanel_bilgiEkranı.Controls.Add(flowLayoutPanel_bilgi);
            flowLayoutPanel_bilgiEkranı.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_bilgiEkranı.Font = new Font("Bahnschrift SemiBold", 9F);
            flowLayoutPanel_bilgiEkranı.Location = new Point(1280, 11);
            flowLayoutPanel_bilgiEkranı.Margin = new Padding(2);
            flowLayoutPanel_bilgiEkranı.Name = "flowLayoutPanel_bilgiEkranı";
            flowLayoutPanel_bilgiEkranı.Size = new Size(262, 452);
            flowLayoutPanel_bilgiEkranı.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 13F);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 27);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Bilgi";
            // 
            // label_Toplam_Kitap
            // 
            label_Toplam_Kitap.AutoSize = true;
            label_Toplam_Kitap.Location = new Point(2, 27);
            label_Toplam_Kitap.Margin = new Padding(2, 0, 2, 0);
            label_Toplam_Kitap.Name = "label_Toplam_Kitap";
            label_Toplam_Kitap.Size = new Size(48, 18);
            label_Toplam_Kitap.TabIndex = 1;
            label_Toplam_Kitap.Text = "label2";
            label_Toplam_Kitap.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 45);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 18);
            label3.TabIndex = 2;
            label3.Text = "----------------------";
            // 
            // flowLayoutPanel_bilgi
            // 
            flowLayoutPanel_bilgi.Location = new Point(2, 65);
            flowLayoutPanel_bilgi.Margin = new Padding(2);
            flowLayoutPanel_bilgi.Name = "flowLayoutPanel_bilgi";
            flowLayoutPanel_bilgi.Size = new Size(259, 375);
            flowLayoutPanel_bilgi.TabIndex = 3;
            // 
            // button_yenikitap
            // 
            button_yenikitap.Image = Properties.Resources.ebook__2_;
            button_yenikitap.ImageAlign = ContentAlignment.MiddleLeft;
            button_yenikitap.Location = new Point(1282, 467);
            button_yenikitap.Margin = new Padding(2);
            button_yenikitap.Name = "button_yenikitap";
            button_yenikitap.Size = new Size(254, 67);
            button_yenikitap.TabIndex = 2;
            button_yenikitap.Text = "KİTAP EKLE";
            button_yenikitap.UseVisualStyleBackColor = true;
            button_yenikitap.Click += button_yenikitap_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox_ara);
            flowLayoutPanel1.Controls.Add(button_ara);
            flowLayoutPanel1.Controls.Add(comboBox_araTur);
            flowLayoutPanel1.Location = new Point(10, 3);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 4, 0, 0);
            flowLayoutPanel1.Size = new Size(984, 43);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "ARAMA";
            // 
            // textBox_ara
            // 
            textBox_ara.Location = new Point(67, 6);
            textBox_ara.Margin = new Padding(2);
            textBox_ara.Name = "textBox_ara";
            textBox_ara.Size = new Size(665, 27);
            textBox_ara.TabIndex = 1;
            // 
            // button_ara
            // 
            button_ara.Location = new Point(736, 6);
            button_ara.Margin = new Padding(2);
            button_ara.Name = "button_ara";
            button_ara.Size = new Size(90, 27);
            button_ara.TabIndex = 2;
            button_ara.Text = "ARA";
            button_ara.UseVisualStyleBackColor = true;
            // 
            // comboBox_araTur
            // 
            comboBox_araTur.FormattingEnabled = true;
            comboBox_araTur.Location = new Point(830, 6);
            comboBox_araTur.Margin = new Padding(2);
            comboBox_araTur.Name = "comboBox_araTur";
            comboBox_araTur.Size = new Size(146, 28);
            comboBox_araTur.TabIndex = 3;
            // 
            // Form_kitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 545);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button_yenikitap);
            Controls.Add(flowLayoutPanel_bilgiEkranı);
            Controls.Add(dataGridView_kitaplar);
            Margin = new Padding(2);
            Name = "Form_kitaplar";
            Text = "Form_kitaplar";
            Load += Form_kitaplar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_kitaplar).EndInit();
            flowLayoutPanel_bilgiEkranı.ResumeLayout(false);
            flowLayoutPanel_bilgiEkranı.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_kitaplar;
        private FlowLayoutPanel flowLayoutPanel_bilgiEkranı;
        private Button button_yenikitap;
        private Label label1;
        private Label label_Toplam_Kitap;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textBox_ara;
        private Button button_ara;
        private ComboBox comboBox_araTur;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel_bilgi;
        private DataGridViewTextBoxColumn Column_baslik;
        private DataGridViewTextBoxColumn Column_yazar;
        private DataGridViewComboBoxColumn Column_kitaptur;
        private DataGridViewTextBoxColumn Column_sayfa;
        private DataGridViewTextBoxColumn Column_yayinYili;
        private DataGridViewCheckBoxColumn Column_oduncAlma;
        private DataGridViewButtonColumn Column_Guncelle;
        private DataGridViewButtonColumn Column_Sil;
    }
}