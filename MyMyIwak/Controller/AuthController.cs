using MyMyIwak.Models;
using MyMyIwak.Repositories;

namespace MyMyIwak.Controllers

{
    internal class AuthController
    {
        private readonly IAkunRepository akunRepo;
        private Akun? akunLogin;

        public AuthController(IAkunRepository akunRepo)
        {
            this.akunRepo = akunRepo;
        }

        public Akun? AkunLogin => akunLogin;

        public bool SudahLogin => akunLogin != null;

        public Customer Register(string username, string nama_lengkap, string password,
                                 string no_telepon, string alamat)
        {
            if (akunRepo.AmbilByUsername(username) != null)
            {
                throw new InvalidOperationException("Username sudah dipakai.");
            }

            Customer customer = new Customer(akunRepo.IdBerikutnya(), username, nama_lengkap, password,
                                             no_telepon, alamat, true);
            akunRepo.Tambah(customer);
            return customer;
        }

        public Akun Login(string username, string password)
        {
            if (akunLogin != null)
            {
                throw new InvalidOperationException("Masih ada akun yang login. Logout terlebih dahulu.");
            }

            Akun? akun = akunRepo.AmbilByUsername(username);

            if (akun == null || !akun.CekPassword(password))
            {
                throw new UnauthorizedAccessException("Username atau password salah.");
            }
            if (!akun.Is_active)
            {
                throw new UnauthorizedAccessException("Akun ini sudah dinonaktifkan.");
            }

            akunLogin = akun;
            return akun;
        }

        public void Logout()
        {
            if (akunLogin == null)
            {
                throw new InvalidOperationException("Belum ada akun yang login.");
            }
            akunLogin = null;
        }
    }
}
