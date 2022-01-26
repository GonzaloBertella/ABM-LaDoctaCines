using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABMLaDoctaCines
{
    class DatosConexion
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dr;
        string cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=LaDoctaCines;Integrated Security=True";

        public SqlDataReader pDr { get => dr; set => dr = value; }
        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }

        public DatosConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            comando = new SqlCommand();
            //this.cadenaConexion = null;
        }

        public DatosConexion(string cadenaConexion)
        {
            this.conexion = new SqlConnection();
            this.comando = new SqlCommand();
            this.cadenaConexion = cadenaConexion;
            this.pDr = null;
        }

        public void Conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            Conectar();
            comando.CommandText = $"select * from {nombreTabla}";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            Desconectar();
            return dt;
        }

        public void LeerTabla(string nombreTabla)
        {
            Conectar();
            comando.CommandText = $"select * from {nombreTabla}";
            dr = comando.ExecuteReader();
        }

        public void Actualizar(string consultaSql)
        {
            Conectar();
            comando.CommandText = consultaSql;
            comando.ExecuteNonQuery();
            Desconectar();
        }

        public DataTable Consultar(string consultaSql)
        {
            DataTable dt = new DataTable();

            Conectar();
            comando.CommandText = consultaSql;


            dt.Load(comando.ExecuteReader());

            Desconectar();
            return dt;
        }


        //public void ActualizarConParametros(string consultaSql, Producto p)
        //{
        //    Conectar();
        //    comando.CommandText = consultaSql;
        //    comando.Parameters.AddWithValue("@detalle", p.pCodigo);
        //    comando.Parameters.AddWithValue("@tipo", p.pTipo);
        //    comando.Parameters.AddWithValue("@marca", p.pMarca);
        //    comando.Parameters.AddWithValue("@precio", p.pPrecio);
        //    comando.Parameters.AddWithValue("fecha", p.pFecha);
        //    comando.Parameters.AddWithValue("@codigo", p.pCodigo);



        //    comando.ExecuteNonQuery();
        //    Desconectar();
        //}
    }//siempre que parametrizes se evita el Sql injection
}