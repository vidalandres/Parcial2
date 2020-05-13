using System.Collections.Generic;  
using System.Data.SqlClient;
using Entity;

namespace Datos
{
    public class PersonaRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Persona> _psns = new List<Persona>();

        public PersonaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Persona psn)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into [psns].[dbo].[psn] (Identificacion)
                                                    values (@identificacion)";
                command.Parameters.AddWithValue("@Identificacion", psn.Identificacion);
                var filas = command.ExecuteNonQuery();
            }

        }

        public List<Persona> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Persona> psns = new List<Persona>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from [psns].[dbo].[psn]";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona psn = DataReaderMapToPerson(dataReader);
                        psns.Add(psn);
                    }
                }
            }
            return psns;
        }

        private Persona DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if(!dataReader.HasRows) return null;
            Persona psn = new Persona();
            /*psn.Identificacion = (string)dataReader["Identificacion"];
            return psn;*/
            return null;

        }
    }
}




