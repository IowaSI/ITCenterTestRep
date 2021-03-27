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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static List<p_int_dokument_pobierz> p_int_dokument_pobierz(int? do_id)
        {
            log.Info("p_int_dokument_pobierz");

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

        public static List<p_int_artykul_pobierz> p_int_artykul_pobierz(int? do_id)
        {
            log.Info("p_int_dokument_pop_int_artykul_pobierzbierz");

            var m = new List<p_int_artykul_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter("@p_do_id", SqlDbType.Int);
                p.Value = do_id;

                if (p.Value == null)
                {
                    p.Value = DBNull.Value;
                }

                m = db.Database.SqlQuery<p_int_artykul_pobierz>("exec p_int_artykul_pobierz @p_do_id", p).ToList();
            }

            return m;
        }

        public static List<p_int_dokument_pobierz> p_int_dokument_usun(int do_id)
        {
            log.Info("p_int_dokument_usun");

            var m = new List<p_int_dokument_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter("@p_do_ids", SqlDbType.NVarChar);
                p.Value = do_id;

                m = db.Database.SqlQuery<p_int_dokument_pobierz>("exec p_int_dokument_usun @p_do_ids",p).ToList();
            }

            return m;
        }

        public static List<p_int_dokument_pobierz> p_int_dokument_dodaj(p_int_dokument_pobierz new_dok)
        {
            log.Info("p_int_dokument_dodaj");

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

        public static List<p_int_dokument_pobierz> p_int_dokument_update(p_int_dokument_pobierz dok)
        {
            log.Info("p_int_dokument_update");

            var m = new List<p_int_dokument_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter[6];

                p[0] = new SqlParameter("@p_do_ids", SqlDbType.Int);
                p[0].Value = dok.do_id;

                p[1] = new SqlParameter("@p_do_cen_br", SqlDbType.Decimal);
                p[1].Value = dok.do_cena_brutto;

                p[2] = new SqlParameter("@p_do_cen_nt", SqlDbType.Decimal);
                p[2].Value = dok.do_cena_netto;

                p[3] = new SqlParameter("@p_do_nazwa", SqlDbType.NVarChar);
                p[3].Value = dok.do_nazwa;

                p[4] = new SqlParameter("@p_do_nr_kli", SqlDbType.NVarChar);
                p[4].Value = dok.do_numer_klienta;

                p[5] = new SqlParameter("@p_do_data", SqlDbType.DateTime);
                p[5].Value = dok.do_data;
             
                m = db.Database.SqlQuery<p_int_dokument_pobierz>("exec p_int_dokument_update @p_do_ids,@p_do_cen_br,@p_do_cen_nt,@p_do_nazwa,@p_do_nr_kli,@p_do_data", p).ToList();
             }

            return m;
        }

        public static List<p_int_artykul_pobierz> p_int_artkul_dodaj(p_int_artykul_pobierz artykul)
        {
            log.Info("p_int_artkul_dodaj");

            var m = new List<p_int_artykul_pobierz>();
            
            using(var db = new col_dataEntities())
            {
                var p = new SqlParameter[5];

                p[0] = new SqlParameter("@p_ar_nazwa", SqlDbType.NVarChar);
                p[0].Value = artykul.ar_nazwa;

                p[1] = new SqlParameter("@p_ar_liczba", SqlDbType.Int);
                p[1].Value = artykul.ar_liczba;

                p[2] = new SqlParameter("@p_ar_cena_br", SqlDbType.Decimal);
                p[2].Value = artykul.ar_cena_brutto;

                p[3] = new SqlParameter("@p_ar_cena_nt", SqlDbType.Decimal);
                p[3].Value = artykul.ar_cena_netto;

                p[4] = new SqlParameter("@p_do_id", SqlDbType.Int);
                p[4].Value = artykul.nar_do_id;

                if (p[4].Value == null)
                {
                    p[4].Value = DBNull.Value;
                }

                m = db.Database.SqlQuery<p_int_artykul_pobierz>("exec p_int_artkul_dodaj @p_ar_nazwa, @p_ar_liczba, @p_ar_cena_br,@p_ar_cena_nt,@p_do_id",p).ToList();
            }

            return m;
        }

        public static List<p_int_artykul_pobierz> p_int_artkul_update(p_int_artykul_pobierz artykul)
        {
            log.Info("p_int_artkul_update");

            var m = new List<p_int_artykul_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter[6];

                p[0] = new SqlParameter("@p_ar_ids", SqlDbType.NVarChar);
                p[0].Value = artykul.ar_id;

                p[1] = new SqlParameter("@p_ar_cena_brutto", SqlDbType.Decimal);
                p[1].Value = artykul.ar_cena_brutto;

                p[2] = new SqlParameter("@p_ar_cena_netto", SqlDbType.Decimal);
                p[2].Value = artykul.ar_cena_netto;

                p[3] = new SqlParameter("@p_ar_liczba", SqlDbType.Int);
                p[3].Value = artykul.ar_liczba;

                p[4] = new SqlParameter("@p_ar_nazwa", SqlDbType.NVarChar);
                p[4].Value = artykul.ar_nazwa;

                p[5] = new SqlParameter("@p_ar_do_id", SqlDbType.Int);
                p[5].Value = artykul.nar_do_id;

                m = db.Database.SqlQuery<p_int_artykul_pobierz>("exec p_int_artkul_update @p_ar_ids,@p_ar_cena_brutto,@p_ar_cena_netto,@p_ar_liczba,@p_ar_nazwa,@p_ar_do_id", p).ToList();
            }

            return m;
        }

        public static List<p_int_artykul_pobierz> p_int_artkul_usun(int ar_id)
        {
            log.Info("p_int_artkul_usun");

            var m = new List<p_int_artykul_pobierz>();

            using (var db = new col_dataEntities())
            {
                var p = new SqlParameter("@p_ar_ids", SqlDbType.Int);
                p.Value = ar_id;

                m = db.Database.SqlQuery<p_int_artykul_pobierz>("exec p_int_artkul_usun @p_ar_ids", p).ToList();
            }

            return m;
        }
    }
}