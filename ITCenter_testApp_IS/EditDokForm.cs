using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITCenter_testApp_IS.Model;

namespace ITCenter_testApp_IS
{
    public partial class EditDokForm : Form
    {
        public EditDokForm(p_int_dokument_pobierz dok)
        {
            InitializeComponent();
           
            txtDonazwa.DataBindings.Add("EditValue", dok, "do_nazwa");
            txtNrKlienta.DataBindings.Add("EditValue", dok, "do_numer_klienta");
            spinEditCenaBr.DataBindings.Add("EditValue", dok, "do_cena_brutto",true, DataSourceUpdateMode.OnPropertyChanged);
            spinEditCenaNetto.DataBindings.Add("EditValue", dok, "do_cena_netto",true, DataSourceUpdateMode.OnPropertyChanged);
            dateEditData.DataBindings.Add("EditValue", dok, "do_data",true,DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnEditFormZapisz_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnEditFormAnul_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
