namespace Cafe_Asia
{
    partial class Customer_Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.delivaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Customer = new Cafe_Asia.DS_Customer();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.delivaryTableAdapter = new Cafe_Asia.DS_CustomerTableAdapters.delivaryTableAdapter();
            this.registerTableAdapter = new Cafe_Asia.DS_CustomerTableAdapters.registerTableAdapter();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.delivaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // delivaryBindingSource
            // 
            this.delivaryBindingSource.DataMember = "delivary";
            this.delivaryBindingSource.DataSource = this.DS_Customer;
            // 
            // DS_Customer
            // 
            this.DS_Customer.DataSetName = "DS_Customer";
            this.DS_Customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.DS_Customer;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.delivaryBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.registerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cafe_Asia.Report_Customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(738, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // delivaryTableAdapter
            // 
            this.delivaryTableAdapter.ClearBeforeFill = true;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.iconPictureBox9.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconPictureBox9.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox9.IconSize = 34;
            this.iconPictureBox9.Location = new System.Drawing.Point(23, 429);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(35, 34);
            this.iconPictureBox9.TabIndex = 18;
            this.iconPictureBox9.TabStop = false;
            this.iconPictureBox9.Click += new System.EventHandler(this.iconPictureBox9_Click);
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.iconPictureBox9);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Customer_Report";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Customer_Report";
            this.Load += new System.EventHandler(this.Customer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delivaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource delivaryBindingSource;
        private DS_Customer DS_Customer;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private DS_CustomerTableAdapters.delivaryTableAdapter delivaryTableAdapter;
        private DS_CustomerTableAdapters.registerTableAdapter registerTableAdapter;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
    }
}