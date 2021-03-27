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
using System.Web.UI.WebControls;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using System.Threading;

namespace ITCenter_testApp_IS
{
    public partial class mainFor : XtraForm
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        private List<p_int_dokument_pobierz> doki_model;

        List<int> expanded_master_rows_doki;

        p_int_dokument_pobierz dok_edit;
        p_int_artykul_pobierz art_edit;

        private List<p_int_artykul_pobierz> artykuly_model;

        EditDokForm editDokform;
        EditArtykulForm editArtkForm;

        public mainFor()
        {
            try
            {
                InitializeComponent();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void mainFor_Load(object sender, EventArgs e)
        {
            try
            {
                var app_data = Api.GetAppInfo();

                lblAppData.Text = "RepoName:" + app_data.Name;
                lblAppData.Text += Environment.NewLine + "Owner:" + app_data.Owner.Login;
                lblAppData.Text += Environment.NewLine + "Created at:" + app_data.CreatedAt.ToString("yyyy-MM-dd");
                lblAppData.Text += Environment.NewLine + "Ocena:" + app_data.StargazersCount;

                expanded_master_rows_doki = new List<int>();

                doki_model = DAO.p_int_dokument_pobierz(null);
                artykuly_model = DAO.p_int_artykul_pobierz(null);

                gridControlDoki.DataSource = doki_model;
                gridControlArtykuly.DataSource = artykuly_model;                
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void btnCallApi_Click(object sender, EventArgs e)
        {
            try
            {
                var user = txtUserName.Text;

                var wynik = Api.GetUserInfo(user);

                lblApiWynik.Text = wynik.Result.Login;
                lblApiWynik.Text += Environment.NewLine + "Followers: " + wynik.Result.Followers;
                lblApiWynik.Text += Environment.NewLine + "Following: " + wynik.Result.Following;
                lblApiWynik.Text += Environment.NewLine + "CreatedAt: " + wynik.Result.CreatedAt.Date.ToString("yyyy-MM-dd");
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void gridViewDoki_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            try
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                var dok = view.GetRow(e.RowHandle) as p_int_dokument_pobierz;

                if (dok != null)
                {
                    e.IsEmpty = !doki_model.Any(x => x.do_id == dok.do_id);
                }
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void gridViewDoki_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            try
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                var dok = view.GetRow(e.RowHandle) as p_int_dokument_pobierz;

                if (dok != null)
                {
                    e.ChildList = DAO.p_int_artykul_pobierz(dok.do_id);
                }
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void gridViewDoki_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            try
            {

                e.RelationCount = 1;
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }
        
        private void gridViewDoki_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            try
            {
                e.RelationName = "Artykuły";
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dok_edit = new p_int_dokument_pobierz();
                EditDok(dok_edit, "Nowy dokument", AddNewDok);
                ExpandMasterRowDokiAfterCallback();
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void AddNewDok(object sender, FormClosingEventArgs e)
        {
            if (((EditDokForm)sender).DialogResult == DialogResult.OK)
            {
                try
                {
                    doki_model = DAO.p_int_dokument_dodaj(dok_edit);
                    gridControlDoki.DataSource = doki_model;                    
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            dok_edit = null;            
        }

        private void EditDok(object sender, FormClosingEventArgs e)
        {
            if (((EditDokForm)sender).DialogResult == DialogResult.OK)
            {
                try
                {
                    doki_model = DAO.p_int_dokument_update(dok_edit);
                    gridControlDoki.DataSource = doki_model;
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            dok_edit = null;
        }

        private void AddNewArtk(object sender, FormClosingEventArgs e)
        {
            if (((EditArtykulForm)sender).DialogResult == DialogResult.OK)
            {
                try
                {
                    artykuly_model = DAO.p_int_artkul_dodaj(art_edit);

                    gridControlArtykuly.DataSource = artykuly_model;
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            art_edit = null;
        }

        private void EditArtk(object sender, FormClosingEventArgs e)
        {
            if (((EditArtykulForm)sender).DialogResult == DialogResult.OK)
            {
                try
                {
                    artykuly_model = DAO.p_int_artkul_update(art_edit);
                    gridControlArtykuly.DataSource = artykuly_model;
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            art_edit = null;
        }

        private void EditDok(p_int_dokument_pobierz dokument, string windowTitle, FormClosingEventHandler closedDelegate)
        {
            editDokform = new EditDokForm(dokument) { Text = windowTitle };
            editDokform.FormClosing += closedDelegate;
            editDokform.ShowDialog();
        }

        private void EditArtykul(p_int_artykul_pobierz artykul, string windowTitle, FormClosingEventHandler closedDelegate)
        {
            editArtkForm = new EditArtykulForm(artykul) { Text = windowTitle };
            editArtkForm.FormClosing += closedDelegate;
            editArtkForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dok_id = GetDoIdByRow(gridViewDoki.FocusedRowHandle);

                if (dok_id == null)
                {
                    MessageBox.Show("Brak wybranego dokumenty do edycji");
                    return;
                }

                dok_edit = doki_model.Where(x => x.do_id == dok_id).FirstOrDefault();

                EditDok(dok_edit, "Edycja", EditDok);
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }
        
        private int? GetDoIdByRow(int rowHandle)
        {
            return (int?)gridViewDoki.GetRowCellValue(rowHandle, "do_id");
        }

        private int? GetArDoIdByRow(int rowHandle)
        {
            return (int?)gridViewArtykuly.GetRowCellValue(rowHandle, "ar_id");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Na pewno chcesz usunąć wybrany dokument ?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dok_id = GetDoIdByRow(gridViewDoki.FocusedRowHandle);

                    if (dok_id == null)
                    {
                        MessageBox.Show("Brak wybranego dokumentu do usunięcia");
                        return;
                    }

                    dok_edit = doki_model.Where(x => x.do_id == dok_id).FirstOrDefault();

                    doki_model = DAO.p_int_dokument_usun(dok_edit.do_id);
                    artykuly_model = DAO.p_int_artykul_pobierz(null);

                    gridControlDoki.DataSource = doki_model;
                    gridControlArtykuly.DataSource = artykuly_model;
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
        }

        private void btnArtAdd_Click(object sender, EventArgs e)
        {
            art_edit = new p_int_artykul_pobierz();
            EditArtykul(art_edit, "Nowy artykuł",AddNewArtk);
        }

        private void btnArtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var art_id = GetArDoIdByRow(gridViewArtykuly.FocusedRowHandle);

                if (art_id == null)
                {
                    MessageBox.Show("Brak wybranego artykułu dla edycji");
                    return;
                }

                art_edit = artykuly_model.Where(x => x.ar_id == art_id).FirstOrDefault();

                if (art_edit == null)
                {
                    MessageBox.Show("Nie udało się pobrać danych dla artykułu");
                    return;
                }

                EditArtykul(art_edit, "Edycja", EditArtk);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void btnArtDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Na pewno chcesz usunąć wybrany artykuł ?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var art_id = GetArDoIdByRow(gridViewArtykuly.FocusedRowHandle);

                    if (art_id == null)
                    {
                        MessageBox.Show("Brak wybranego artykułu do usuwania");
                        return;
                    }

                    art_edit = artykuly_model.Where(x => x.ar_id == art_id).FirstOrDefault();

                    if (art_edit == null)
                    {
                        MessageBox.Show("Nie udało się pobrać danych dla artykułu");
                        return;
                    }

                    artykuly_model = DAO.p_int_artkul_usun(art_edit.ar_id);
                    gridControlArtykuly.DataSource = artykuly_model;
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
        }

        private void gridViewArtykuly_GroupRowExpanded(object sender, RowEventArgs e)
        {
            
        }

        private void ExpandMasterRowDokiAfterCallback()
        {
            foreach(var i in expanded_master_rows_doki)
            {
                gridViewDoki.ExpandGroupRow(i);
            }
        }

        private void gridViewDoki_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            var view = (sender as DevExpress.XtraGrid.Views.Grid.GridView);
            
            int dataSourceRowIndex = view.GetDataSourceRowIndex(e.RowHandle);

            if(expanded_master_rows_doki.Where(x => x.Equals(dataSourceRowIndex)).ToList().Count <=0 )
            {
                expanded_master_rows_doki.Add(dataSourceRowIndex);
            }
        }

        private void gridViewDoki_MasterRowCollapsed(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            var view = (sender as DevExpress.XtraGrid.Views.Grid.GridView);

            int dataSourceRowIndex = view.GetDataSourceRowIndex(e.RowHandle);

            if (expanded_master_rows_doki.Where(x => x.Equals(dataSourceRowIndex)).ToList().Count > 0)
            {
                expanded_master_rows_doki.Remove(dataSourceRowIndex);
            }
        }
    }
}