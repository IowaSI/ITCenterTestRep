using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCenter_testApp_IS.Model
{
    public class p_int_dokument_pobierz
    {
        public int do_id { get; set; }
        public string do_nazwa { get; set; }
        public string do_numer_klienta { get; set; }
        public decimal? do_cena_brutto { get; set; }
        public decimal? do_cena_netto { get; set; }
        public DateTime? do_data { get; set; }
    }
}
