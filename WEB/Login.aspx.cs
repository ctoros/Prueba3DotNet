using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usu = txtUser.Text;
            string cla = txtPass.Text;
            ServiceReference1.UsuarioLogin usLogin = new ServiceReference1.UsuarioLogin();
            ServiceReference1.SRV_LoginClient svCli = new ServiceReference1.SRV_LoginClient();

            usLogin = svCli.Login(usu,cla);
            if (usLogin == null)
            {
                lblIngreso.Text = "Ingreso mal " + "alias: " + usu + "  clave: " + cla;
            }
            else
            {
                lblIngreso.Text = "Ingreso correcto " + "alias: " + usLogin.alias + "  clave: " + usLogin.clave;
                Session["sessionUsuario"] = usLogin;
                Response.Redirect("Inicio");
            }
        }
    }
}