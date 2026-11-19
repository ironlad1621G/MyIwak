using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class Komentar
    {
        private int id_komentar;
        private int id_akun;
        private int id_ikan;
        private string komentar;
        private DateTime waktu_komentar;
        private Boolean is_active;

        public int Id_komentar
        {
            get { return id_komentar; }
            private set { id_komentar = value; }
        }
        public int Id_akun
        {
            get { return id_akun; }
            private set { id_akun = value; }
        }
        public int Id_ikan
        {
            get { return id_ikan; }
            private set { id_ikan = value; }
        }
        public string Komentare
        {
            get { return komentar; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Komentar tidak boleh kosong");
                }
                else
                {
                    komentar = value;
                }
            }
        }
        public DateTime Waktu_komentar
        {
            get { return waktu_komentar; }
            private set { waktu_komentar = value; }
        }
        public Boolean Is_active
        {
            get { return is_active; }
            private set { is_active = value; }
        }
        public Komentar(int id_komentar, int id_akun, int id_ikan, string komentar, DateTime waktu_komentar, Boolean is_active)
        {
            this.Id_komentar = id_komentar;
            this.Id_akun = id_akun;
            this.Id_ikan = id_ikan;
            this.Komentare = komentar;
            this.Waktu_komentar = waktu_komentar;
            this.Is_active = is_active;
        }
        public void UpdateKomentar(string komentar)
        {
            this.Komentare = komentar;
            this.Waktu_komentar = DateTime.Now;
        }
        public void HapusKomentar()
        {
            this.Is_active = false;
        }
    }
}
