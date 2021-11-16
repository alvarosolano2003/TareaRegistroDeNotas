using Domain.Entites;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class EstudiantesModel : BaseModel<Estudiantes>, IEstudiantes
    {
        public string GetAsJson()
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
