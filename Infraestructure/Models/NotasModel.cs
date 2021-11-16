using Domain.Entites;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class NotasModel : BaseModel<Notas>, INotas
    {
        public decimal CalculateFinalScore(decimal p1, decimal p2, decimal sis, decimal c1, decimal c2)
        {
            if (p1 + p2 + sis >= 60)
            {
                return p1 + p2 + sis;
            }
            else if (sis + c1 >= 60)
            {
                return sis + c1;
            }
            else
            {
                return c2;
            }
        }

        public void DeleteAll()
        {
            data.Clear();
        }
    }
}
