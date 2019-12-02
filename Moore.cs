using System.Collections.Generic;
using System.Windows.Forms;

namespace moore_mealy_machines
{
    
    class Moore : CiktiliMakine
    {
        List<Durum> DurumListesi = new List<Durum>();

        public Moore(string[] alfabe, string[] ciktilar, string[] durumlar)
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
            CiktiliGecisTablosu.Columns[0].SortMode  = DataGridViewColumnSortMode.NotSortable;

            foreach (var item in Alfabe)
            {
                CiktiliGecisTablosu.Columns.Add(
                    new DataGridViewComboBoxColumn()
                    {
                        DataSource = Durumlar,
                        HeaderText = item,
                        Name = item
                    });
            }
            CiktiliGecisTablosu.Columns.Add(
                    new DataGridViewComboBoxColumn()
                    {
                        DataSource = Ciktilar,
                        HeaderText = "Çıktı",
                        Name = "Çıktı"
                    });

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
                durum.Cikti = satir.Cells[satir.Cells.Count - 1].Value.ToString();
                for (int i = 0; i < Alfabe.Length; i++)
                {
                    var hucre = satir.Cells[i+1]; // Tabloda ilk sütun durum isimleri olduğu için i+1
                    var gecilenDurum = DurumListesi.Find(x => x.Ad == hucre.Value.ToString());
                    var gecis = new Gecis()
                    {
                        Girdi = Alfabe[i],
                        Durum = gecilenDurum
                    };
                    durum.Gecisler.Add(gecis);
                }
            }
            return true;
        }

        public override string[] Calistir(string kelime)
        {
            if(DurumListesi.Count ==0)
                return null;

            var simdikiDurum = DurumListesi[0];
            string durumDizesi = simdikiDurum.Ad+" ";
            string ciktiDizesi = simdikiDurum.Cikti+" ";
            foreach (var harf in kelime)
            {
                var eslesenGecis = simdikiDurum.Gecisler.Find(gecis => gecis.Girdi == harf.ToString());
                simdikiDurum = eslesenGecis.Durum;

                durumDizesi += simdikiDurum.Ad + " ";
                ciktiDizesi += simdikiDurum.Cikti + " ";
            }
            
            return new string[] { durumDizesi,ciktiDizesi};
        }
    }
}
