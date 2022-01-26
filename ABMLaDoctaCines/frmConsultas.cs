using FontAwesome.Sharp;
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
    public partial class Consultas : Form
    {
        private IconButton botonSeleccionado; // El botón seleccionado
        private Panel botonBordeIzq; // Un panel para aplicar un borde izquierdo al botón
        private Form formHijoActual; // Un campo tipo Form para almecenar el form actual

        public Consultas()
        {
            InitializeComponent();
            botonBordeIzq = new Panel();
            botonBordeIzq.Size = new Size(7, 50);
            //pnlMenu.Controls.Add(botonSeleccionado);

            iconoConsultaActual.Visible = false;
            lblTituloFormHijo.Visible = false;

            //SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true); //Activamos el doble buffer para reducir el parpadeo en los gráficos del Form (optimización)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Esto es para que al maximizar la ventana no tape la barra de tareas
        }

        private void ActivarResaltado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                iconoConsultaActual.Visible = true;
                lblTituloFormHijo.Visible = true;
                DesactivarResaltado();
                //Botón Seleccionado
                botonSeleccionado = (IconButton)senderBtn;
                botonSeleccionado.BackColor = Color.FromArgb(37, 36, 81);
                botonSeleccionado.ForeColor = color;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
                botonSeleccionado.IconColor = color;
                botonSeleccionado.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleRight;
                //Botón del borde izq
                botonBordeIzq.BackColor = color;
                botonBordeIzq.Location = new Point(0, botonSeleccionado.Location.Y);
                botonBordeIzq.Visible = true;
                botonBordeIzq.BringToFront();
                ////Icono From hijo Actual
                iconoConsultaActual.IconChar = IconChar.Th;
                iconoConsultaActual.IconColor = ColoresRGB.color1;

                
            }
        }

        //Guardamos Colorcitos en variables
        private struct ColoresRGB
        {
            public static Color color1 = Color.FromArgb(202, 140, 58);

            //Color Botón Seleccionado
            public static Color color2 = Color.FromArgb(70, 30, 39);

            public static Color color3 = Color.FromArgb(39, 26, 34);
        }


        private void DesactivarResaltado()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = Color.FromArgb(34, 33, 74);
                botonSeleccionado.ForeColor = Color.Gainsboro;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleLeft;
                botonSeleccionado.IconColor = Color.Gainsboro;
                botonSeleccionado.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

#region Botones
        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color2);
            AbrirFormHijo(new frmConsulta1());
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color2);
            AbrirFormHijo(new frmConsulta2());

        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color2);
            AbrirFormHijo(new frmConsulta3());
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color2);
            AbrirFormHijo(new frmConsulta4());

        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color2);
            AbrirFormHijo(new frmConsulta5());
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color2);
            AbrirFormHijo(new frmConsulta6());
        }
        #endregion

        private void AbrirFormHijo(Form formHijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            lblTituloFormHijo.BackColor = Color.FromArgb(59, 37, 48);
            iconoConsultaActual.BackColor = Color.FromArgb(59, 37, 48);
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Add(formHijo);
            pnlEscritorio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            lblTituloFormHijo.Text = formHijo.Text;
            

        }

        //Método para que se pinte el fondo con degradado. Se usa junto con el System.Drawing.Drawing2D;
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
