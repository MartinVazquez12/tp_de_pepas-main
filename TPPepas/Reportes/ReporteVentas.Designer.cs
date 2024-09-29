namespace TPPepas.Reportes
{
    partial class ReporteVentas
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
            this.pepitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_reporte = new TPPepas.Reportes.Datos_reporte();
            this.pepitaTableAdapter = new TPPepas.Reportes.Datos_reporteTableAdapters.pepitaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pepitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pepitaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPPepas.Reportes.Reporte_ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1455, 668);
            this.reportViewer1.TabIndex = 0;
            // 
            // pepitaBindingSource
            // 
            this.pepitaBindingSource.DataMember = "pepita";
            this.pepitaBindingSource.DataSource = this.datos_reporte;
            // 
            // datos_reporte
            // 
            this.datos_reporte.DataSetName = "Datos_reporte";
            this.datos_reporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pepitaTableAdapter
            // 
            this.pepitaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 726);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVentas";
            this.Text = "ReporteVentas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pepitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Datos_reporte datos_reporte;
        private System.Windows.Forms.BindingSource pepitaBindingSource;
        private Datos_reporteTableAdapters.pepitaTableAdapter pepitaTableAdapter;
    }
}