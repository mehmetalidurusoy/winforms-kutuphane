using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_kutuphane2025.model;
using WinFormsApp2025_kutuphane.Resources;

namespace WinFormsApp2025_kutuphane
{
    public partial class Form_ekle : Form
    {
        public static Form_ekle instance;
        public string islem;
        public string kitapBasligi;
        private Kitap secilenKitap;

        public Form_ekle()
        {
            InitializeComponent();
            Form_ekle instance = this;
        }

        private void Form_ekle_Load(object sender, EventArgs e)
        {
            comboBox_kTur.DataSource = Enum.GetValues<Kitap.Kitaptur>();

            if(islem == "duzenle")
            {
                secilenKitap = Form_kitaplar.instance.kutuphane.BasligaGoreAra(kitapBasligi)[0];

                Text = "Kitap Düzenleme: " + kitapBasligi;
                label_OrtaBaslik.Text = "Kitap Düzenleme Sayfası";
                textBox_kAd.Text = kitapBasligi;
                textBox_kYazar.Text = secilenKitap.yazar;
                textBox_kSs.Text = Convert.ToString(secilenKitap.sayfa);
                textBox_kYy.Text = Convert.ToString(secilenKitap.yayinYili);
                checkBox_Odunc.Checked = secilenKitap.OduncAlindiMi;
                comboBox_kTur.SelectedItem = secilenKitap.tur;
                button_Ekle.Text = "Kitabı Güncelle";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_kAd.Text == "" || textBox_kYazar.Text == "" ||
                textBox_kSs.Text == "" || textBox_kYy.Text == "")
            {
                YardimciFonksiyonlar.uyariKutusu("Lütfen Tüm Alanları Doldurun.");
            }
            else
            {
                int yayinYili = Convert.ToInt32(textBox_kYy.Text);

                if (formKontrol(yayinYili))
                {
                    var yeniKitap = new Kitap(b: textBox_kAd.Text, y: textBox_kYazar.Text,
                                              t: (Kitap.Kitaptur)comboBox_kTur.SelectedValue,
                                              s: Convert.ToInt32(textBox_kSs.Text), yy: yayinYili,
                                              odunc: checkBox_Odunc.Checked);
                    if(islem == "duzenle")
                    {
                        Form_kitaplar.instance.kutuphane.KitapGuncelle(kitapBasligi, yeniKitap);
                        Form_kitaplar.instance.kitaplar.Refresh();
                        this.Close();
                    } else { Form_kitaplar.instance.kutuphane.KitapEkle(yeniKitap); }
                }
            }
        }

        private bool formKontrol(int yayinYili)
        {
            bool devam = true;

            if (yayinYili < 1000 || yayinYili > DateTime.Now.Year)
            {
                YardimciFonksiyonlar.uyariKutusu($"Girilen Yıl 1000 - {DateTime.Now.Year} arasında olmalıdır");
                devam = false;
            }

            return devam;
        }
    }
}
