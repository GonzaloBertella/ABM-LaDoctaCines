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
    public partial class frmRecibos : Form
    {
        public frmRecibos()
        {
            InitializeComponent();
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



        private void frmRecibos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LaDoctaCinesDataSetTODAS.Detalles_Recibos' table. You can move, or remove it, as needed.
            this.Detalles_RecibosTableAdapter.Fill(this.LaDoctaCinesDataSetTODAS.Detalles_Recibos);

            this.reportViewer1.RefreshReport();
        }
    }
}
