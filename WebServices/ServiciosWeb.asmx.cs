using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Descripción breve de ServiciosWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiciosWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string FechayHora()
        {
            return DateTime.Now.ToString();
        }
        [WebMethod]
        public double CalcularSueldo(double sueldoBasico, double antiguedad, double horasExtras)
        {
            var paso1 = sueldoBasico + antiguedad + horasExtras;
            return (paso1 - (paso1 * 0.11) - (paso1 * 0.03));
        }
    }
}
