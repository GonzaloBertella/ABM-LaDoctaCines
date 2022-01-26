using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ABMLaDoctaCines
{
    public partial class frmConsulta1 : Form
    {
        public frmConsulta1()
        {
            InitializeComponent();
            rtxConsulta.Visible = false;
            rtxConsulta.BringToFront();
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            DataTable dt = new DataTable();

            Consulta1 c1 = new Consulta1();

            if (string.IsNullOrEmpty(txtMinimo.Text))
                txtMinimo.Text = "1";
            c1.pCant1 = int.Parse(txtMinimo.Text);

            if (string.IsNullOrEmpty(txtMaximo.Text))
                txtMaximo.Text = "20";
            c1.pCant2 = int.Parse(txtMaximo.Text);

            if (string.IsNullOrEmpty(txtAño.Text))
                txtAño.Text = "2020";
            c1.pAño = int.Parse(txtAño.Text);



            dt = c1.RecuperarConsulta1();
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

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
