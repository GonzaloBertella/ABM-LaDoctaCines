using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Consulta1
    {
        DatosConexion oBD = new DatosConexion();
        int cant1;
        int cant2;
        int año;

        public int pCant1 { get => cant1; set => cant1 = value; }
        public int pCant2 { get => cant2; set => cant2 = value; }
        public int pAño { get => año; set => año = value; }

        public DataTable RecuperarConsulta1()
        {
            string consultaSQL = $"exec pa_Primer_Consulta @recibo1={pCant1}, @recibo2={pCant2}, @año={pAño}";

            return oBD.Consultar(consultaSQL);
        }
    }
}
