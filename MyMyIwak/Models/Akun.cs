namespace MyMyIwak.Models
{
    internal abstract class Akun : EntitasAktif
    {
        private string username = "";
        private string nama_lengkap = "";
        private string password = "";
        private string no_telepon = "";
        private string alamat = "";

        public int Id_akun
        {
            get { return Id; }
        }
        public string Username
        {
            get { return username; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username tidak boleh kosong");
                }
                else
                {
                    username = value;
                }
            }
        }
        public string Nama_lengkap
        {
            get { return nama_lengkap; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nama lengkap tidak boleh kosong");
                }
                else
                {
                    nama_lengkap = value;
                }
            }
        }
        public string No_telepon
        {
            get { return no_telepon; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nomor telepon tidak boleh kosong");
                }
                else
                {
                    no_telepon = value;
                }
            }
        }
        public string Alamat
        {
            get { return alamat; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Alamat tidak boleh kosong");
                }
                else
                {
                    alamat = value;
                }
            }
        }

        public abstract Role Role { get; }

        protected Akun(int id_akun, string username, string nama_lengkap, string password, string no_telepon, string alamat, bool is_active)
            : base(id_akun, is_active)
        {
            this.Username = username;
            this.Nama_lengkap = nama_lengkap;
            SetPassword(password);
            this.No_telepon = no_telepon;
            this.Alamat = alamat;
        }

        public bool CekPassword(string input)
        {
            return password == input;
        }

        public void GantiPassword(string password_lama, string password_baru)
        {
            if (!CekPassword(password_lama))
            {
                throw new InvalidOperationException("Password lama salah");
            }
            SetPassword(password_baru);
        }

        public void UbahProfil(string nama_lengkap, string no_telepon, string alamat)
        {
            this.Nama_lengkap = nama_lengkap;
            this.No_telepon = no_telepon;
            this.Alamat = alamat;
        }

        private void SetPassword(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Password tidak boleh kosong");
            }
            password = value;
        }

        public override string Deskripsikan()
        {
            return $"[{Role}] {Nama_lengkap} (@{Username})";
        }
    }
}
