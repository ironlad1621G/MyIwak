namespace MyMyIwak.Models
{
    internal class Customer : Akun
    {
        public Customer(int id_akun, string username, string nama_lengkap, string password, string no_telepon, string alamat, bool is_active)
            : base(id_akun, username, nama_lengkap, password, no_telepon, alamat, is_active)
        {
        }

        public override Role Role
        {
            get { return Role.Customer; }
        }

        public override string Deskripsikan()
        {
            return base.Deskripsikan() + $" - alamat: {Alamat}";
        }
    }
}
