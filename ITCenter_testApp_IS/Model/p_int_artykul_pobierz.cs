using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCenter_testApp_IS.Model
{
    public class p_int_artykul_pobierz
    {
        public int? nar_do_id { get; set; }
        public decimal ar_cena_brutto { get; set; }
        public decimal ar_cena_netto { get; set; }
        public int ar_id { get; set; }
        public int ar_liczba { get; set; }
        public string ar_nazwa { get; set; }
        public string do_nazwa { get; set; }
    }
}
