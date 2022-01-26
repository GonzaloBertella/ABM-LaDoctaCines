using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ABMLaDoctaCines
{
    public partial class frmGraficoFacturacion : Form
    {
        public frmGraficoFacturacion()
        {
            InitializeComponent();
        }

        private void frmGraficoFacturacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LaDoctaCinesDataSetTODAS.pa_Grafico_Ventas_Anuales' table. You can move, or remove it, as needed.
            this.pa_Grafico_Ventas_AnualesTableAdapter.Fill(this.LaDoctaCinesDataSetTODAS.pa_Grafico_Ventas_Anuales);

            this.reportViewer1.RefreshReport();
        }

    }
}
