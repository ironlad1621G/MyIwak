using MyMyIwak.Models.Interfaces;

namespace MyMyIwak.Models
{
    internal class Owner : Admin, IPengelolaAkun
    {
        public Owner(int id_akun, string username, string nama_lengkap, string password, string no_telepon, string alamat, bool is_active)
            : base(id_akun, username, nama_lengkap, password, no_telepon, alamat, is_active)
        {
        }

        public override Role Role
        {
            get { return Role.Owner; }
        }

        public void NonaktifkanAkun(Akun akun)
        {
            if (akun == this)
            {
                throw new InvalidOperationException("Owner tidak bisa menonaktifkan dirinya sendiri");
            }
            akun.Nonaktifkan();
        }

        public void AktifkanAkun(Akun akun)
        {
            akun.Aktifkan();
        }
    }
}
