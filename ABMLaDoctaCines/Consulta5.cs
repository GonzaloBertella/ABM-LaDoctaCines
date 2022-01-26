using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Consulta5
    {
        DatosConexion oBD = new DatosConexion();
        DateTime fecha1;
        DateTime fecha2;

        public DateTime pFecha1 { get => fecha1; set => fecha1 = value; }
        public DateTime pFecha2 { get => fecha2; set => fecha2 = value; }

        public DataTable RecuperarConsulta()
        {
            string consultaSQL = $"exec pa_Quinta_Consulta @fecha1 = '{pFecha1}', @fecha2 ='{pFecha2}'";

            return oBD.Consultar(consultaSQL);
        }
    }
}
