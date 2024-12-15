namespace WinFormsApp2025_kutuphane
{
    partial class Form_ekle
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox_kAd = new TextBox();
            label_OrtaBaslik = new Label();
            button_Ekle = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            textBox_kYazar = new TextBox();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            comboBox_kTur = new ComboBox();
            kutuphaneBindingSource = new BindingSource(components);
            flowLayoutPanel4 = new FlowLayoutPanel();
            label4 = new Label();
            textBox_kSs = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label5 = new Label();
            textBox_kYy = new TextBox();
            checkBox_Odunc = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kutuphaneBindingSource).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox_kAd);
            flowLayoutPanel1.Location = new Point(12, 54);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel1.Size = new Size(879, 49);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(83, 27);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı   ";
            // 
            // textBox_kAd
            // 
            textBox_kAd.Location = new Point(92, 11);
            textBox_kAd.Margin = new Padding(3, 4, 3, 4);
            textBox_kAd.Name = "textBox_kAd";
            textBox_kAd.Size = new Size(774, 27);
            textBox_kAd.TabIndex = 1;
            // 
            // label_OrtaBaslik
            // 
            label_OrtaBaslik.AutoSize = true;
            label_OrtaBaslik.Font = new Font("Bahnschrift SemiBold", 13F);
            label_OrtaBaslik.Location = new Point(286, 9);
            label_OrtaBaslik.Margin = new Padding(2, 0, 2, 0);
            label_OrtaBaslik.Name = "label_OrtaBaslik";
            label_OrtaBaslik.Size = new Size(222, 27);
            label_OrtaBaslik.TabIndex = 3;
            label_OrtaBaslik.Text = "Kitap Ekleme Sayfası";
            // 
            // button_Ekle
            // 
            button_Ekle.Font = new Font("Bahnschrift SemiBold", 13F);
            button_Ekle.Location = new Point(12, 452);
            button_Ekle.Margin = new Padding(3, 4, 3, 4);
            button_Ekle.Name = "button_Ekle";
            button_Ekle.Size = new Size(882, 120);
            button_Ekle.TabIndex = 5;
            button_Ekle.Text = "Kitabı Ekle";
            button_Ekle.UseVisualStyleBackColor = true;
            button_Ekle.Click += button_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(textBox_kYazar);
            flowLayoutPanel2.Location = new Point(12, 120);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel2.Size = new Size(879, 49);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 7, 0, 0);
            label2.Size = new Size(83, 27);
            label2.TabIndex = 0;
            label2.Text = "Kitap Yazar";
            // 
            // textBox_kYazar
            // 
            textBox_kYazar.Location = new Point(92, 11);
            textBox_kYazar.Margin = new Padding(3, 4, 3, 4);
            textBox_kYazar.Name = "textBox_kYazar";
            textBox_kYazar.Size = new Size(778, 27);
            textBox_kYazar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 0);
            label3.Size = new Size(85, 27);
            label3.TabIndex = 0;
            label3.Text = "Kitap Tür    ";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(comboBox_kTur);
            flowLayoutPanel3.Location = new Point(12, 188);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel3.Size = new Size(879, 49);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // comboBox_kTur
            // 
            comboBox_kTur.FormattingEnabled = true;
            comboBox_kTur.Location = new Point(94, 10);
            comboBox_kTur.Name = "comboBox_kTur";
            comboBox_kTur.Size = new Size(772, 28);
            comboBox_kTur.TabIndex = 1;
            // 
            // kutuphaneBindingSource
            // 
            kutuphaneBindingSource.DataSource = typeof(WinFormsApp_kutuphane2025.model.Kutuphane);
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(textBox_kSs);
            flowLayoutPanel4.Location = new Point(12, 259);
            flowLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel4.Size = new Size(879, 49);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 7, 0, 0);
            label4.Size = new Size(125, 27);
            label4.TabIndex = 0;
            label4.Text = "Kitap Sayfa Sayısı";
            // 
            // textBox_kSs
            // 
            textBox_kSs.Location = new Point(134, 11);
            textBox_kSs.Margin = new Padding(3, 4, 3, 4);
            textBox_kSs.Name = "textBox_kSs";
            textBox_kSs.Size = new Size(735, 27);
            textBox_kSs.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(textBox_kYy);
            flowLayoutPanel5.Location = new Point(12, 331);
            flowLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel5.Size = new Size(879, 49);
            flowLayoutPanel5.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 7);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 7, 0, 0);
            label5.Size = new Size(112, 27);
            label5.TabIndex = 0;
            label5.Text = "Kitap Basım Yılı";
            // 
            // textBox_kYy
            // 
            textBox_kYy.Location = new Point(121, 11);
            textBox_kYy.Margin = new Padding(3, 4, 3, 4);
            textBox_kYy.Name = "textBox_kYy";
            textBox_kYy.Size = new Size(745, 27);
            textBox_kYy.TabIndex = 1;
            // 
            // checkBox_Odunc
            // 
            checkBox_Odunc.AutoSize = true;
            checkBox_Odunc.Location = new Point(12, 410);
            checkBox_Odunc.Name = "checkBox_Odunc";
            checkBox_Odunc.Size = new Size(170, 24);
            checkBox_Odunc.TabIndex = 1;
            checkBox_Odunc.Text = "Kitap Ödünç Durumu";
            checkBox_Odunc.UseVisualStyleBackColor = true;
            // 
            // Form_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 602);
            Controls.Add(checkBox_Odunc);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(button_Ekle);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(label_OrtaBaslik);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Name = "Form_ekle";
            Text = "Kitap Ekle";
            Load += Form_ekle_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kutuphaneBindingSource).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox_kAd;
        private Label label_OrtaBaslik;
        private Button button_Ekle;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox textBox_kYazar;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel3;
        private ComboBox comboBox_kTur;
        private BindingSource kutuphaneBindingSource;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private TextBox textBox_kSs;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private TextBox textBox_kYy;
        private CheckBox checkBox_Odunc;
    }
}