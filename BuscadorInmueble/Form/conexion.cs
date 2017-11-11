using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;

namespace pagina
{
    public class conexion
    {
        public string cadenaConexion;
        protected string sql;
        protected int resultado;
        protected SqlConnection c;
        protected SqlCommand cmd;
        protected string mensaje;

        public conexion()
        {
            this.cadenaConexion = (@"Data Source=JORGE-PC;Initial Catalog =DBInmueble; 
                                    integrated security=true");
            this.c = new SqlConnection(this.cadenaConexion);
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }
    }
}