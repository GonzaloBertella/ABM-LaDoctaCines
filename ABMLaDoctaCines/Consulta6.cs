using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Consulta6
    {
        DatosConexion oBD = new DatosConexion();
        decimal importe;

        public decimal pImporte { get => importe; set => importe = value; }

        public DataTable RecuperarConsulta()
        {
            string consultaSQL = $"exec pa_Sexta_Consulta @importe = {pImporte}";

            return oBD.Consultar(consultaSQL);
        }
    }
}
