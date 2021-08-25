using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstituto
{
    public class Alumno : BaseAbs
    {
        public string Nacionalidad { get; set; }

        public Carrera Carrera { set; get; }
        public Curso[] Cursos { set; get; }
        public override string prueba() => "chau";

    }
}
