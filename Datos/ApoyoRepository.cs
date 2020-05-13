using System.Collections.Generic;  
using System.Data.SqlClient;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class ApoyoRepository
    {
        //private readonly SqlConnection _connection;
        private readonly GeneralContext GContext;
        private readonly List<Apoyo> _apys = new List<Apoyo>();

        private List<Apoyo> apys;

        public ApoyoRepository(ConnectionManager connection, GeneralContext _GContex)
        {
            //_connection = connection._conexion;
            this.GContext = _GContex;
        }

        public bool Guardar(Apoyo apy)
        {
            var psn = this.GContext.Personas.Find(apy.Persona);
            if(psn == null)
                return false;
            psn.Acumulado += apy.Valor;
            this.GContext.Update(psn);
            this.GContext.SaveChanges();

            this.GContext.Apoyos.Add(apy);
            this.GContext.SaveChanges();
            return true;
        }

        public Apoyo[] ConsultarTodos()
        {
            var apys = this.GContext.Apoyos.ToArrayAsync();
            return apys.Result;
        }
        
    }
}




