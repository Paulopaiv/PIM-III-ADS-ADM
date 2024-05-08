using Npgsql;
using System;
using System.Data;

namespace PIM_III_ADS_ADM.Service
{
    public class Dbconexao : IDisposable
    {
        private readonly string connectionString;
        private NpgsqlConnection connection;

        public Dbconexao()
        {
            connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=4852;";
        }

        public IDbConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new NpgsqlConnection(connectionString);
                connection.Open(); // Abre a conexão assim que for criada
            }
            else if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); // Abre a conexão se estiver fechada
            }

            return connection;
        }

        public void Dispose()
        {
            if (connection != null)
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close(); // Fecha a conexão se estiver aberta
                }
                connection.Dispose();
                connection = null;
            }
        }
    }
}
