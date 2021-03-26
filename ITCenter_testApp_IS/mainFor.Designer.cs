
namespace ITCenter_testApp_IS
{
    partial class mainFor
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpd = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCallApi = new DevExpress.XtraEditors.SimpleButton();
            this.lblApiWynik = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblAppData = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1462, 615);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1462, 615);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Dokumenty";
            this.tabNavigationPage1.Controls.Add(this.btnUpd);
            this.tabNavigationPage1.Controls.Add(this.btnNew);
            this.tabNavigationPage1.Controls.Add(this.btnDelete);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1462, 582);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Artkuły";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(300, 150);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Api";
            this.tabNavigationPage3.Controls.Add(this.lblAppData);
            this.tabNavigationPage3.Controls.Add(this.labelControl2);
            this.tabNavigationPage3.Controls.Add(this.lblApiWynik);
            this.tabNavigationPage3.Controls.Add(this.btnCallApi);
            this.tabNavigationPage3.Controls.Add(this.labelControl1);
            this.tabNavigationPage3.Controls.Add(this.txtUserName);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1462, 582);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(84, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Insert";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(165, 3);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(77, 23);
            this.btnUpd.TabIndex = 2;
            this.btnUpd.Text = "Update";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(70, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "User name";
            // 
            // btnCallApi
            // 
            this.btnCallApi.Location = new System.Drawing.Point(95, 29);
            this.btnCallApi.Name = "btnCallApi";
            this.btnCallApi.Size = new System.Drawing.Size(75, 23);
            this.btnCallApi.TabIndex = 2;
            this.btnCallApi.Text = "Pobierz info";
            this.btnCallApi.Click += new System.EventHandler(this.btnCallApi_Click);
            // 
            // lblApiWynik
            // 
            this.lblApiWynik.Location = new System.Drawing.Point(176, 6);
            this.lblApiWynik.Name = "lblApiWynik";
            this.lblApiWynik.Size = new System.Drawing.Size(46, 13);
            this.lblApiWynik.TabIndex = 3;
            this.lblApiWynik.Text = "Wynik api";
            this.lblApiWynik.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "App data:";
            // 
            // lblAppData
            // 
            this.lblAppData.Location = new System.Drawing.Point(63, 141);
            this.lblAppData.Name = "lblAppData";
            this.lblAppData.Size = new System.Drawing.Size(0, 13);
            this.lblAppData.TabIndex = 5;
            // 
            // mainFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 615);
            this.Controls.Add(this.tabPane1);
            this.Name = "mainFor";
            this.Text = " ";
            this.Load += new System.EventHandler(this.mainFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnCallApi;
        private DevExpress.XtraEditors.LabelControl lblApiWynik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblAppData;
    }
}