using System;

namespace MensajesDeError
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var nombre = Request.QueryString["txtNombre"].ToString();
            var edad = Request.QueryString["txtEdad"].ToString();
            var email = Request.QueryString["txtEmail"].ToString();
            Label1.Text = String.Format("Su nombre es {0}, ha ingresado un password válido, " +
                               "tiene {1} años de edad y su email es {2}", nombre, edad, email);
        }
    }
}
