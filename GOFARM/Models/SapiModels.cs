using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFarm.Models
{
    public class SapiModels
    {
        public string Id_Sapi { get; set; }
        public string Nama_Sapi { get; set; }
        public string Warna { get; set; }
        public string Keturunan { get; set; }
        public DateTime Tanggal_Lahir { get; set; }
        public int Umur { get; set; }
        public decimal Berat_Lahir { get; set; }
        public string Kandang { get; set; }
    }
}
