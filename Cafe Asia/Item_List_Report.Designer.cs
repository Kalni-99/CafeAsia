namespace Cafe_Asia
{
    partial class Item_List_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DS_Item_List = new Cafe_Asia.DS_Item_List();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.fooditemTableAdapter = new Cafe_Asia.DS_Item_ListTableAdapters.fooditemTableAdapter();
            this.fooditemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Item_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooditemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_Item_List
            // 
            this.DS_Item_List.DataSetName = "DS_Item_List";
            this.DS_Item_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.fooditemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cafe_Asia.Report_Item_List.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(757, 333);
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
            this.iconPictureBox9.Location = new System.Drawing.Point(20, 399);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(35, 34);
            this.iconPictureBox9.TabIndex = 18;
            this.iconPictureBox9.TabStop = false;
            this.iconPictureBox9.Click += new System.EventHandler(this.iconPictureBox9_Click);
            // 
            // fooditemTableAdapter
            // 
            this.fooditemTableAdapter.ClearBeforeFill = true;
            // 
            // fooditemBindingSource
            // 
            this.fooditemBindingSource.DataMember = "fooditem";
            this.fooditemBindingSource.DataSource = this.DS_Item_List;
            // 
            // Item_List_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconPictureBox9);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Item_List_Report";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Item_List_Report";
            this.Load += new System.EventHandler(this.Item_List_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Item_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooditemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Item_List DS_Item_List;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private DS_Item_ListTableAdapters.fooditemTableAdapter fooditemTableAdapter;
        private System.Windows.Forms.BindingSource fooditemBindingSource;
    }
}