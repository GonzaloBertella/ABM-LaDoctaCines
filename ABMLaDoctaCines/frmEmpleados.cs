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
using System.Diagnostics;
using System.Threading;

namespace ABMLaDoctaCines
{
    public partial class frmEmpleados : Form
    {
        private Form formHijoActual;
        



        public frmEmpleados()
        {
            InitializeComponent();

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {           
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestTablaColor());
        }

        private void AbrirFormHijo(Form formHijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Add(formHijo);
            pnlEscritorio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, Color.FromArgb(39, 26, 34),
            Color.FromArgb(96, 58, 72), 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmEmpleadosInformes());
        }


        //Abrir calculadora
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Process proc = Process.Start("calc");
                proc.WaitForInputIdle();

                SetParent(proc.MainWindowHandle, this.panel1.Handle);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmConfiEmpleados());
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmGraficoFacturacion());
        }
    }
}
