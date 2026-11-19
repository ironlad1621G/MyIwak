using System;
using MyMyIwak.Database;

namespace MyIwak.DatabaseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DbInit.CreateTables();
                DbSeeder.Seed();

                Console.WriteLine("Database berhasil diinisialisasi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal membuat tabel:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}