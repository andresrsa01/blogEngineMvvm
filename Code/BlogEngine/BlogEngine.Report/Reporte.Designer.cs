namespace BlogEngine.Report
{
    partial class Reporte
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
            this.BlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BlogEngineDataSet = new BlogEngine.Report.BlogEngineDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BlogsTableAdapter = new BlogEngine.Report.BlogEngineDataSetTableAdapters.BlogsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BlogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogEngineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BlogsBindingSource
            // 
            this.BlogsBindingSource.DataMember = "Blogs";
            this.BlogsBindingSource.DataSource = this.BlogEngineDataSet;
            // 
            // BlogEngineDataSet
            // 
            this.BlogEngineDataSet.DataSetName = "BlogEngineDataSet";
            this.BlogEngineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BlogsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BlogEngine.Report.ReportBlog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(414, 312);
            this.reportViewer1.TabIndex = 0;
            // 
            // BlogsTableAdapter
            // 
            this.BlogsTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 348);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte";
            this.ShowIcon = false;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BlogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlogEngineDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BlogsBindingSource;
        private BlogEngineDataSet BlogEngineDataSet;
        private BlogEngineDataSetTableAdapters.BlogsTableAdapter BlogsTableAdapter;
    }
}