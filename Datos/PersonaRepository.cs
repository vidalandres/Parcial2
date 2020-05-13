using System.Collections.Generic;  
using System.Data.SqlClient;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class PersonaRepository
    {
        //private readonly SqlConnection _connection;
        private readonly GeneralContext GContext;
        private readonly List<Persona> _psns = new List<Persona>();

        private List<Persona> psns;

        public PersonaRepository(GeneralContext _GContex)
        {
            //_connection = connection._conexion;
            this.GContext = _GContex;
        }

        public bool Guardar(Persona psn)
        {
            var _psn = this.GContext.Personas.Find(psn.Identificacion);

            if(_psn!=null)
                return false;

            this.GContext.Personas.Add(psn);
            this.GContext.SaveChanges();
            return true;

        }

        public Persona[] ConsultarTodos()
        {
            var psns = this.GContext.Personas.ToArrayAsync();
            return psns.Result;
        }

    }
}




