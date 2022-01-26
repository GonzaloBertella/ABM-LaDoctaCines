namespace ABMLaDoctaCines
{
    partial class frmPromociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromociones));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PromocionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaDoctaCinesDataSetTODAS = new ABMLaDoctaCines.LaDoctaCinesDataSetTODAS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PromocionesTableAdapter = new ABMLaDoctaCines.LaDoctaCinesDataSetTODASTableAdapters.PromocionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PromocionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PromocionesBindingSource
            // 
            this.PromocionesBindingSource.DataMember = "Promociones";
            this.PromocionesBindingSource.DataSource = this.LaDoctaCinesDataSetTODAS;
            // 
            // LaDoctaCinesDataSetTODAS
            // 
            this.LaDoctaCinesDataSetTODAS.DataSetName = "LaDoctaCinesDataSetTODAS";
            this.LaDoctaCinesDataSetTODAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTituloFormHijo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 100);
            this.panel1.TabIndex = 5;
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormHijo.Location = new System.Drawing.Point(329, 34);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(330, 33);
            this.lblTituloFormHijo.TabIndex = 5;
            this.lblTituloFormHijo.Text = "Listado de Promociones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PromocionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMLaDoctaCines.rptPromociones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(204, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(580, 316);
            this.reportViewer1.TabIndex = 6;
            // 
            // PromocionesTableAdapter
            // 
            this.PromocionesTableAdapter.ClearBeforeFill = true;
            // 
            // frmPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(988, 558);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPromociones";
            this.Text = "Promociones";
            this.Load += new System.EventHandler(this.frmPromociones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PromocionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PromocionesBindingSource;
        private LaDoctaCinesDataSetTODAS LaDoctaCinesDataSetTODAS;
        private LaDoctaCinesDataSetTODASTableAdapters.PromocionesTableAdapter PromocionesTableAdapter;
        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}