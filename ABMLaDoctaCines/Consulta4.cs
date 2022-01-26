using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Consulta4
    {
        DatosConexion oBD = new DatosConexion();

        int codigo;

        public int pCodigo { get => codigo; set => codigo = value; }

        public DataTable RecuperarConsulta()
        {
            string consultaSQL = $"exec pa_Cuarta_Consulta @codigo={pCodigo}";

            return oBD.Consultar(consultaSQL);
        }
    }
}
