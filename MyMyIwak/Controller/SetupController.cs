using MyMyIwak.Models;
using MyMyIwak.Repositories;

namespace MyMyIwak.Controllers

{
    internal class SetupController
    {
        private readonly IAkunRepository akunRepo;

        public SetupController(IAkunRepository akunRepo)
        {
            this.akunRepo = akunRepo;
        }

        public bool PerluSetup()
        {
            return !akunRepo.AdaOwner();
        }

        public Owner BuatOwnerPertama(string username, string nama_lengkap, string password,
                                      string no_telepon, string alamat)
        {
            if (akunRepo.AdaOwner())
            {
                throw new InvalidOperationException("Owner sudah ada. Setup hanya bisa dilakukan sekali.");
            }
            if (akunRepo.AmbilByUsername(username) != null)
            {
                throw new InvalidOperationException("Username sudah dipakai.");
            }

            Owner owner = new Owner(akunRepo.IdBerikutnya(), username, nama_lengkap, password,
                                    no_telepon, alamat, true);
            akunRepo.Tambah(owner);
            return owner;
        }
    }
}
