using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INotas : IBase<Notas>
    {
        decimal CalculateFinalScore(decimal p1, decimal p2, decimal sis, decimal c1, decimal c2);
        void DeleteAll();
    }
}
