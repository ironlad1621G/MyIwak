using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class Akun
    {
        private int id_akun;
        private string username;
        private string nama_lengkap;
        private string password;
        private string no_telepon;
        private string alamat;
        private string role;
        private Boolean is_active;

        public int Id_akun
        {
            get { return id_akun; }
            private set { Id_akun = value; }
        }
        public string Username
        {
            get { return username; }
            private set { username = value; }
        }
        public string Nama_lengkap
        {
            get { return nama_lengkap; }
            private set { nama_lengkap = value; }
        }
        public string Password
        {
            get { return password; }
            private set { password = value; }
        }
        public string No_telepon
        {
            get { return no_telepon; }
            private set { no_telepon = value; }
        }
        public string Alamat
        {
            get { return alamat; }
            private set { alamat = value; }
        }
        public string Role
        {
            get { return role; }
            private set { role = value; }
        }
        public Boolean Is_active
        {
            get { return is_active; }
            private set { is_active = value; }
        }
        public Akun(int id_akun, string username, string nama_lengkap, string password, string no_telepon, string alamat, string role, Boolean is_active)
        {
            this.Id_akun = id_akun;
            this.Username = username;
            this.Nama_lengkap = nama_lengkap;
            this.Password = password;
            this.No_telepon = no_telepon;
            this.Alamat = alamat;
            this.Role = role;
            this.Is_active = is_active;
        }
    }
}
