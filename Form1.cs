using WinFormsApp2025_kutuphane.Resources;

namespace WinFormsApp2025_kutuphane
{
    public partial class Form_Ana : Form
    {
        public Form_Ana()
        {
            InitializeComponent();
        }

        private void button_kitaplar_Click(object sender, EventArgs e)
        {
            Form_kitaplar kitaplar_form = new Form_kitaplar();
            kitaplar_form.ShowDialog();
        }
    }
}
