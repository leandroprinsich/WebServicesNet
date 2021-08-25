using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstituto
{
    public abstract class BaseAbs
    {
        
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public abstract string prueba();
    }
}
