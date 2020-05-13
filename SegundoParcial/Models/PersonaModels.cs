using Entity;

namespace PrimerParcial.Models
{
    public class PersonaInputModel
    {
        public string Identificacion{ get; set; }
    }


    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {  
        }
        public PersonaViewModel(Persona psn)
        {
            Identificacion = psn.Identificacion;
        }
        public double ValorTotalAPagar { get; set; }
    }

}