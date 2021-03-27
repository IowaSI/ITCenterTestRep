
namespace ITCenter_testApp_IS
{
    partial class EditDokForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDonazwa = new DevExpress.XtraEditors.TextEdit();
            this.txtNrKlienta = new DevExpress.XtraEditors.TextEdit();
            this.spinEditCenaBr = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditCenaNetto = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnEditFormZapisz = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditFormAnul = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditData = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonazwa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNrKlienta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCenaBr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCenaNetto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonazwa
            // 
            this.txtDonazwa.Location = new System.Drawing.Point(114, 32);
            this.txtDonazwa.Name = "txtDonazwa";
            this.txtDonazwa.Properties.Tag = "Nazwa dokumentu";
            this.txtDonazwa.Size = new System.Drawing.Size(100, 20);
            this.txtDonazwa.TabIndex = 0;
            this.txtDonazwa.Tag = "Nazwa dokumentu";
            // 
            // txtNrKlienta
            // 
            this.txtNrKlienta.Location = new System.Drawing.Point(114, 58);
            this.txtNrKlienta.Name = "txtNrKlienta";
            this.txtNrKlienta.Size = new System.Drawing.Size(100, 20);
            this.txtNrKlienta.TabIndex = 3;
            // 
            // spinEditCenaBr
            // 
            this.spinEditCenaBr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCenaBr.Location = new System.Drawing.Point(288, 32);
            this.spinEditCenaBr.Name = "spinEditCenaBr";
            this.spinEditCenaBr.Properties.AllowMouseWheel = false;
            this.spinEditCenaBr.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.spinEditCenaBr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCenaBr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditCenaBr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditCenaBr.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.spinEditCenaBr.Size = new System.Drawing.Size(100, 20);
            this.spinEditCenaBr.TabIndex = 5;
            // 
            // spinEditCenaNetto
            // 
            this.spinEditCenaNetto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCenaNetto.Location = new System.Drawing.Point(288, 58);
            this.spinEditCenaNetto.Name = "spinEditCenaNetto";
            this.spinEditCenaNetto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCenaNetto.Size = new System.Drawing.Size(100, 20);
            this.spinEditCenaNetto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa dokumentu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numer klienta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cena brutto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cena netto";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(394, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data";
            // 
            // btnEditFormZapisz
            // 
            this.btnEditFormZapisz.Location = new System.Drawing.Point(397, 88);
            this.btnEditFormZapisz.Name = "btnEditFormZapisz";
            this.btnEditFormZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnEditFormZapisz.TabIndex = 12;
            this.btnEditFormZapisz.Text = "Zapisz";
            this.btnEditFormZapisz.Click += new System.EventHandler(this.btnEditFormZapisz_Click);
            // 
            // btnEditFormAnul
            // 
            this.btnEditFormAnul.Location = new System.Drawing.Point(479, 88);
            this.btnEditFormAnul.Name = "btnEditFormAnul";
            this.btnEditFormAnul.Size = new System.Drawing.Size(75, 22);
            this.btnEditFormAnul.TabIndex = 13;
            this.btnEditFormAnul.Text = "Anuluj";
            this.btnEditFormAnul.Click += new System.EventHandler(this.btnEditFormAnul_Click);
            // 
            // dateEditData
            // 
            this.dateEditData.EditValue = null;
            this.dateEditData.Location = new System.Drawing.Point(431, 35);
            this.dateEditData.Name = "dateEditData";
            this.dateEditData.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditData.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditData.Size = new System.Drawing.Size(100, 20);
            this.dateEditData.TabIndex = 14;
            // 
            // EditDokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 110);
            this.Controls.Add(this.dateEditData);
            this.Controls.Add(this.btnEditFormAnul);
            this.Controls.Add(this.btnEditFormZapisz);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinEditCenaNetto);
            this.Controls.Add(this.spinEditCenaBr);
            this.Controls.Add(this.txtNrKlienta);
            this.Controls.Add(this.txtDonazwa);
            this.Name = "EditDokForm";
            this.Text = "EditDokForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtDonazwa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNrKlienta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCenaBr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCenaNetto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditData.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDonazwa;
        private DevExpress.XtraEditors.TextEdit txtNrKlienta;
        private DevExpress.XtraEditors.SpinEdit spinEditCenaBr;
        private DevExpress.XtraEditors.SpinEdit spinEditCenaNetto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblData;
        private DevExpress.XtraEditors.SimpleButton btnEditFormZapisz;
        private DevExpress.XtraEditors.SimpleButton btnEditFormAnul;
        private DevExpress.XtraEditors.DateEdit dateEditData;
    }
}