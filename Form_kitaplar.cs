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

namespace WinFormsApp2025_kutuphane.Resources
{
    public partial class Form_kitaplar : Form
    {
        List<int> trueIndexes = new List<int>();

        public Kutuphane kutuphane = new Kutuphane();
        Kitap kitap1 = new Kitap(b: "1984", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 400, yy: 1949, false);
        Kitap kitap2 = new Kitap(b: "Hayvan Çiftliği", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 500, yy: 1945);
        Kitap kitap3 = new Kitap(b: "Sefiller", y: "Victor Hugo", t: Kitap.Kitaptur.Roman, s: 300, yy: 1862);
        Kitap kitap4 = new Kitap(b: "Sihirli 7", y: "Sahra Doğa Çağdaş", t: Kitap.Kitaptur.Deneme, s: 64, yy: 2024);
        Kitap kitap5 = new Kitap(b: "Lavinia - Aşk Şiirleri", y: "Özdemir Asaf", t: Kitap.Kitaptur.Şiir, s: 35, yy: 2015);
        Kitap kitap6 = new Kitap(b: "1234", y: "özge halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024, false);
        Kitap kitap7 = new Kitap(b: "456789", y: "halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);

        public static Form_kitaplar instance;
        public DataGridView kitaplar;

        public Form_kitaplar()
        {
            kutuphane.KitapEkle(
                [kitap1, kitap2, kitap3, kitap4, kitap5, kitap6, kitap7]
                );
            InitializeComponent();
            instance = this;
            kitaplar = dataGridView_kitaplar;
        }

        private void Form_kitaplar_Load(object sender, EventArgs e)
        {
            DataGridView_Ayarla();
            kutuphane_BilgiGetir();
        }

        private void kutuphane_BilgiGetir()
        {
            Label _lbl;
            int kitapTur_sayisi = Enum.GetNames<Kitap.Kitaptur>().Count();
            int toplamK = kutuphane.TumKitaplariListele().Count();
            List<int> istatistik = kitapTur_toplamlarini_Hesapla();
            label_Toplam_Kitap.Text = "Toplam Kitap Sayısı =" + toplamK.ToString();
            flowLayoutPanel_bilgi.Controls.Clear();
            for (int i = 0; i < kitapTur_sayisi; i++)
            {
                _lbl = new Label();
                _lbl.Width = 250;
                _lbl.Text = (Kitap.Kitaptur)i + " türünde => " + istatistik[i].ToString() + " adet";
                flowLayoutPanel_bilgi.Controls.Add(_lbl);
            }

        }

        private List<int> kitapTur_toplamlarini_Hesapla()
        {
            List<int> toplamlar = new List<int>();
            foreach (var item in Enum.GetNames<Kitap.Kitaptur>())
            {
                toplamlar.Add(kutuphane.TumKitaplariListele().Count(x => x.tur.ToString() == item.ToString()));
            }
            return toplamlar;
        }

        public void DataGridView_Ayarla()
        {
            dataGridView_kitaplar.AutoGenerateColumns = false;
            dataGridView_kitaplar.DataSource = kutuphane.TumKitaplariListele();
            Column_baslik.DataPropertyName = "baslik";
            Column_yazar.DataPropertyName = "yazar";
            Column_sayfa.DataPropertyName = "sayfa";
            Column_yayinYili.DataPropertyName = "yayinYili";
            Column_oduncAlma.DataPropertyName = "OduncAlindiMi";
            //datagridviewdeki combobox ı dolduruyorum
            Column_kitaptur.DataPropertyName = "tur";
            Column_kitaptur.DataSource = Enum.GetValues<Kitap.Kitaptur>();

        }

        private void dataGridView_kitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string secilen_kitap_baslik = kutuphane.TumKitaplariListele()[e.RowIndex].baslik;
            
            if(e.ColumnIndex == 5) {}
            if (e.ColumnIndex == 6)
            {
                Form_ekle form_Ekle = new Form_ekle();
                form_Ekle.islem = "duzenle";
                form_Ekle.kitapBasligi = secilen_kitap_baslik;
                form_Ekle.ShowDialog();
            }
            if (e.ColumnIndex == 7)
            {
                DialogResult cvp = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    kutuphane.KitapSil(e.RowIndex);
                    MessageBox.Show("SİLME işlemi gerçekleşti");
                    kutuphane_BilgiGetir();
                }
            }
        }

        private void button_yenikitap_Click(object sender, EventArgs e)
        {
            Form_ekle form_Ekle = new Form_ekle();
            form_Ekle.ShowDialog();
        }

        private void dataGridView_kitaplar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
