namespace ReportesFramework
{
    partial class MostrarFacturas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bD_PROGDataSet1 = new ReportesFramework.BD_PROGDataSet1();
            this.reporteFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteFacturasTableAdapter = new ReportesFramework.BD_PROGDataSet1TableAdapters.reporteFacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PROGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteFacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesFramework.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_PROGDataSet1
            // 
            this.bD_PROGDataSet1.DataSetName = "BD_PROGDataSet1";
            this.bD_PROGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteFacturasBindingSource
            // 
            this.reporteFacturasBindingSource.DataMember = "reporteFacturas";
            this.reporteFacturasBindingSource.DataSource = this.bD_PROGDataSet1;
            // 
            // reporteFacturasTableAdapter
            // 
            this.reporteFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarFacturas";
            this.Text = "MostrarFacturas";
            this.Load += new System.EventHandler(this.MostrarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PROGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteFacturasBindingSource;
        private BD_PROGDataSet1 bD_PROGDataSet1;
        private BD_PROGDataSet1TableAdapters.reporteFacturasTableAdapter reporteFacturasTableAdapter;
    }
}