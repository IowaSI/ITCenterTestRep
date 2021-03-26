using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITCenter_testApp_IS.Model;

namespace ITCenter_testApp_IS
{
    public partial class mainFor : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mainFor()
        {
            InitializeComponent();
        }

        private void mainFor_Load(object sender, EventArgs e)
        {
            log.Info("mainFor_Load()");

            log.Info("Api.GetAppInfo()");
            var app_data = Api.GetAppInfo();

            lblAppData.Text = "RepoName:" + app_data.Name;
            lblAppData.Text += Environment.NewLine + "Owner:" + app_data.Owner.Login;
            lblAppData.Text += Environment.NewLine + "Created at:" + app_data.CreatedAt.ToString("yyyy-MM-dd");
            lblAppData.Text += Environment.NewLine + "Ocena:" + app_data.StargazersCount;

            //dataGridViewDoki.DataSource = DAO.p_int_dokument_pobierz(null);
            //gridControlDoki.DataSource = DAO.p_int_dokument_pobierz(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Na pewno chcesz usunąć dane?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    log.Info("btnDelete_ItemClick()");
                    //p_int_dokument_pobierz f = (p_int_dokument_pobierz)gridViewDoki.GetFocusedRow();

                    //to do kilka rows

                    //gridControlDoki.DataSource  = DAO.p_int_dokument_usun(f.do_id.ToString());

                }
                catch (Exception ex)
                {
                    log.Error(ex.InnerException);
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            log.Info("btnAdd_ItemClick()");

            var new_dok = new p_int_dokument_pobierz();
            /*
            new_dok.do_cena_brutto = do_cena_bruttoSpinEdit.Value;
            new_dok.do_cena_netto = do_cena_nettoSpinEdit.Value;
            new_dok.do_data = do_dataDateEdit.DateTime;
            new_dok.do_nazwa = do_nazwaTextEdit.Text;
            new_dok.do_numer_klienta = do_numer_klientaTextEdit.Text;
            */
            //gridControlDoki.DataSource = DAO.p_int_dokument_dodaj(new_dok);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnCallApi_Click(object sender, EventArgs e)
        {
            var user = txtUserName.Text;

            log.Info("Api.GetUserInfo: " + user);
            var wynik = Api.GetUserInfo(user);

            lblApiWynik.Text = wynik.Result.Login;
            lblApiWynik.Text += Environment.NewLine + "Followers: " + wynik.Result.Followers;
            lblApiWynik.Text += Environment.NewLine + "Following: " + wynik.Result.Following;
            lblApiWynik.Text += Environment.NewLine + "CreatedAt: " + wynik.Result.CreatedAt.Date.ToString("yyyy-MM-dd");
        }
    }
}