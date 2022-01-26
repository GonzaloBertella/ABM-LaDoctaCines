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
    public partial class frmConsulta4 : Form
    {
        public frmConsulta4()
        {
            InitializeComponent();
            rtxConsulta.Visible = false;
            rtxConsulta.BringToFront();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            DataTable dt = new DataTable();

            Consulta4 c4 = new Consulta4();

            if (string.IsNullOrEmpty(txtCodCliente.Text))
                txtCodCliente.Text = "2";
            c4.pCodigo = int.Parse(txtCodCliente.Text);

            dt = c4.RecuperarConsulta();
            dgvConsulta.DataSource = dt;

            //A Continuación está el código para llenar automáticamente el ancho del datagrid
            //Seteamos el modo autosize
            dgvConsulta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvConsulta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvConsulta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //El data grid calcula su anchor y asi podemos llenarlo
            for (int i = 0; i <= dgvConsulta.Columns.Count - 1; i++)
            {
                //Guarda el ancho en el autosize
                int colw = dgvConsulta.Columns[i].Width;
                //Elimina el autosizing
                dgvConsulta.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //Setea el ancho a lo calculado por el autosize
                dgvConsulta.Columns[i].Width = colw;
            }
        }

        //Método para que se pinte el fondo con degradado. se usa junto con el System.Drawing.Drawing2D;
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, Color.FromArgb(39, 26, 34),
            Color.FromArgb(96, 58, 72), 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void MostrarConsulta_Click(object sender, EventArgs e)
        {
            if (rtxConsulta.Visible == false)
                rtxConsulta.Visible = true;
            else
                rtxConsulta.Visible = false;
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
