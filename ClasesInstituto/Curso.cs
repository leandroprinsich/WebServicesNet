using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstituto
{
    public class Curso
    {
        public int Codigo { set; get; }
        public string Nombre { set; get; }    
        public int Clases { set; get; }
        public int Duracion { set; get; }
        public DateTime InicioClase { set; get; }
        public DateTime FinClase { set; get; }
    }
}
