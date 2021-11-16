using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Estudiantes
    {
        [JsonProperty]
        public Matriculas Matricula { get; set; }
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Nombres { get; set; }
        [JsonProperty]
        public string Apellidos { get; set; }
        [JsonProperty]
        public string Carnet { get; set; }
        [JsonProperty]
        public DateTime FechaDeNacimiento { get; set; }
        [JsonProperty]
        public int Edad { get; set; }
        [JsonProperty]
        public Notas[] Notas { get; set; }
    }
}
