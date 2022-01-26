namespace ABMLaDoctaCines
{
    partial class frmConsulta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta1));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsulta1 = new FontAwesome.Sharp.IconButton();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MostrarConsulta = new FontAwesome.Sharp.IconButton();
            this.rtxConsulta = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(60, 191);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(615, 261);
            this.dgvConsulta.TabIndex = 0;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConsulta1.FlatAppearance.BorderSize = 0;
            this.btnConsulta1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnConsulta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsulta1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnConsulta1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsulta1.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnConsulta1.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsulta1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulta1.IconSize = 32;
            this.btnConsulta1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta1.Location = new System.Drawing.Point(130, 347);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsulta1.Rotation = 0D;
            this.btnConsulta1.Size = new System.Drawing.Size(153, 50);
            this.btnConsulta1.TabIndex = 4;
            this.btnConsulta1.Text = "Consultar";
            this.btnConsulta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta1.UseVisualStyleBackColor = false;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(33, 157);
            this.txtMinimo.MaxLength = 5;
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtMinimo.TabIndex = 1;
            this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimo_KeyPress);
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblTituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormHijo.Location = new System.Drawing.Point(28, 187);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(103, 19);
            this.lblTituloFormHijo.TabIndex = 12;
            this.lblTituloFormHijo.Text = "Cant. Mínima";
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
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese los siguientes parámetros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(28, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cant. Límite";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(33, 219);
            this.txtMaximo.MaxLength = 5;
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 2;
            this.txtMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(54, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(33, 280);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 3;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 114);
            this.label4.TabIndex = 27;
            this.label4.Text = "Si deja los campos vacíos\r\nse filtrará por los siguientes\r\nvalores genéricos:\r\nCa" +
    "nt. Mínima = 1\r\nCant. Máxima = 20\r\nAño = 2020\r\n";
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
            this.lblConsulta.Size = new System.Drawing.Size(615, 191);
            this.lblConsulta.TabIndex = 29;
            this.lblConsulta.Text = resources.GetString("lblConsulta.Text");
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
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MostrarConsulta);
            this.panel1.Controls.Add(this.dgvConsulta);
            this.panel1.Controls.Add(this.lblConsulta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rtxConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(283, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(60, 0, 30, 0);
            this.panel1.Size = new System.Drawing.Size(705, 558);
            this.panel1.TabIndex = 31;
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
            this.MostrarConsulta.TabIndex = 28;
            this.MostrarConsulta.UseVisualStyleBackColor = false;
            this.MostrarConsulta.Click += new System.EventHandler(this.MostrarConsulta_Click);
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
            this.rtxConsulta.TabIndex = 28;
            this.rtxConsulta.Text = resources.GetString("rtxConsulta.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.btnConsulta1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMinimo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTituloFormHijo);
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaximo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(283, 558);
            this.panel2.TabIndex = 32;
            // 
            // frmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(988, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmConsulta1";
            this.Text = "Consulta N°1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private FontAwesome.Sharp.IconButton btnConsulta1;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton MostrarConsulta;
        private System.Windows.Forms.RichTextBox rtxConsulta;
    }
}