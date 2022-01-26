namespace ABMLaDoctaCines
{
    partial class frmEmpleadosInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosInformes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaDoctaCinesDataSetTODAS = new ABMLaDoctaCines.LaDoctaCinesDataSetTODAS();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new FontAwesome.Sharp.IconButton();
            this.cboBarrios = new ABMLaDoctaCines.ComboPersonalizado();
            this.cboRol = new ABMLaDoctaCines.ComboPersonalizado();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoOtro = new System.Windows.Forms.RadioButton();
            this.rdoMujer = new System.Windows.Forms.RadioButton();
            this.rdoVaron = new System.Windows.Forms.RadioButton();
            this.rdoFiltroBarrio = new System.Windows.Forms.RadioButton();
            this.rdoFiltroSexo = new System.Windows.Forms.RadioButton();
            this.rdoFiltroRol = new System.Windows.Forms.RadioButton();
            this.rdoFiltroNombre = new System.Windows.Forms.RadioButton();
            this.rdoFiltroLegajo = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.btnImprimirTodo = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOrdenar = new FontAwesome.Sharp.IconButton();
            this.btnQuitar = new FontAwesome.Sharp.IconButton();
            this.rdoBarrio = new System.Windows.Forms.RadioButton();
            this.rdoSexo = new System.Windows.Forms.RadioButton();
            this.rdoRol = new System.Windows.Forms.RadioButton();
            this.rdoNombre = new System.Windows.Forms.RadioButton();
            this.rdoLegajo = new System.Windows.Forms.RadioButton();
            this.EmpleadosTableAdapter = new ABMLaDoctaCines.LaDoctaCinesDataSetTODASTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpleadosBindingSource
            // 
            this.EmpleadosBindingSource.DataMember = "Empleados";
            this.EmpleadosBindingSource.DataSource = this.LaDoctaCinesDataSetTODAS;
            // 
            // LaDoctaCinesDataSetTODAS
            // 
            this.LaDoctaCinesDataSetTODAS.DataSetName = "LaDoctaCinesDataSetTODAS";
            this.LaDoctaCinesDataSetTODAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormHijo.Location = new System.Drawing.Point(103, 6);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(306, 33);
            this.lblTituloFormHijo.TabIndex = 6;
            this.lblTituloFormHijo.Text = "Listado de Empleados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTituloFormHijo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 58);
            this.panel1.TabIndex = 9;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMLaDoctaCines.rptEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(283, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(689, 494);
            this.reportViewer1.TabIndex = 10;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnReiniciar);
            this.panel2.Controls.Add(this.cboBarrios);
            this.panel2.Controls.Add(this.cboRol);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.rdoFiltroBarrio);
            this.panel2.Controls.Add(this.rdoFiltroSexo);
            this.panel2.Controls.Add(this.rdoFiltroRol);
            this.panel2.Controls.Add(this.rdoFiltroNombre);
            this.panel2.Controls.Add(this.rdoFiltroLegajo);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLegajo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.btnImprimirTodo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 552);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 100);
            this.panel5.TabIndex = 138;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnReiniciar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReiniciar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnReiniciar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(140)))), ((int)(((byte)(58)))));
            this.btnReiniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReiniciar.IconSize = 32;
            this.btnReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.Location = new System.Drawing.Point(0, 374);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReiniciar.Rotation = 0D;
            this.btnReiniciar.Size = new System.Drawing.Size(283, 58);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Reiniciar Filtro";
            this.btnReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cboBarrios
            // 
            this.cboBarrios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.cboBarrios.BorderColor = System.Drawing.Color.DimGray;
            this.cboBarrios.BorderDrawMode = ABMLaDoctaCines.ComboPersonalizado.ControlBorderDrawMode.Internal;
            this.cboBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBarrios.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(119, 347);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(122, 21);
            this.cboBarrios.TabIndex = 137;
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.cboRol.BorderColor = System.Drawing.Color.DimGray;
            this.cboRol.BorderDrawMode = ABMLaDoctaCines.ComboPersonalizado.ControlBorderDrawMode.Internal;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRol.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(119, 243);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(122, 21);
            this.cboRol.TabIndex = 136;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoOtro);
            this.panel4.Controls.Add(this.rdoMujer);
            this.panel4.Controls.Add(this.rdoVaron);
            this.panel4.Location = new System.Drawing.Point(119, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 62);
            this.panel4.TabIndex = 134;
            // 
            // rdoOtro
            // 
            this.rdoOtro.AutoSize = true;
            this.rdoOtro.BackColor = System.Drawing.Color.Transparent;
            this.rdoOtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoOtro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOtro.ForeColor = System.Drawing.Color.White;
            this.rdoOtro.Location = new System.Drawing.Point(0, 42);
            this.rdoOtro.Name = "rdoOtro";
            this.rdoOtro.Size = new System.Drawing.Size(82, 21);
            this.rdoOtro.TabIndex = 7;
            this.rdoOtro.TabStop = true;
            this.rdoOtro.Text = "Otro";
            this.rdoOtro.UseVisualStyleBackColor = false;
            // 
            // rdoMujer
            // 
            this.rdoMujer.AutoSize = true;
            this.rdoMujer.BackColor = System.Drawing.Color.Transparent;
            this.rdoMujer.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoMujer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMujer.ForeColor = System.Drawing.Color.White;
            this.rdoMujer.Location = new System.Drawing.Point(0, 21);
            this.rdoMujer.Name = "rdoMujer";
            this.rdoMujer.Size = new System.Drawing.Size(82, 21);
            this.rdoMujer.TabIndex = 6;
            this.rdoMujer.TabStop = true;
            this.rdoMujer.Text = "Mujer";
            this.rdoMujer.UseVisualStyleBackColor = false;
            // 
            // rdoVaron
            // 
            this.rdoVaron.AutoSize = true;
            this.rdoVaron.BackColor = System.Drawing.Color.Transparent;
            this.rdoVaron.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoVaron.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVaron.ForeColor = System.Drawing.Color.White;
            this.rdoVaron.Location = new System.Drawing.Point(0, 0);
            this.rdoVaron.Name = "rdoVaron";
            this.rdoVaron.Size = new System.Drawing.Size(82, 21);
            this.rdoVaron.TabIndex = 5;
            this.rdoVaron.TabStop = true;
            this.rdoVaron.Text = "Varón";
            this.rdoVaron.UseVisualStyleBackColor = false;
            // 
            // rdoFiltroBarrio
            // 
            this.rdoFiltroBarrio.AutoSize = true;
            this.rdoFiltroBarrio.BackColor = System.Drawing.Color.Transparent;
            this.rdoFiltroBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFiltroBarrio.ForeColor = System.Drawing.Color.White;
            this.rdoFiltroBarrio.Location = new System.Drawing.Point(19, 347);
            this.rdoFiltroBarrio.Name = "rdoFiltroBarrio";
            this.rdoFiltroBarrio.Size = new System.Drawing.Size(14, 13);
            this.rdoFiltroBarrio.TabIndex = 20;
            this.rdoFiltroBarrio.TabStop = true;
            this.rdoFiltroBarrio.UseVisualStyleBackColor = false;
            this.rdoFiltroBarrio.CheckedChanged += new System.EventHandler(this.rdoFiltroBarrio_CheckedChanged);
            // 
            // rdoFiltroSexo
            // 
            this.rdoFiltroSexo.AutoSize = true;
            this.rdoFiltroSexo.BackColor = System.Drawing.Color.Transparent;
            this.rdoFiltroSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFiltroSexo.ForeColor = System.Drawing.Color.White;
            this.rdoFiltroSexo.Location = new System.Drawing.Point(19, 275);
            this.rdoFiltroSexo.Name = "rdoFiltroSexo";
            this.rdoFiltroSexo.Size = new System.Drawing.Size(14, 13);
            this.rdoFiltroSexo.TabIndex = 19;
            this.rdoFiltroSexo.TabStop = true;
            this.rdoFiltroSexo.UseVisualStyleBackColor = false;
            this.rdoFiltroSexo.CheckedChanged += new System.EventHandler(this.rdoFiltroSexo_CheckedChanged);
            // 
            // rdoFiltroRol
            // 
            this.rdoFiltroRol.AutoSize = true;
            this.rdoFiltroRol.BackColor = System.Drawing.Color.Transparent;
            this.rdoFiltroRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFiltroRol.ForeColor = System.Drawing.Color.White;
            this.rdoFiltroRol.Location = new System.Drawing.Point(19, 243);
            this.rdoFiltroRol.Name = "rdoFiltroRol";
            this.rdoFiltroRol.Size = new System.Drawing.Size(14, 13);
            this.rdoFiltroRol.TabIndex = 18;
            this.rdoFiltroRol.TabStop = true;
            this.rdoFiltroRol.UseVisualStyleBackColor = false;
            this.rdoFiltroRol.CheckedChanged += new System.EventHandler(this.rdoFiltroRol_CheckedChanged);
            // 
            // rdoFiltroNombre
            // 
            this.rdoFiltroNombre.AutoSize = true;
            this.rdoFiltroNombre.BackColor = System.Drawing.Color.Transparent;
            this.rdoFiltroNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFiltroNombre.ForeColor = System.Drawing.Color.White;
            this.rdoFiltroNombre.Location = new System.Drawing.Point(19, 217);
            this.rdoFiltroNombre.Name = "rdoFiltroNombre";
            this.rdoFiltroNombre.Size = new System.Drawing.Size(14, 13);
            this.rdoFiltroNombre.TabIndex = 17;
            this.rdoFiltroNombre.TabStop = true;
            this.rdoFiltroNombre.UseVisualStyleBackColor = false;
            this.rdoFiltroNombre.CheckedChanged += new System.EventHandler(this.rdoFiltroNombre_CheckedChanged);
            // 
            // rdoFiltroLegajo
            // 
            this.rdoFiltroLegajo.AutoSize = true;
            this.rdoFiltroLegajo.BackColor = System.Drawing.Color.Transparent;
            this.rdoFiltroLegajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFiltroLegajo.ForeColor = System.Drawing.Color.White;
            this.rdoFiltroLegajo.Location = new System.Drawing.Point(19, 191);
            this.rdoFiltroLegajo.Name = "rdoFiltroLegajo";
            this.rdoFiltroLegajo.Size = new System.Drawing.Size(14, 13);
            this.rdoFiltroLegajo.TabIndex = 16;
            this.rdoFiltroLegajo.TabStop = true;
            this.rdoFiltroLegajo.UseVisualStyleBackColor = false;
            this.rdoFiltroLegajo.CheckedChanged += new System.EventHandler(this.rdoFiltroLegajo_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNombre.Location = new System.Drawing.Point(119, 214);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 122;
            this.label6.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(75, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 127;
            this.label11.Text = "Rol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(66, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 126;
            this.label10.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 119;
            this.label4.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLegajo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLegajo.Location = new System.Drawing.Point(119, 188);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(122, 20);
            this.txtLegajo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Barrio";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(140)))), ((int)(((byte)(58)))));
            this.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltrar.IconSize = 32;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(0, 122);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFiltrar.Rotation = 0D;
            this.btnFiltrar.Size = new System.Drawing.Size(283, 60);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar Por";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimirTodo.FlatAppearance.BorderSize = 0;
            this.btnImprimirTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnImprimirTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnImprimirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImprimirTodo.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnImprimirTodo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImprimirTodo.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirTodo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(140)))), ((int)(((byte)(58)))));
            this.btnImprimirTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirTodo.IconSize = 32;
            this.btnImprimirTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirTodo.Location = new System.Drawing.Point(0, 0);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnImprimirTodo.Rotation = 0D;
            this.btnImprimirTodo.Size = new System.Drawing.Size(283, 58);
            this.btnImprimirTodo.TabIndex = 1;
            this.btnImprimirTodo.Text = "Imprimir Todo";
            this.btnImprimirTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            this.btnImprimirTodo.Click += new System.EventHandler(this.btnImprimirTodo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnOrdenar);
            this.panel3.Controls.Add(this.btnQuitar);
            this.panel3.Controls.Add(this.rdoBarrio);
            this.panel3.Controls.Add(this.rdoSexo);
            this.panel3.Controls.Add(this.rdoRol);
            this.panel3.Controls.Add(this.rdoNombre);
            this.panel3.Controls.Add(this.rdoLegajo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(283, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 58);
            this.panel3.TabIndex = 12;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOrdenar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnOrdenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOrdenar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnOrdenar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrdenar.IconChar = FontAwesome.Sharp.IconChar.SortDown;
            this.btnOrdenar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(140)))), ((int)(((byte)(58)))));
            this.btnOrdenar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdenar.IconSize = 32;
            this.btnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenar.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrdenar.Rotation = 0D;
            this.btnOrdenar.Size = new System.Drawing.Size(151, 58);
            this.btnOrdenar.TabIndex = 17;
            this.btnOrdenar.Text = "Ordenar Por";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnQuitar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuitar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnQuitar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(140)))), ((int)(((byte)(58)))));
            this.btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitar.IconSize = 32;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(511, 0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQuitar.Rotation = 0D;
            this.btnQuitar.Size = new System.Drawing.Size(195, 58);
            this.btnQuitar.TabIndex = 16;
            this.btnQuitar.Text = "Quitar Selección";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // rdoBarrio
            // 
            this.rdoBarrio.AutoSize = true;
            this.rdoBarrio.BackColor = System.Drawing.Color.Transparent;
            this.rdoBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBarrio.ForeColor = System.Drawing.Color.White;
            this.rdoBarrio.Location = new System.Drawing.Point(443, 17);
            this.rdoBarrio.Name = "rdoBarrio";
            this.rdoBarrio.Size = new System.Drawing.Size(62, 21);
            this.rdoBarrio.TabIndex = 14;
            this.rdoBarrio.TabStop = true;
            this.rdoBarrio.Text = "Barrio";
            this.rdoBarrio.UseVisualStyleBackColor = false;
            // 
            // rdoSexo
            // 
            this.rdoSexo.AutoSize = true;
            this.rdoSexo.BackColor = System.Drawing.Color.Transparent;
            this.rdoSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSexo.ForeColor = System.Drawing.Color.White;
            this.rdoSexo.Location = new System.Drawing.Point(379, 17);
            this.rdoSexo.Name = "rdoSexo";
            this.rdoSexo.Size = new System.Drawing.Size(55, 21);
            this.rdoSexo.TabIndex = 13;
            this.rdoSexo.TabStop = true;
            this.rdoSexo.Text = "Sexo";
            this.rdoSexo.UseVisualStyleBackColor = false;
            // 
            // rdoRol
            // 
            this.rdoRol.AutoSize = true;
            this.rdoRol.BackColor = System.Drawing.Color.Transparent;
            this.rdoRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRol.ForeColor = System.Drawing.Color.White;
            this.rdoRol.Location = new System.Drawing.Point(236, 17);
            this.rdoRol.Name = "rdoRol";
            this.rdoRol.Size = new System.Drawing.Size(46, 21);
            this.rdoRol.TabIndex = 11;
            this.rdoRol.TabStop = true;
            this.rdoRol.Text = "Rol";
            this.rdoRol.UseVisualStyleBackColor = false;
            // 
            // rdoNombre
            // 
            this.rdoNombre.AutoSize = true;
            this.rdoNombre.BackColor = System.Drawing.Color.Transparent;
            this.rdoNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNombre.ForeColor = System.Drawing.Color.White;
            this.rdoNombre.Location = new System.Drawing.Point(291, 17);
            this.rdoNombre.Name = "rdoNombre";
            this.rdoNombre.Size = new System.Drawing.Size(79, 21);
            this.rdoNombre.TabIndex = 12;
            this.rdoNombre.TabStop = true;
            this.rdoNombre.Text = "Nombre";
            this.rdoNombre.UseVisualStyleBackColor = false;
            // 
            // rdoLegajo
            // 
            this.rdoLegajo.AutoSize = true;
            this.rdoLegajo.BackColor = System.Drawing.Color.Transparent;
            this.rdoLegajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLegajo.ForeColor = System.Drawing.Color.White;
            this.rdoLegajo.Location = new System.Drawing.Point(157, 17);
            this.rdoLegajo.Name = "rdoLegajo";
            this.rdoLegajo.Size = new System.Drawing.Size(70, 21);
            this.rdoLegajo.TabIndex = 10;
            this.rdoLegajo.TabStop = true;
            this.rdoLegajo.Text = "Legajo";
            this.rdoLegajo.UseVisualStyleBackColor = false;
            // 
            // EmpleadosTableAdapter
            // 
            this.EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmpleadosInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(972, 610);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEmpleadosInformes";
            this.Text = "frmEmpleadosInformes";
            this.Load += new System.EventHandler(this.frmEmpleadosInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaDoctaCinesDataSetTODAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpleadosBindingSource;
        private LaDoctaCinesDataSetTODAS LaDoctaCinesDataSetTODAS;
        private LaDoctaCinesDataSetTODASTableAdapters.EmpleadosTableAdapter EmpleadosTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnImprimirTodo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoOtro;
        private System.Windows.Forms.RadioButton rdoMujer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.RadioButton rdoVaron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoNombre;
        private System.Windows.Forms.RadioButton rdoLegajo;
        private System.Windows.Forms.RadioButton rdoBarrio;
        private System.Windows.Forms.RadioButton rdoSexo;
        private System.Windows.Forms.RadioButton rdoRol;
        private System.Windows.Forms.RadioButton rdoFiltroBarrio;
        private System.Windows.Forms.RadioButton rdoFiltroSexo;
        private System.Windows.Forms.RadioButton rdoFiltroRol;
        private System.Windows.Forms.RadioButton rdoFiltroNombre;
        private System.Windows.Forms.RadioButton rdoFiltroLegajo;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnReiniciar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComboPersonalizado cboBarrios;
        private ComboPersonalizado cboRol;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private FontAwesome.Sharp.IconButton btnOrdenar;
    }
}