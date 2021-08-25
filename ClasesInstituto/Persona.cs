using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstituto
{
    public class Persona
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime Nacimiento { set; get; }
        public int Codigo { set; get; }
        public string Mail { set; get; }
        public string Telefono { set; get; }
        public virtual string prueba()
        {
            return "A ver";
        }
    }
}
