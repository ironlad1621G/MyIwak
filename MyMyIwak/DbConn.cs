using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace MyMyIwak
{
    internal class DbConn
    {
        private readonly string connectionString = "Host=localhost;" + "Port=5432" + "Database=myiwak" + "username=posgres" + "password=241241";
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
