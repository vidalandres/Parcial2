using Entity;

using System;

namespace SegundoParcial.Models
{
    public class ApoyoInputModel
    {
        //[Key]
        public int Id { get; set; }

        //[JsonProperty]
        public string Persona { get; set; }

        //[JsonProperty]
        public string Tipo { get; set; }

        //[JsonProperty]
        public int Valor { get; set; }

        //[JsonProperty]
        public DateTime Fecha { get; set; }
    }


    public class ApoyoViewModel : ApoyoInputModel
    {
        public ApoyoViewModel()
        {  
        }
        public ApoyoViewModel(Apoyo apy)
        {
            Persona = apy.Persona;
            Valor = apy.Valor;
            Tipo = apy.Tipo;
            Fecha = apy.Fecha;
        }
    }

}