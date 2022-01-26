namespace ABMLaDoctaCines
{
    partial class frmGraficoFacturacion
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
            this.pa_Grafico_Ventas_AnualesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaDoctaCinesDataSetTODAS = new ABMLaDoctaCines.LaDoctaCinesDataSetTODAS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pa_Grafico_Ventas_AnualesTableAdapter = new ABMLaDoctaCines.LaDoctaCinesDataSetTODASTableAdapters.pa_Grafico_Ventas_AnualesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pa_Grafico_Ventas_AnualesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).BeginInit();
            this.SuspendLayout();
            // 
            // pa_Grafico_Ventas_AnualesBindingSource
            // 
            this.pa_Grafico_Ventas_AnualesBindingSource.DataMember = "pa_Grafico_Ventas_Anuales";
            this.pa_Grafico_Ventas_AnualesBindingSource.DataSource = this.LaDoctaCinesDataSetTODAS;
            // 
            // LaDoctaCinesDataSetTODAS
            // 
            this.LaDoctaCinesDataSetTODAS.DataSetName = "LaDoctaCinesDataSetTODAS";
            this.LaDoctaCinesDataSetTODAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pa_Grafico_Ventas_AnualesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMLaDoctaCines.rpGrafico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(972, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // pa_Grafico_Ventas_AnualesTableAdapter
            // 
            this.pa_Grafico_Ventas_AnualesTableAdapter.ClearBeforeFill = true;
            // 
            // frmGraficoFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(972, 485);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmGraficoFacturacion";
            this.Text = "frmGraficoFacturacion";
            this.Load += new System.EventHandler(this.frmGraficoFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pa_Grafico_Ventas_AnualesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pa_Grafico_Ventas_AnualesBindingSource;
        private LaDoctaCinesDataSetTODAS LaDoctaCinesDataSetTODAS;
        private LaDoctaCinesDataSetTODASTableAdapters.pa_Grafico_Ventas_AnualesTableAdapter pa_Grafico_Ventas_AnualesTableAdapter;
    }
}