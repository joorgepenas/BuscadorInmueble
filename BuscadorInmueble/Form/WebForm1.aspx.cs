using System;
using pagina;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuscadorInmueble.Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            usuario usuarioDB = new usuario();
            usuarioDB.Usuarios = this.txt1.Text;
            usuarioDB.Password = this.txt2.Text;
            if (usuarioDB.Buscar() == true)
            {

                Response.Redirect("~/Views/Usuario/Index.cshtml");
            }
            else
            {
                Server.Transfer("WebForm1.aspx");
            }
        }
    
    }
}