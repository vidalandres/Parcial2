using Entity;

namespace SegundoParcial.Models
{
    public class ApoyoInputModel
    {
        public string Id{ get; set; }
    }


    public class ApoyoViewModel : ApoyoInputModel
    {
        public ApoyoViewModel()
        {  
        }
        public ApoyoViewModel(Apoyo apy)
        {
            Id = apy.Identificacion;
        }
        public double ValorTotalAPagar { get; set; }
    }

}