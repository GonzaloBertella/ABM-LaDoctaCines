using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing.Drawing2D;

namespace ABMLaDoctaCines
{
    public partial class frmDoctaCines : Form
    {
        //Declaramos variables privadas para almacenar:
        private IconButton botonSeleccionado; // El botón seleccionado
        private Panel botonBordeIzq; // Un panel para aplicar un borde izquierdo al botón
        private Form formHijoActual; // Un campo tipo Form para almecenar el form actual


        public frmDoctaCines()
        {
            InitializeComponent();
            botonBordeIzq = new Panel();
            botonBordeIzq.Size = new Size(7, 60);
            pnlMenu.Controls.Add(botonSeleccionado);

            //Lo siguiente es para eliminar la barra por defecto de la ventana del Form
            this.Text = string.Empty; //Le quitamos el texto al form
            this.ControlBox = false; //Le quitamos la caja de control (barra superior)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Esto es para que al maximizar la ventana no tape la barra de tareas

            this.MinimumSize = new Size(1240, 720);
            this.MaximumSize = new Size(1920, 1080);
        }


        //Creamos este método para reducir el parpadeo en los gráficos del Form (optimización)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
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

        //Guardamos Colorcitos en variables
        private struct ColoresRGB
        {
            //Doradito
            public static Color color1 = Color.FromArgb(202, 140, 58);

            //Color Botón Seleccionado rojito
            public static Color color2 = Color.FromArgb(70, 30, 39);

            //Pasás con el mouse por arriba
            public static Color color3 = Color.FromArgb(39, 26, 34);
        }


        // Creamos un método void para resaltar el botón que se seleccione
        private void ActivarResaltado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarResaltado();
                //Botón Seleccionado
                botonSeleccionado = (IconButton)senderBtn;
                botonSeleccionado.BackColor = ColoresRGB.color2;
                botonSeleccionado.ForeColor = color;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
                botonSeleccionado.IconColor = color;
                botonSeleccionado.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleRight;
                //Botón del borde izq
                botonBordeIzq.BackColor = color;
                botonBordeIzq.Location = new Point(0,botonSeleccionado.Location.Y);
                botonBordeIzq.Visible = true;
                botonBordeIzq.BringToFront();
                //Icono From hijo Actual
                iconoFormHijoAcutal.IconChar = botonSeleccionado.IconChar;
                iconoFormHijoAcutal.IconColor = color;

            }
        }

        private void DesactivarResaltado()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = ColoresRGB.color3;
                botonSeleccionado.ForeColor = Color.Gainsboro;
                botonSeleccionado.TextAlign = ContentAlignment.MiddleLeft;
                botonSeleccionado.IconColor = ColoresRGB.color1;
                botonSeleccionado.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonSeleccionado.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormHijo(Form formHijo)
        {
            if(formHijoActual != null)
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
            lblTituloFormHijo.Text = formHijo.Text;
        }
        private void Reiniciar()
        {
            DesactivarResaltado();
            botonBordeIzq.Visible = false;
            iconoFormHijoAcutal.IconChar = IconChar.Home;
            iconoFormHijoAcutal.IconColor = ColoresRGB.color1;
            lblTituloFormHijo.Text="Inicio";
        }

        #region Botones del Menú

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmDashboard());
            lblHora.Visible=false;
            lblFecha.Visible = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new Consultas());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmRecibos());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }
        private void btnFunciones_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmFunciones());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmPeliculas());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmClientes());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmEmpleados());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }
        private void btnPromociones_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmPromociones());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            ActivarResaltado(sender, ColoresRGB.color1);
            AbrirFormHijo(new frmOpciones());
            lblHora.Visible = false;
            lblFecha.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(formHijoActual != null)
            formHijoActual.Close();
            Reiniciar();
            lblHora.Visible = true;
            lblFecha.Visible = true;
        }
        #endregion

        #region Botones de la ventana
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Arrastrar Form
        // Para eso importamos la libreria using System.Runtime.InteropServices;
        // Esto nos permite utilizar librerias nativas de Windows(como el user32.Dll)
        // que nos permiten mover el Form a través del evento del MouseDown
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
