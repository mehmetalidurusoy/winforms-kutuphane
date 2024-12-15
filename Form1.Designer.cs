namespace WinFormsApp2025_kutuphane
{
    partial class Form_Ana
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button_kitaplar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_large_library_with_many_books_and_bookshelves_for_learning_26759864;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F);
            label1.Location = new Point(423, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 72);
            label1.TabIndex = 1;
            label1.Text = "KÜTÜPHANE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(740, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 22);
            label2.TabIndex = 2;
            label2.Text = "2025";
            // 
            // button_kitaplar
            // 
            button_kitaplar.BackgroundImageLayout = ImageLayout.Zoom;
            button_kitaplar.Font = new Font("Bahnschrift SemiBold", 12F);
            button_kitaplar.Image = Properties.Resources.vecteezy_3d_stack_of_books_kucuk1;
            button_kitaplar.ImageAlign = ContentAlignment.MiddleLeft;
            button_kitaplar.Location = new Point(432, 133);
            button_kitaplar.Name = "button_kitaplar";
            button_kitaplar.Size = new Size(333, 98);
            button_kitaplar.TabIndex = 3;
            button_kitaplar.Text = "Kitaplar";
            button_kitaplar.UseVisualStyleBackColor = true;
            button_kitaplar.Click += button_kitaplar_Click;
            // 
            // Form_Ana
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 392);
            Controls.Add(button_kitaplar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form_Ana";
            Text = "Kütüphane";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button_kitaplar;
    }
}
