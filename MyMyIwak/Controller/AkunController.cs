using MyMyIwak.Models;
using MyMyIwak.Models.Interfaces;
using MyMyIwak.Repositories;

namespace MyMyIwak.Controllers
{
    internal class AkunController
    {
        private readonly IAkunRepository akunRepo;

        public AkunController(IAkunRepository akunRepo)
        {
            this.akunRepo = akunRepo;
        }

        private Akun AmbilAkun(int id_akun)
        {
            Akun? akun = akunRepo.AmbilById(id_akun);
            if (akun == null)
            {
                throw new InvalidOperationException("Akun tidak ditemukan.");
            }
            return akun;
        }

        public List<Akun> DaftarAdmin(Owner owner)
        {
            return akunRepo.AmbilByRole(Role.Admin);
        }

        public Admin TambahAdmin(Owner owner, string username, string nama_lengkap, string password,
                                 string no_telepon, string alamat)
        {
            if (akunRepo.AmbilByUsername(username) != null)
            {
                throw new InvalidOperationException("Username sudah dipakai.");
            }

            Admin admin = new Admin(akunRepo.IdBerikutnya(), username, nama_lengkap, password,
                                    no_telepon, alamat, true);
            akunRepo.Tambah(admin);
            return admin;
        }

        public void NonaktifkanAkun(IPengelolaAkun pengelola, int id_akun)
        {
            Akun target = AmbilAkun(id_akun);
            pengelola.NonaktifkanAkun(target);
            akunRepo.Update(target);
        }

        public void AktifkanAkun(IPengelolaAkun pengelola, int id_akun)
        {
            Akun target = AmbilAkun(id_akun);
            pengelola.AktifkanAkun(target);
            akunRepo.Update(target);
        }

        public void UbahProfil(Akun akun, string nama_lengkap, string no_telepon, string alamat)
        {
            akun.UbahProfil(nama_lengkap, no_telepon, alamat);
            akunRepo.Update(akun);
        }

        public void GantiPassword(Akun akun, string password_lama, string password_baru)
        {
            akun.GantiPassword(password_lama, password_baru);
            akunRepo.Update(akun);
        }
    }
}
