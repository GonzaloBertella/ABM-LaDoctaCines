using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ABMLaDoctaCines
{
    public partial class frmEmpleadosInformes : Form
    {
        DatosConexion oBD = new DatosConexion();

        string strConsulta;
        string strOrder;
        string strSQL;


        public frmEmpleadosInformes()
        {
            InitializeComponent();

            strConsulta = " select * from Empleados JOIN " +
                " Tipos_Doc ON Empleados.id_tipo_doc = Tipos_Doc.id_tipo_doc JOIN " +
                " Rol_Empleados ON Empleados.id_rol_empleado = Rol_Empleados.id_rol_empleado JOIN " +
                " Sexos ON Empleados.id_sexo = Sexos.id_sexo JOIN " +
                " Barrios ON Empleados.id_barrio = Barrios.id_barrio ";

            strOrder = " asc ";
        }

        private void frmEmpleadosInformes_Load(object sender, EventArgs e)
        {
            // Este código se genera automáticamente al asignarle un Reporte(rpt) al ReportViewer de nuestro form 
            // TODO: This line of code loads data into the 'LaDoctaCinesDataSet1.Empleados' table. You can move, or remove it, as needed.
            this.EmpleadosTableAdapter.Fill(this.LaDoctaCinesDataSetTODAS.Empleados);
            this.reportViewer1.RefreshReport();

            // Cargamos los combos
            CargarCombo(cboRol, "Rol_Empleados");
            CargarCombo(cboBarrios, "Barrios");
            // Los dejamos en blanco
            cboRol.SelectedIndex = -1;
            cboBarrios.SelectedIndex = -1;
            // Deshabilitamos los controles
            txtLegajo.Enabled = false;
            txtNombre.Enabled = false;
            cboRol.Enabled = false;
            cboBarrios.Enabled = false;
            rdoMujer.Enabled = false;
            rdoVaron.Enabled = false;
            rdoOtro.Enabled = false;

        }

        // Se crea el método para Cargar los combos
        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = oBD.ConsultarTabla(nombreTabla);

            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;

            if (combo == cboBarrios)
            {
                combo.DisplayMember = dt.Columns[2].ColumnName;
            }

        }

        // Aca cambiamos el valor de la variable strOrder
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(strOrder == " asc ")
            {
                strOrder = " desc ";
                btnOrdenar.IconChar = FontAwesome.Sharp.IconChar.SortUp;
            }
            else
            {
                strOrder = " asc ";
                btnOrdenar.IconChar = FontAwesome.Sharp.IconChar.SortDown;
            }
        }

        private void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            strSQL = strConsulta;

            // Las posiciones del Order by están basadas en el TablaAdapter de la tabla Empleados
            // del DataSource LaDoctaCinesDataSetTODAS            
            if (rdoLegajo.Checked)
                strSQL += $" Order by Empleados.legajo {strOrder}";
            if (rdoRol.Checked)
                strSQL += $" Order by Rol_Empleados.descripcion {strOrder} ";
            if (rdoNombre.Checked)
                strSQL += $" Order by Empleados.nom_empleado {strOrder}";
            if (rdoSexo.Checked)
                strSQL += $" Order by Sexos.sexo {strOrder} ";
            if (rdoBarrio.Checked)
                strSQL += $" Order by Barrios.barrio {strOrder} ";

            EmpleadosBindingSource.DataSource = oBD.Consultar(strSQL);
            reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            strSQL = strConsulta;

            Empleados emp = new Empleados();

            // Si el Textbox está habilitado y No esta nula o Vacía
            if (txtLegajo.Enabled == true && !string.IsNullOrEmpty(txtLegajo.Text))
            {
                emp.pLegajo = int.Parse(txtLegajo.Text);
                strSQL += $" Where Empleados.legajo = {emp.pLegajo}";
            }

            if (txtNombre.Enabled == true && !string.IsNullOrEmpty(txtNombre.Text))
            {
                emp.pNombre = txtNombre.Text;
                strSQL += $" Where Empleados.nom_empleado like '{emp.pNombre}%'";
            }

            if (cboRol.Enabled == true && cboRol.SelectedIndex != -1)
            {
                emp.pRolEmpleado = (int)cboRol.SelectedValue;
                strSQL += $" Where Empleados.id_rol_empleado = {emp.pRolEmpleado}";
            }

            if (cboBarrios.Enabled == true && cboBarrios.SelectedIndex != -1)
            {
                emp.pBarrio = (int)cboBarrios.SelectedValue;
                strSQL += $" Where Empleados.id_barrio = {emp.pBarrio}";
            }

            if (rdoLegajo.Checked)
                strSQL += " Order by Empleados.legajo asc";
            if (rdoRol.Checked)
                strSQL += " Order by Rol_Empleados.descripcion asc ";
            if (rdoNombre.Checked)
                strSQL += " Order by Empleados.nom_empleado asc";
            if (rdoSexo.Checked)
                strSQL += " Order by Sexos.sexo asc ";
            if (rdoBarrio.Checked)
                strSQL += " Order by Barrios.barrio asc ";


            EmpleadosBindingSource.DataSource = oBD.Consultar(strSQL);
            reportViewer1.RefreshReport();
        }

        #region RadioButtons Changed
        private void rdoFiltroLegajo_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLegajo.Enabled == false)
                txtLegajo.Enabled = true;
            else
                txtLegajo.Enabled = false;
        }

        private void rdoFiltroNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false)
                txtNombre.Enabled = true;
            else
                txtNombre.Enabled = false;
        }

        private void rdoFiltroRol_CheckedChanged(object sender, EventArgs e)
        {
            if (cboRol.Enabled == false)
                cboRol.Enabled = true;
            else
            {
                cboRol.Enabled = false;
                cboRol.SelectedIndex = -1;
            }
        }

        private void rdoFiltroBarrio_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBarrios.Enabled == false)
                cboBarrios.Enabled = true;
            else
            {
                cboBarrios.Enabled = false;
                cboBarrios.SelectedIndex = -1;
            }
        }

        private void rdoFiltroSexo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVaron.Enabled == false && rdoMujer.Enabled == false && rdoOtro.Enabled == false)
                rdoVaron.Enabled = rdoMujer.Enabled = rdoOtro.Enabled = true;
            else
            {
                rdoVaron.Enabled = rdoMujer.Enabled = rdoOtro.Enabled = false;
                rdoVaron.Checked = rdoMujer.Checked = rdoOtro.Checked = false;
            }
        }
        #endregion

        // Cuando se hace click en este boton se quita la seleccion de los RadioButtons del panel
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();

            EmpleadosBindingSource.DataSource = LaDoctaCinesDataSetTODAS.Empleados;

            this.EmpleadosTableAdapter.Fill(this.LaDoctaCinesDataSetTODAS.Empleados);
            this.reportViewer1.RefreshReport();
            
        }

        private void LimpiarDatos()
        {

            foreach (Control c in panel2.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is TextBox)
                    c.Text = "";
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
            }
        }

        //Degradé
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, Color.FromArgb(39, 26, 34),
            Color.FromArgb(96, 58, 72), 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
