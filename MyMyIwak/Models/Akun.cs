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
        public string Password
        {
            get { return password; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Password tidak boleh kosong");
                }
                else
                {
                    password = value;
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
