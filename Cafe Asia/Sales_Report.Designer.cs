namespace Cafe_Asia
{
    partial class Sales_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DS_Sales = new Cafe_Asia.DS_Sales();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.salesTableAdapter = new Cafe_Asia.DS_SalesTableAdapters.salesTableAdapter();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_Sales
            // 
            this.DS_Sales.DataSetName = "DS_Sales";
            this.DS_Sales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.salesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cafe_Asia.Report_Sales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(757, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(8)))), ((int)(((byte)(35)))));
            this.iconPictureBox9.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconPictureBox9.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox9.IconSize = 34;
            this.iconPictureBox9.Location = new System.Drawing.Point(20, 467);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(35, 34);
            this.iconPictureBox9.TabIndex = 18;
            this.iconPictureBox9.TabStop = false;
            this.iconPictureBox9.Click += new System.EventHandler(this.iconPictureBox9_Click);
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.DS_Sales;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.iconPictureBox9);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Sales_Report";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Sales_Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Sales DS_Sales;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private DS_SalesTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        //  private DS_SalesTableAdapters.foodTableAdapter foodTableAdapter;
    }
}