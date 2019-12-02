using System.Collections.Generic;
using System.Windows.Forms;

namespace moore_mealy_machines
{
    public abstract class CiktiliMakine
    {
        public class Durum
        {
            public string Ad { get; set; }
            public List<Gecis> Gecisler { get; set; }
            public string Cikti{ get; set; } // Moore Makinesi için çıktı

            public Durum(string ad)
            {
                this.Ad = ad;
            }
        }
        public class Gecis
        {
            public string Girdi { get; set; }
            public string Cikti { get; set; }  // Mealey Makinesi için çıktı
            public Durum Durum { get; set; }
        }

        public string[] Alfabe { get; set; }
        public string[] Ciktilar { get; set; }
        public string[] Durumlar { get; set; }
        public DataGridView CiktiliGecisTablosu { get; set; }

        public abstract void GecisTablosunuOlustur();
        public abstract bool DurumlariOlustur();
        public abstract string[] Calistir(string kelime);
    }
}
