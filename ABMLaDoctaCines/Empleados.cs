using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABMLaDoctaCines
{
    class Empleados
    {

        DatosConexion oBD = new DatosConexion();


        int codigo, tipoDoc, rolEmpleado, barrio, sexo, legajo;
        string nombre, apellido, documento, telefono, direccion;

        public int pCodigo { get => codigo; set => codigo = value; }
        public int pTipoDoc { get => tipoDoc; set => tipoDoc = value; }
        public int pRolEmpleado { get => rolEmpleado; set => rolEmpleado = value; }
        public int pBarrio { get => barrio; set => barrio = value; }
        public int pSexo { get => sexo; set => sexo = value; }
        public int pLegajo { get => legajo; set => legajo = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pApellido { get => apellido; set => apellido = value; }
        public string pDocumento { get => documento; set => documento = value; }
        public string pTelefono { get => telefono; set => telefono = value; }
        public string pDireccion { get => direccion; set => direccion = value; }


        public string MostrarEmpleado()
        {
            return $"{legajo} - {nombre}, {apellido}";
        } 

        //public DataSet dsEmpleado()
        //{
        //    DataSet ds = new DataSet();

        //    ds.

        //    return 
        //}


        //public DataTable RecuperarEmpleado()
        //{
        //    string consultaSql = "select * from Empleados";

        //    oBD.ConsultarTabla("");
        //}

    }
}
