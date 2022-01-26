using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Consulta2
    {
        DatosConexion oBD = new DatosConexion();
        string letraTitulo;
        int año;

        public string pLetraTitulo { get => letraTitulo; set => letraTitulo = value; }
        public int pAño { get => año; set => año = value; }


        public DataTable RecuperarConsulta()
        {
            string consultaSQL = $"exec pa_Segunda_Consulta @año={pAño}, @letra='{pLetraTitulo}' ";

            return oBD.Consultar(consultaSQL);
        }
    }
}
