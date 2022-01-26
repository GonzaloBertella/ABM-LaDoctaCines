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
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace ABMLaDoctaCines
{
    public partial class frmConfiEmpleados : Form
    {
        DatosConexion oBD = new DatosConexion();

        List<Empleados> lE = new List<Empleados>();

        enum accion
        {
            nuevo,
            editado
        }
        accion miAccion;

        public frmConfiEmpleados()
        {
            InitializeComponent();

            miAccion = accion.editado;

        }

        private void frmConfiEmpleados_Load(object sender, EventArgs e)
        {
            CargarLista("Empleados");
            CargarCombo(cboTipDoc, "Tipos_Doc");
            CargarCombo(cboRol, "Rol_Empleados");
            CargarCombo(cboBarrios, "Barrios");

            txtCodigo.Enabled = false;

            lstEmpleados.SelectedIndex = 0;


            Habilitar(false);
        }

        private void CargarLista(string nombreTabla)
        {
            lE.Clear();

            oBD.LeerTabla(nombreTabla);
            
            while (oBD.pDr.Read())
            {
                Empleados e = new Empleados();

                if (!oBD.pDr.IsDBNull(0))
                    e.pCodigo = oBD.pDr.GetInt32(0);
                if (!oBD.pDr.IsDBNull(1))
                    e.pNombre = oBD.pDr.GetString(1);
                if (!oBD.pDr.IsDBNull(2))
                    e.pApellido = oBD.pDr.GetString(2);
                if (!oBD.pDr.IsDBNull(3))
                    e.pTipoDoc = oBD.pDr.GetInt32(3);
                if (!oBD.pDr.IsDBNull(4))
                    e.pDocumento = oBD.pDr.GetString(4);
                if (!oBD.pDr.IsDBNull(5))
                    e.pTelefono = oBD.pDr.GetString(5);
                if (!oBD.pDr.IsDBNull(6))
                    e.pDireccion = oBD.pDr.GetString(6);
                if (!oBD.pDr.IsDBNull(7))
                    e.pRolEmpleado = oBD.pDr.GetInt32(7);
                if (!oBD.pDr.IsDBNull(8))
                    e.pBarrio = oBD.pDr.GetInt32(8);
                if (!oBD.pDr.IsDBNull(9))
                    e.pSexo = oBD.pDr.GetInt32(9);
                if (!oBD.pDr.IsDBNull(10))
                    e.pLegajo = oBD.pDr.GetInt32(10);

                lE.Add(e);
            }

            oBD.pDr.Close();
            oBD.Desconectar();

            lstEmpleados.Items.Clear();

            for (int i = 0; i < lE.Count; i++)
            {
                lstEmpleados.Items.Add(lE[i].MostrarEmpleado());
            }

            lstEmpleados.SelectedIndex = 0;
        }


        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = oBD.ConsultarTabla(nombreTabla);

            combo.DataSource = dt;
            // el Id o Pk
            combo.ValueMember = dt.Columns[0].ColumnName;
            // la columna que queremos mostrar
            combo.DisplayMember = dt.Columns[1].ColumnName;


            if (combo == cboBarrios)
            {               
                // la descripción del barrio esta en la posición 2
                combo.DisplayMember = dt.Columns[2].ColumnName;
            }

        }

        #region Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            miAccion = accion.nuevo;
            LimpiarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            miAccion = accion.editado;
            txtLegajo.Enabled = false;
            txtDocumento.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            miAccion = accion.editado;
        }
        private void btnReferscar_Click(object sender, EventArgs e)
        {
            CargarLista("Empleados");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            {
                string consultaSql = "";

                if (ValidarDatos())
                {

                    Empleados emp = new Empleados();

                    emp.pNombre = txtNombre.Text;
                    emp.pApellido = txtApellido.Text;
                    emp.pTipoDoc = (int)cboTipDoc.SelectedValue;
                    emp.pDocumento = txtDocumento.Text;
                    emp.pTelefono = txtTelefono.Text;
                    emp.pDireccion = txtDireccion.Text;
                    emp.pRolEmpleado = (int)cboRol.SelectedValue;
                    emp.pBarrio = (int)cboBarrios.SelectedValue;

                    if (rdoVaron.Checked)
                    {
                        emp.pSexo = 1;
                    }
                    if (rdoMujer.Checked)
                    {
                        emp.pSexo = 2;
                    }
                    if (rdoOtro.Checked)
                    {
                        emp.pSexo = 3;
                    }
                    emp.pLegajo = int.Parse(txtLegajo.Text);


                    if (miAccion == accion.nuevo)
                    {
                        if (!Existe(emp.pLegajo))
                        {
                            if (!Existe(emp.pDocumento))
                            {
                                consultaSql = "insert into Empleados (nom_empleado,ape_empleado,id_tipo_doc,documento," +
                                              "telefono,direccion,id_rol_empleado,id_barrio,id_sexo,legajo) " +
                                             $" values ('{emp.pNombre}','{emp.pApellido}',{emp.pTipoDoc},'{emp.pDocumento}','{emp.pTelefono}'," +
                                             $"'{emp.pDireccion}',{emp.pRolEmpleado},{emp.pBarrio},{emp.pSexo},{emp.pLegajo})";

                                oBD.Actualizar(consultaSql);

                                Habilitar(false);
                                CargarLista("Empleados");
                                miAccion = accion.editado; // lo reseteamos
                            }
                            else
                                MessageBox.Show("El documento ingresado ya le pertenece a otro Empleado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("El legajo ingresado ya le pertenece a otro Empleado", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else
                    {
                        emp.pCodigo = int.Parse(txtCodigo.Text);

                        consultaSql = $"update Empleados set " +
                                      $"nom_empleado = '{emp.pNombre}'," +
                                      $"ape_empleado = '{emp.pApellido}'," +
                                      $"id_tipo_doc = {emp.pTipoDoc}," +
                                      $"documento = '{emp.pDocumento}'," +
                                      $"telefono = '{emp.pTelefono}'," +
                                      $"direccion = '{emp.pDireccion}'," +
                                      $"id_rol_empleado = {emp.pRolEmpleado}," +
                                      $"id_barrio = {emp.pBarrio}," +
                                      $"id_sexo = {emp.pSexo}," +
                                      $"legajo = {emp.pLegajo}" +
                                      $" Where id_empleado = {emp.pCodigo}";

                        oBD.Actualizar(consultaSql);

                        Habilitar(false);
                        CargarLista("Empleados");
                        miAccion = accion.editado; // lo reseteamos
                    }
                } 
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            {
                DialogResult resulDial;

                resulDial = MessageBox.Show("Si quiere eliminar un empleado seleccione 'Si'", "Eliminando",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resulDial == DialogResult.Yes)
                {
                    string consultaSQL = "DELETE FROM empleados WHERE id_empleado= " + lE[lstEmpleados.SelectedIndex].pCodigo;

                    oBD.Actualizar(consultaSQL);
                    lstEmpleados.Items.Clear();
                    CargarLista("empleados");
                }
            }
        }
        #endregion

        #region Cargar Campos
        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedIndex >= 0)
                CargarCampos(lstEmpleados.SelectedIndex);
        }
        private void CargarCampos(int posicion)
        {
            txtCodigo.Text = lE[posicion].pCodigo.ToString();
            txtLegajo.Text = lE[posicion].pLegajo.ToString();
            txtNombre.Text = lE[posicion].pNombre;
            txtApellido.Text = lE[posicion].pApellido;
            cboRol.SelectedValue = lE[posicion].pRolEmpleado.ToString();
            cboTipDoc.SelectedValue = lE[posicion].pTipoDoc.ToString();
            txtDocumento.Text = lE[posicion].pDocumento;
            txtDireccion.Text = lE[posicion].pDireccion;
            if (lE[posicion].pSexo == 1)
                rdoVaron.Checked = true;
            if (lE[posicion].pSexo == 2)
                rdoMujer.Checked = true;
            if (lE[posicion].pSexo == 3)
                rdoOtro.Checked = true;
            cboBarrios.SelectedValue = lE[posicion].pBarrio.ToString();
            txtTelefono.Text = lE[posicion].pTelefono;

        }
        #endregion

        #region Validar, Limpiar y Habilitar
        private bool ValidarDatos()
        {

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el nombre por favor");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el apellido por favor");
                txtApellido.Focus();
                return false;
            }
            if (cboTipDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de documento por favor");
                cboTipDoc.Focus();
                return false;
            }
            if (txtDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el documento por favor");
                txtDocumento.Focus();
                return false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el teléfono por favor");
                txtTelefono.Focus();
                return false;
            }
            if (txtDireccion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la dirección por favor");
                txtDireccion.Focus();
                return false;
            }
            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el rol del empleado por favor");
                cboRol.Focus();
                return false;
            }
            if (cboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el barrio por favor");
                cboBarrios.Focus();
                return false;
            }
            if (txtLegajo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el legajo por favor");
                txtLegajo.Focus();
                return false;
            }

            return true;

        }

        private void LimpiarDatos()
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is TextBox)
                    c.Text = "";
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
            }
        }


        private void Habilitar(bool x)
        {
            txtLegajo.Enabled = x;
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            cboRol.Enabled = x;
            cboTipDoc.Enabled = x;
            txtDocumento.Enabled = x;
            txtDireccion.Enabled = x;
            rdoVaron.Enabled = x;
            rdoMujer.Enabled = x;
            rdoOtro.Enabled = x;
            cboBarrios.Enabled = x;
            txtTelefono.Enabled = x;

            btnCancelar.Enabled = x;
            btnGrabar.Enabled = x;

            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
        }
        #endregion

        private bool Existe(int leg)
        {
            bool x = false;
            for (int i = 0; i < lE.Count; i++)
            {
                if (lE[i].pLegajo == leg) // == emp.pLegajo
                    x = true;
            }
            return x;
        }

        private bool Existe(string doc)
        {
            bool x = false;
            for (int i = 0; i < lE.Count; i++)
            {
                if (lE[i].pDocumento == doc) // == emp.pDocumento
                    x = true;
            }
            return x;
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

        // Cambiar el color de fondo del item seleccionado
        private void lstEmpleados_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(70, 30, 39));//Elegir color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(lstEmpleados.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}
