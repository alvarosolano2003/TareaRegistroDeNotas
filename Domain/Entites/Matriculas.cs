using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Matriculas
    {
        public int NumeroDeMatricula { get; set; }
        public DateTime Fecha { get; set; }
        public string Carnet { get; set; }
        public Grupo Grupo { get; set; }
        public Asignaturas[] Asignaturas { get; set; }
    }
}
