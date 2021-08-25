using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesInstituto;

namespace InterfazInstituto
{
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Crear_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            BaseAbs []bases  = new BaseAbs[1];
            //Persona p = new Persona();
            a.Nombre = txt_Nombre.Text;
            a.Apellido = txt_Apellido.Text;
            a.Nacionalidad = "Argentina";
            bases[0] = a;
            //a.DatosAlumno = p;
            //a.Codigo = Convert.ToInt32(txt_Codigo.Text);

            //Carrera c = new Carrera();
            ////c.Nombre = "FullStack .Net Digit@lers";
            //c.Nombre = SelectorCurso.Text;

            //Curso cu = new Curso();
            ////cu.Nombre = "Programación Web con C# .Net";
            //if (Curso1.Checked)
            //{
            //    cu.Nombre = Curso1.Text;
            //}
            //else
            //{
            //    cu.Nombre = "Ninguno";
            //}

            //lbl_Nombre.Text = "Nombre del alumno: " + a.Nombre;
            //lbl_Apellido.Text = "Apellido del alumno: " + a.Apellido;
            //lbl_Codigo.Text = "Codigo del alumno: " + a.Codigo;
            //lbl_Carrera.Text = "Carrera: " + c.Nombre;
            lbl_Curso.Text = "Curso actual: " + a.Nacionalidad;
        }


    }
}