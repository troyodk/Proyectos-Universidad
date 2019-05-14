using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Projecto_BD_Algoritmos
{
    public class CRUD
    {
        public SqlConnection Conexion;
        public SqlCommand Comando;
        public SqlDataReader Lector;
        public string cadConexion;

        public CRUD()
        {
            this.Conexion = new SqlConnection();
            this.Comando = new SqlCommand();
            this.cadConexion = string.Empty;
        }

        public CRUD(string CadenaConexion)
        {
            this.Conexion = new SqlConnection();
            this.Conexion.ConnectionString = CadenaConexion;

            this.Comando = new SqlCommand();
            this.cadConexion = CadenaConexion;
        }
    }
}
