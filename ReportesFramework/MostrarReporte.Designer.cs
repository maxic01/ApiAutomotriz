namespace ReportesFramework
{
    partial class MostrarReporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bD_PROGDataSet = new ReportesFramework.BD_PROGDataSet();
            this.reporteProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteProductosTableAdapter = new ReportesFramework.BD_PROGDataSetTableAdapters.reporteProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PROGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesFramework.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_PROGDataSet
            // 
            this.bD_PROGDataSet.DataSetName = "BD_PROGDataSet";
            this.bD_PROGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteProductosBindingSource
            // 
            this.reporteProductosBindingSource.DataMember = "reporteProductos";
            this.reporteProductosBindingSource.DataSource = this.bD_PROGDataSet;
            // 
            // reporteProductosTableAdapter
            // 
            this.reporteProductosTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarReporte";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PROGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteProductosBindingSource;
        private BD_PROGDataSet bD_PROGDataSet;
        private BD_PROGDataSetTableAdapters.reporteProductosTableAdapter reporteProductosTableAdapter;
    }
}

