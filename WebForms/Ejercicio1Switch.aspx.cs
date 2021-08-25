using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Ejercicio1Switch : System.Web.UI.Page
    {
        public int seleccion = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = int.Parse(DropDownList1.SelectedValue);
            //lbl_resultado.Text = this.Operar(seleccion).ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            seleccion = int.Parse(DropDownList1.SelectedValue);
            lbl_resultado.Text = this.Operar(seleccion).ToString();
        }

        protected string Operar(int seleccion)
        {
            string resultado = "";
            if (n1.Text == "" || n1.Text == null || n2.Text == "" || n2.Text == null)
            {
                resultado = "Debe escribir dos números para operar";
            }
            else
            {
                switch (seleccion)
                {
                    case 1:
                        resultado = (double.Parse(n1.Text) + double.Parse(n2.Text)).ToString();
                        break;
                    case 2:
                        resultado = Convert.ToString(double.Parse(n1.Text) - double.Parse(n2.Text));
                        break;
                    case 3:
                        resultado = Convert.ToString(double.Parse(n1.Text) * double.Parse(n2.Text));
                        break;
                    case 4:
                        if (n2.Text == "0")
                        {
                            resultado = "No se permite la división por cero";
                        }
                        else
                        {
                            resultado = Convert.ToString(double.Parse(n1.Text) / double.Parse(n2.Text));
                        }

                        break;
                    default:
                        resultado = "Ha seleccionado una opción no válida";
                        break;
                }
            }
            return resultado;
        }
    }
}