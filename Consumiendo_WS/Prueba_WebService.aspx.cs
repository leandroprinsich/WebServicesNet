using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumiendo_WS
{
    public partial class Prueba_WebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // oMiServicioWeb es una instancia de la clase ServicioWeb.asmx
            // en realidad objeto de la clase ServicioWeb que está dentro de 
            // SErvicioWeb.asmx
            var oMiServicioWeb = new ServiceReference1.ServiciosWebSoapClient();
            Label1.Text = oMiServicioWeb.HelloWorld();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var oMiServicioWeb = new ServiceReference1.ServiciosWebSoapClient();
            Label2.Text = oMiServicioWeb.FechayHora();
        }
    }
}