using Newtonsoft.Json;
using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Persona
    {
        [JsonProperty]
        [Key]
        public string Identificacion { get; set; }
        [JsonProperty]
        public string Nombre { get; set; }
        [JsonProperty]
        public string Apellido { get; set; }
        [JsonProperty]
        public string Sexo { get; set; }
        [JsonProperty]
        public int Edad { get; set; }
        [JsonProperty]
        public string Departamento { get; set; }
        [JsonProperty]
        public string Ciudad { get; set; }
        [JsonProperty]
        public double Acumulado { get; set; }

        public Persona()
        {
            this.Identificacion = "1";
            this.Nombre = "Luis";
            this.Apellido = "Lopez";
            this.Sexo = "Masculino";
            this.Edad = 0;
            this.Departamento = "Cesar";
            this.Ciudad = "V/par";
            this.Acumulado = 0;
        }

    }
}
