using System;
using System.IO;
using Npgsql;

namespace MyMyIwak.Database
{
    internal class DbConn
    {
        private readonly string connectionString;

        public DbConn()
        {
            string path = Path.Combine(
                AppContext.BaseDirectory,
                "koneksi.txt"
            );

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    "File koneksi.txt tidak ditemukan!"
                );
            }
            connectionString = File.ReadAllText(path).Trim();
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}