using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCenter_testApp_IS.Model;

namespace ITCenter_testApp_IS
{
    public class DAO
    {
        public static List<p_int_dokument_pobierz> p_int_dokument_pobierz(int? do_id)
        {
            var m = new List<p_int_dokument_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter("@p_do_id", SqlDbType.Int);
                p.Value = do_id;
                //p.Value = do_id == null ? DBNull.Value : do_id;

                if (p.Value == null)
                {
                    p.Value = DBNull.Value;
                }

                m = db.Database.SqlQuery<p_int_dokument_pobierz>("exec p_int_dokument_pobierz @p_do_id", p).ToList();
            }

            return m;
        }

        public static List<p_int_artykul_pobierz> p_int_artykul_pobierz(int do_id)
        {
            var m = new List<p_int_artykul_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter("@p_do_id", SqlDbType.Int);
                p.Value = do_id;

                m = db.Database.SqlQuery<p_int_artykul_pobierz>("exec p_int_artykul_pobierz @p_do_id", p).ToList();
            }

            return m;
        }

        public static List<p_int_dokument_pobierz> p_int_dokument_usun(string do_ids)
        {
            var m = new List<p_int_dokument_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter("@p_do_ids", SqlDbType.NVarChar);
                p.Value = do_ids;

                m = db.Database.SqlQuery<p_int_dokument_pobierz>("exec p_int_dokument_usun @p_do_ids",p).ToList();
            }

            return m;
        }

        public static List<p_int_dokument_pobierz> p_int_dokument_dodaj(p_int_dokument_pobierz new_dok)
        {
            var m = new List<p_int_dokument_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter[5];

                p[0] = new SqlParameter("@p_do_nazwa",SqlDbType.NVarChar);
                p[0].Value = new_dok.do_nazwa;

                p[1] = new SqlParameter("@p_do_data", SqlDbType.DateTime);
                p[1].Value = new_dok.do_data;

                p[2] = new SqlParameter("@p_do_numer_kl", SqlDbType.NVarChar);
                p[2].Value = new_dok.do_numer_klienta;

                p[3] = new SqlParameter("@p_do_cena_br", SqlDbType.Decimal);
                p[3].Value = new_dok.do_cena_brutto;

                p[4] = new SqlParameter("@p_do_cena_nt", SqlDbType.Decimal);
                p[4].Value = new_dok.do_cena_netto;

                m = db.Database.SqlQuery<p_int_dokument_pobierz>("exec p_int_dokument_dodaj @p_do_nazwa,@p_do_data,@p_do_numer_kl,@p_do_cena_br,@p_do_cena_nt", p).ToList();
            }

            return m;
        }
    }
}
