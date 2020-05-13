using Entity;
using System;
using System.Collections.Generic;
using Datos;

namespace Logica
{
    public class ApoyoService
    {
        //private readonly ConnectionManager _conexion;
        private readonly ApoyoRepository _repositorio;

        public ApoyoService(GeneralContext _GContext)
        {
           // _conexion = new ConnectionManager(connectionString);
            _repositorio = new ApoyoRepository(_GContext);
        }

        public Apoyo Guardar(Apoyo apy)
        {
            
            if(_repositorio.Guardar(apy))
                return apy;
            else
                return null;

        }

        public Apoyo[] ConsultarTodos()
        {
            return this._repositorio.ConsultarTodos();
        }

    }
    
}
