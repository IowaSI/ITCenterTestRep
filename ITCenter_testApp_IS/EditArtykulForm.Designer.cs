
namespace ITCenter_testApp_IS
{
    partial class EditArtykulForm
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
            this.txtNazwa = new DevExpress.XtraEditors.TextEdit();
            this.lblArNazwa = new DevExpress.XtraEditors.LabelControl();
            this.spinEditArLiczba = new DevExpress.XtraEditors.SpinEdit();
            this.btnArZapisz = new DevExpress.XtraEditors.SimpleButton();
            this.btnArAnuluj = new DevExpress.XtraEditors.SimpleButton();
            this.lblArLiczba = new DevExpress.XtraEditors.LabelControl();
            this.lblArCenaBr = new DevExpress.XtraEditors.LabelControl();
            this.lblArCenaNetto = new DevExpress.XtraEditors.LabelControl();
            this.spinEditArCenaBr = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditArCenaNt = new DevExpress.XtraEditors.SpinEdit();
            this.lblArDoList = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNazwa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditArLiczba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditArCenaBr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditArCenaNt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(50, 5);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtNazwa.TabIndex = 0;
            // 
            // lblArNazwa
            // 
            this.lblArNazwa.Location = new System.Drawing.Point(12, 12);
            this.lblArNazwa.Name = "lblArNazwa";
            this.lblArNazwa.Size = new System.Drawing.Size(32, 13);
            this.lblArNazwa.TabIndex = 1;
            this.lblArNazwa.Text = "Nazwa";
            // 
            // spinEditArLiczba
            // 
            this.spinEditArLiczba.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditArLiczba.Location = new System.Drawing.Point(50, 38);
            this.spinEditArLiczba.Name = "spinEditArLiczba";
            this.spinEditArLiczba.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditArLiczba.Size = new System.Drawing.Size(100, 20);
            this.spinEditArLiczba.TabIndex = 2;
            // 
            // btnArZapisz
            // 
            this.btnArZapisz.Location = new System.Drawing.Point(156, 76);
            this.btnArZapisz.Name = "btnArZapisz";
            this.btnArZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnArZapisz.TabIndex = 3;
            this.btnArZapisz.Text = "Zapisz";
            this.btnArZapisz.Click += new System.EventHandler(this.btnArZapisz_Click);
            // 
            // btnArAnuluj
            // 
            this.btnArAnuluj.Location = new System.Drawing.Point(245, 76);
            this.btnArAnuluj.Name = "btnArAnuluj";
            this.btnArAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnArAnuluj.TabIndex = 4;
            this.btnArAnuluj.Text = "Anuluj";
            this.btnArAnuluj.Click += new System.EventHandler(this.btnArAnuluj_Click);
            // 
            // lblArLiczba
            // 
            this.lblArLiczba.Location = new System.Drawing.Point(12, 41);
            this.lblArLiczba.Name = "lblArLiczba";
            this.lblArLiczba.Size = new System.Drawing.Size(29, 13);
            this.lblArLiczba.TabIndex = 5;
            this.lblArLiczba.Text = "Liczba";
            // 
            // lblArCenaBr
            // 
            this.lblArCenaBr.Location = new System.Drawing.Point(156, 12);
            this.lblArCenaBr.Name = "lblArCenaBr";
            this.lblArCenaBr.Size = new System.Drawing.Size(58, 13);
            this.lblArCenaBr.TabIndex = 6;
            this.lblArCenaBr.Text = "Cena brutto";
            // 
            // lblArCenaNetto
            // 
            this.lblArCenaNetto.Location = new System.Drawing.Point(156, 45);
            this.lblArCenaNetto.Name = "lblArCenaNetto";
            this.lblArCenaNetto.Size = new System.Drawing.Size(54, 13);
            this.lblArCenaNetto.TabIndex = 7;
            this.lblArCenaNetto.Text = "Cena netto";
            // 
            // spinEditArCenaBr
            // 
            this.spinEditArCenaBr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditArCenaBr.Location = new System.Drawing.Point(220, 5);
            this.spinEditArCenaBr.Name = "spinEditArCenaBr";
            this.spinEditArCenaBr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditArCenaBr.Size = new System.Drawing.Size(100, 20);
            this.spinEditArCenaBr.TabIndex = 9;
            // 
            // spinEditArCenaNt
            // 
            this.spinEditArCenaNt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditArCenaNt.Location = new System.Drawing.Point(220, 38);
            this.spinEditArCenaNt.Name = "spinEditArCenaNt";
            this.spinEditArCenaNt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditArCenaNt.Size = new System.Drawing.Size(100, 20);
            this.spinEditArCenaNt.TabIndex = 10;
            // 
            // lblArDoList
            // 
            this.lblArDoList.Location = new System.Drawing.Point(326, 12);
            this.lblArDoList.Name = "lblArDoList";
            this.lblArDoList.Size = new System.Drawing.Size(48, 13);
            this.lblArDoList.TabIndex = 12;
            this.lblArDoList.Text = "Dokument";
            // 
            // EditArtykulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 114);
            this.Controls.Add(this.lblArDoList);
            this.Controls.Add(this.spinEditArCenaNt);
            this.Controls.Add(this.spinEditArCenaBr);
            this.Controls.Add(this.lblArCenaNetto);
            this.Controls.Add(this.lblArCenaBr);
            this.Controls.Add(this.lblArLiczba);
            this.Controls.Add(this.btnArAnuluj);
            this.Controls.Add(this.btnArZapisz);
            this.Controls.Add(this.spinEditArLiczba);
            this.Controls.Add(this.lblArNazwa);
            this.Controls.Add(this.txtNazwa);
            this.Name = "EditArtykulForm";
            this.Text = "EditArtykulForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtNazwa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditArLiczba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditArCenaBr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditArCenaNt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNazwa;
        private DevExpress.XtraEditors.LabelControl lblArNazwa;
        private DevExpress.XtraEditors.SpinEdit spinEditArLiczba;
        private DevExpress.XtraEditors.SimpleButton btnArZapisz;
        private DevExpress.XtraEditors.SimpleButton btnArAnuluj;
        private DevExpress.XtraEditors.LabelControl lblArLiczba;
        private DevExpress.XtraEditors.LabelControl lblArCenaBr;
        private DevExpress.XtraEditors.LabelControl lblArCenaNetto;
        private DevExpress.XtraEditors.SpinEdit spinEditArCenaBr;
        private DevExpress.XtraEditors.SpinEdit spinEditArCenaNt;
        private DevExpress.XtraEditors.LabelControl lblArDoList;
    }
}