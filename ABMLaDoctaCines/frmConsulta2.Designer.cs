namespace ABMLaDoctaCines
{
    partial class frmConsulta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta2));
            this.label2 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.MostrarConsulta = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxConsulta = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(36, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Letra";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(34, 224);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 2;
            this.txtLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ingrese los siguientes parámetros";
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblTituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormHijo.Location = new System.Drawing.Point(36, 185);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(36, 19);
            this.lblTituloFormHijo.TabIndex = 22;
            this.lblTituloFormHijo.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(34, 155);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 1;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnConsultar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnConsultar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 32;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(132, 299);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsultar.Rotation = 0D;
            this.btnConsultar.Size = new System.Drawing.Size(151, 50);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 95);
            this.label3.TabIndex = 26;
            this.label3.Text = "Si deja los campos vacíos\r\nse filtrará por los siguientes\r\nvalores genéricos:\r\nAñ" +
    "o = 2020\r\nLetra = Ninguna";
            // 
            // lblConsulta
            // 
            this.lblConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConsulta.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblConsulta.Location = new System.Drawing.Point(60, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Padding = new System.Windows.Forms.Padding(30, 60, 30, 0);
            this.lblConsulta.Size = new System.Drawing.Size(615, 186);
            this.lblConsulta.TabIndex = 27;
            this.lblConsulta.Text = resources.GetString("lblConsulta.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvConsulta);
            this.panel1.Controls.Add(this.MostrarConsulta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblConsulta);
            this.panel1.Controls.Add(this.rtxConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(283, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(60, 0, 30, 0);
            this.panel1.Size = new System.Drawing.Size(705, 558);
            this.panel1.TabIndex = 28;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(60, 186);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(615, 266);
            this.dgvConsulta.TabIndex = 34;
            // 
            // MostrarConsulta
            // 
            this.MostrarConsulta.BackColor = System.Drawing.Color.Transparent;
            this.MostrarConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.MostrarConsulta.FlatAppearance.BorderSize = 0;
            this.MostrarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.MostrarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.MostrarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarConsulta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MostrarConsulta.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.MostrarConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.MostrarConsulta.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.MostrarConsulta.IconColor = System.Drawing.Color.Gainsboro;
            this.MostrarConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MostrarConsulta.IconSize = 32;
            this.MostrarConsulta.Location = new System.Drawing.Point(671, 3);
            this.MostrarConsulta.Name = "MostrarConsulta";
            this.MostrarConsulta.Rotation = 0D;
            this.MostrarConsulta.Size = new System.Drawing.Size(34, 38);
            this.MostrarConsulta.TabIndex = 33;
            this.MostrarConsulta.UseVisualStyleBackColor = false;
            this.MostrarConsulta.Click += new System.EventHandler(this.MostrarConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // rtxConsulta
            // 
            this.rtxConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.rtxConsulta.Font = new System.Drawing.Font("Courier New", 11F);
            this.rtxConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtxConsulta.Location = new System.Drawing.Point(11, 36);
            this.rtxConsulta.Name = "rtxConsulta";
            this.rtxConsulta.ReadOnly = true;
            this.rtxConsulta.Size = new System.Drawing.Size(681, 335);
            this.rtxConsulta.TabIndex = 32;
            this.rtxConsulta.Text = resources.GetString("rtxConsulta.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.lblTituloFormHijo);
            this.panel2.Controls.Add(this.txtLetra);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 558);
            this.panel2.TabIndex = 29;
            // 
            // frmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(988, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmConsulta2";
            this.Text = "Consulta N°2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.TextBox txtAño;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxConsulta;
        private FontAwesome.Sharp.IconButton MostrarConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}