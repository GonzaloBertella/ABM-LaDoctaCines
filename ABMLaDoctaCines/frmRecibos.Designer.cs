namespace ABMLaDoctaCines
{
    partial class frmRecibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibos));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Detalles_RecibosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaDoctaCinesDataSetTODAS = new ABMLaDoctaCines.LaDoctaCinesDataSetTODAS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detalles_RecibosTableAdapter = new ABMLaDoctaCines.LaDoctaCinesDataSetTODASTableAdapters.Detalles_RecibosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_RecibosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalles_RecibosBindingSource
            // 
            this.Detalles_RecibosBindingSource.DataMember = "Detalles_Recibos";
            this.Detalles_RecibosBindingSource.DataSource = this.LaDoctaCinesDataSetTODAS;
            // 
            // LaDoctaCinesDataSetTODAS
            // 
            this.LaDoctaCinesDataSetTODAS.DataSetName = "LaDoctaCinesDataSetTODAS";
            this.LaDoctaCinesDataSetTODAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTituloFormHijo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 100);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormHijo.Location = new System.Drawing.Point(363, 34);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(262, 33);
            this.lblTituloFormHijo.TabIndex = 3;
            this.lblTituloFormHijo.Text = "Listado de Recibos";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Detalles_RecibosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMLaDoctaCines.rptRecibos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(199, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(579, 329);
            this.reportViewer1.TabIndex = 5;
            // 
            // Detalles_RecibosTableAdapter
            // 
            this.Detalles_RecibosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(988, 558);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRecibos";
            this.Text = "Recibos";
            this.Load += new System.EventHandler(this.frmRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_RecibosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Detalles_RecibosBindingSource;
        private LaDoctaCinesDataSetTODAS LaDoctaCinesDataSetTODAS;
        private LaDoctaCinesDataSetTODASTableAdapters.Detalles_RecibosTableAdapter Detalles_RecibosTableAdapter;
        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}