using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ITCenter_testApp_IS.Model;

namespace ITCenter_testApp_IS
{
    public partial class EditArtykulForm : Form
    {
        LookUpEdit cmbDoList;
        public EditArtykulForm(p_int_artykul_pobierz art)
        {
            InitializeComponent();
            
            //rysowanie listy z dokumentami
            CreateComboBoxEdit(art);
           
            txtNazwa.DataBindings.Add("EditValue", art, "ar_nazwa");
            spinEditArCenaBr.DataBindings.Add("EditValue", art, "ar_cena_brutto", true, DataSourceUpdateMode.OnPropertyChanged);
            spinEditArCenaNt.DataBindings.Add("EditValue", art, "ar_cena_netto", true, DataSourceUpdateMode.OnPropertyChanged);
            spinEditArLiczba.DataBindings.Add("EditValue", art, "ar_liczba", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbDoList.DataBindings.Add("EditValue", art, "nar_do_id", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void CreateComboBoxEdit(p_int_artykul_pobierz art)
        {
            var do_list = DAO.p_int_dokument_pobierz(null);

            cmbDoList = new LookUpEdit();
            cmbDoList.Bounds = new Rectangle(lblArDoList.Location.X + lblArDoList.Width + 5, spinEditArCenaBr.Location.Y, 120, 20);
            cmbDoList.Properties.DataSource = do_list;
            cmbDoList.Properties.ValueMember = "do_id";
            cmbDoList.Properties.DisplayMember = "do_nazwa";
            cmbDoList.Properties.NullText = null;
            cmbDoList.EditValue = null;

            var LookUpColumnInfo = new LookUpColumnInfo("do_id", "do_id");
            LookUpColumnInfo.Visible = false;

            cmbDoList.Properties.Columns.Add(LookUpColumnInfo);

            LookUpColumnInfo = new LookUpColumnInfo("do_nazwa", "Nazwa");
            LookUpColumnInfo.Visible = true;

            cmbDoList.Properties.Columns.Add(LookUpColumnInfo);

            //zaznaczenie dokumentu, do którego należy artykul
            if (art.nar_do_id != null)
            {
                cmbDoList.EditValue = art.nar_do_id;
            }

            this.Controls.Add(cmbDoList);
        }
    
        private void btnArZapisz_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnArAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
