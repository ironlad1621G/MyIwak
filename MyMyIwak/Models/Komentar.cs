using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    internal class Komentar : EntitasAktif
    {
        private int id_akun;
        private int id_ikan;
        private string isi = "";
        private DateTime waktu_komentar;

        public int Id_komentar
        {
            get { return Id; }
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
        public string Isi
        {
            get { return isi; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Komentar tidak boleh kosong");
                }
                else
                {
                    isi = value;
                }
            }
        }
        public DateTime Waktu_komentar
        {
            get { return waktu_komentar; }
            private set { waktu_komentar = value; }
        }
        public Komentar(int id_komentar, int id_akun, int id_ikan, string komentar, DateTime waktu_komentar, Boolean is_active)
            : base(id_komentar, is_active)
        {
            this.Id_akun = id_akun;
            this.Id_ikan = id_ikan;
            this.Isi = komentar;
            this.Waktu_komentar = waktu_komentar;
        }
        public void UpdateKomentar(string komentar)
        {
            this.Isi = komentar;
            this.Waktu_komentar = DateTime.Now;
        }
        public void HapusKomentar()
        {
            Nonaktifkan();
        }

        public override string Deskripsikan()
        {
            return $"Komentar #{Id} oleh akun #{Id_akun} ({Waktu_komentar:dd/MM/yyyy HH:mm}): {Isi}";
        }
    }
}
