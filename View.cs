using System;
using System.Windows.Forms;

namespace moore_mealy_machines
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        CiktiliMakine makine;
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAlfabe.Text.Trim() == string.Empty || txtCiktilar.Text.Trim() == string.Empty || txtDurumlar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] alfabe = txtAlfabe.Text.Replace(" ", "").Split(',');
            string[] ciktilar = txtCiktilar.Text.Replace(" ", "").Split(',');
            string[] durumlar = txtDurumlar.Text.Replace(" ", "").Split(',');

            this.Text = rdbMoore.Checked ? "Moore Makinesi" : "Mealey Makinesi";

            makine = rdbMoore.Checked ? (CiktiliMakine)new Moore(alfabe, ciktilar, durumlar) : new Mealey(alfabe, ciktilar, durumlar);
            makine.CiktiliGecisTablosu = dtgTablo; // Form tasarımdaki tablo doldurulması için sınıfa gönderildi.
            makine.GecisTablosunuOlustur();

            gboxAdim2.Enabled = true;
            gboxAdim3.Enabled = false;
        }
        
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (makine.DurumlariOlustur())
                gboxAdim3.Enabled = true;
            else
                MessageBox.Show("Lütfen tablodaki bütün alanları doldurun", "Tablo Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnMakineyiCalistir_Click(object sender, EventArgs e)
        {
            rchSonuc.Text = string.Empty;
            var sonuc = makine.Calistir(txtKelime.Text);


            bool girilenKelimeGecersiz = false;
            foreach (var harf in txtKelime.Text)
            {
                if (Array.IndexOf(makine.Alfabe, harf.ToString()) == -1)
                {
                    girilenKelimeGecersiz = true;
                    break;
                }
            }

            if(girilenKelimeGecersiz)
            {
                MessageBox.Show("Lütfen test edeceğiniz kelimeden, alfabede bulunmayan harfleri çıkarın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sonuc == null)
            {
                MessageBox.Show("Lütfen geçiş tablosunu doğru bir şekilde doldurun ve durumları tekrar oluşturun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblSonucCikti.Visible = lblSonucDurumlar.Visible = lblSonucGirdi.Visible = true;

            string durumlar = sonuc[0].Replace(" ", "\t");
            string ciktilar = sonuc[1].Replace(" ", "\t");

            string bosluklaAyrilmisKelime = string.Empty;
            foreach (var harf in txtKelime.Text)
                bosluklaAyrilmisKelime += rdbMoore.Checked ? $"\t{harf}" : $"{harf}\t";

            rchSonuc.Text = $"{bosluklaAyrilmisKelime}\n{durumlar}\n{ciktilar}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
