using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Notas
    {
        public Asignaturas Asignatura { get; set; }
        // Parciales
        public decimal IP { get; set; }
        public decimal IIP { get; set; }
        public decimal Sistematicos { get; set; }
        // Convocatorias
        public decimal IC { get; set; }
        public decimal IIC { get; set; }
        public decimal NotaFinal { get; set; }
    }
}
