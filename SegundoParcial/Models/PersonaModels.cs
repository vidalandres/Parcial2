using Entity;

namespace SegundoParcial.Models
{
    public class PersonaInputModel
    {
        //[JsonProperty]
        //[Key]
        public string Identificacion { get; set; }
        //[JsonProperty]
        public string Nombre { get; set; }
        //[JsonProperty]
        public string Apellido { get; set; }
        //[JsonProperty]
        public string Sexo { get; set; }
        //[JsonProperty]
        public int Edad { get; set; }
        //[JsonProperty]
        public string Departamento { get; set; }
        //[JsonProperty]
        public string Ciudad { get; set; }
        //[JsonProperty]
        public double Acumulado { get; set; }
    }


    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {  
        }
        public PersonaViewModel(Persona psn)
        {
            Identificacion = psn.Identificacion;
            Nombre = psn.Nombre;
            Apellido = psn.Apellido;
            Sexo = psn.Sexo;
            Edad = psn.Edad;
            Departamento = psn.Departamento;
            Ciudad = psn.Ciudad;
            Acumulado = psn.Acumulado;
        }
        
    }

}