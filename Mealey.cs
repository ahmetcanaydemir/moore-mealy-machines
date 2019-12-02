using System.Collections.Generic;
using System.Windows.Forms;

namespace moore_mealy_machines
{
    class Mealey : CiktiliMakine
    {
        List<Durum> DurumListesi = new List<Durum>();

        public Mealey(string[] alfabe, string[] ciktilar, string[] durumlar)
        {
            base.Alfabe = alfabe;
            base.Ciktilar = ciktilar;
            base.Durumlar = durumlar;
        }

        public override void GecisTablosunuOlustur()
        {
            CiktiliGecisTablosu.Rows.Clear();
            CiktiliGecisTablosu.Columns.Clear();
            CiktiliGecisTablosu.Refresh();

            CiktiliGecisTablosu.Columns.Add("Önceki Durum", "Önceki Durum");
            CiktiliGecisTablosu.Columns[0].ReadOnly = true;
            CiktiliGecisTablosu.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (var item in Alfabe)
            {
                CiktiliGecisTablosu.Columns.Add(
                    new DataGridViewComboBoxColumn()
                    {
                        DataSource = Durumlar,
                        HeaderText = item+" Gelirse Yeni Durum",
                        Name = item + " Gelirse Yeni Durum"
                    });
                CiktiliGecisTablosu.Columns.Add(
                    new DataGridViewComboBoxColumn()
                    {
                        DataSource = Ciktilar,
                        HeaderText = item + " Gelirse Çıktı",
                        Name = item + " Gelirse Çıktı"
                    });
            }
            foreach (var durum in Durumlar)
                CiktiliGecisTablosu.Rows.Add(new string[] { durum });
        }

        public override bool DurumlariOlustur()
        {
            DurumListesi = new List<Durum>();
            foreach (var durum in Durumlar)
                DurumListesi.Add(new Durum(durum));

            foreach (DataGridViewRow satir in CiktiliGecisTablosu.Rows)
            {
                foreach (DataGridViewCell hucre in satir.Cells) // Tabloda seçilmemiş hücre var mı diye kontrol ediliyor.
                    if (hucre.Value is null) return false; 

                var durum = DurumListesi.Find(x => x.Ad == satir.Cells[0].Value.ToString());
                durum.Gecisler = new List<Gecis>();
                for (int i = 1; i < satir.Cells.Count; i+=2) //i+=2 çünkü mealey'de girdi ve çıktı ikilisi var
                {
                    var hucre = satir.Cells[i];
                    var gecilenDurum = DurumListesi.Find(x => x.Ad == hucre.Value.ToString());

                    var cikti = satir.Cells[i+1].Value.ToString();
                    Gecis gecis = new Gecis()
                    {
                        Girdi = Alfabe[i/2].ToString(),
                        Cikti = cikti,
                        Durum = gecilenDurum
                    };
                    durum.Gecisler.Add(gecis);
                }
            }
            return true;
        }

        public override string[] Calistir(string kelime)
        {
            if (DurumListesi.Count == 0)
                return null;

            string durumDizesi = string.Empty;
            string ciktiDizesi = string.Empty;
            var simdikiDurum = DurumListesi[0];
            foreach (var harf in kelime)
            {
                var eslesenGecis = simdikiDurum.Gecisler.Find(gecis => gecis.Girdi == harf.ToString());
                simdikiDurum = eslesenGecis.Durum;
                ciktiDizesi += eslesenGecis.Cikti + " ";
                durumDizesi += simdikiDurum.Ad + " ";
            }
            return new string[] { durumDizesi,ciktiDizesi};
        }
    }
}
