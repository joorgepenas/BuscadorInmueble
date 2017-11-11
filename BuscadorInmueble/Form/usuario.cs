using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;

namespace pagina
{
    public class usuario : conexion
    {
        private string usuarios;
        private string password;

        public string Usuarios
        {
            get { return this.usuarios; }
            set { this.usuarios = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT id FROM acceso WHERE usuario='{0}' 
                                    AND password='{1}'", this.usuarios, this.password);
            this.cmd = new SqlCommand(this.sql, this.c);
            this.c.Open();
            SqlDataReader r = null;
            r = this.cmd.ExecuteReader();
            if (r.Read())
            {
                Resultado = true;
                this.mensaje = "DATOS CORRECTOS";
            }
            else
            {
                this.mensaje = "ERROR !!!";
            }
            this.c.Close();
            return Resultado;
        }
    }
}