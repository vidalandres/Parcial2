using Entity;
using System;
using System.Collections.Generic;
using Datos;

namespace Logica
{
    public class PersonaService
    {
        //private readonly ConnectionManager _conexion;
        private readonly PersonaRepository _repositorio;

        public PersonaService( GeneralContext _GContext)
        {
           // _conexion = new ConnectionManager(connectionString);
            _repositorio = new PersonaRepository(_GContext);
        }

        public GuardarResponse Guardar(Persona psn)
        {
            
            if(_repositorio.Guardar(psn))
                return new GuardarResponse(psn);
            else
                return new GuardarResponse("Error al guardar");

        }

        public Persona[] ConsultarTodos()
        {
            return this._repositorio.ConsultarTodos();
        }

    }

    public class GuardarResponse
    {
        public GuardarResponse(Persona psn)
        {
            Error = false;
            Persona = psn;
        }
        public GuardarResponse(string mensaje)
        {      
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }

    
}
