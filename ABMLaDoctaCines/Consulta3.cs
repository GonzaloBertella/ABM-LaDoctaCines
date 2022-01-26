using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Consulta3
    {
        DatosConexion oBD = new DatosConexion();
        int año1;
        int año2;
        int codigo;

        public int pAño1 { get => año1; set => año1 = value; }
        public int pAño2 { get => año2; set => año2 = value; }
        public int pCodigo { get => codigo; set => codigo = value; }

        public DataTable RecuperarConsulta()
        {
            string consultaSQL = $"exec pa_Tercer_Consulta @año1 = {pAño1},@año2 = {pAño2},@codigo = {pCodigo}";

            return oBD.Consultar(consultaSQL);
        }
    }
}
