using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstituto
{
    public class Clase
    {
        public int Numero { set; get; }
        //public int Duracion { set; get; }
        public string[] Contenido { set; get; }
        public DateTime Inicio { set; get; }
        public DateTime Fin { set; get; }
        public Curso Curso { set; get; }
    }
}
