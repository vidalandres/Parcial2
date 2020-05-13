
using Newtonsoft.Json;
using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Apoyo
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty]
        public string Persona { get; set; }

        [JsonProperty]
        public string Tipo { get; set; }

        [JsonProperty]
        public int Valor { get; set; }

        [JsonProperty]
        public DateTime Fecha { get; set; }

        public Apoyo() {
            this.Id= 0;
            this.Persona = "1";
            this.Tipo = "Alimentario";
            this.Valor = 0;
            this.Fecha = new DateTime(); 
        }

    }
}
