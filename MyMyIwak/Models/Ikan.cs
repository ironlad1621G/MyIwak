using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    public class Ikan : EntitasAktif
    {
        private string jenis = "";
        private string warna = "";
        private int umur_bulan;
        private int stok;
        private long harga;
        private string deskripsi = "";

        public int Id_ikan
        {
            get { return Id; }
        }
        public string Jenis
        {
            get { return jenis; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Jenis ikan tidak boleh kosong");
                }
                else
                {
                    jenis = value;
                }
            }
        }
        public string Warna
        {
            get { return warna; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Warna ikan tidak boleh kosong");
                }
                else
                {
                    warna = value;
                }
            }
        }
        public int Umur_bulan
        {
            get { return umur_bulan; }
            set
            {
                if (value >= 0)
                {
                    umur_bulan = value;
                }
                else
                {
                    throw new ArgumentException("Umur tidak mungkin kurang dari 0");
                }
            }
        }
        public int Stok
        {
            get { return stok; }
            private set
            {
                if (value >= 0)
                {
                    stok = value;
                }
                else
                {
                    throw new ArgumentException("Stok tidak boleh kurang dari 0");
                }
            }
            
        }
        public long Harga
        {
            get { return harga; }
            set
            {
                if (value >= 0)
                {
                    harga = value;
                }
                else
                {
                    throw new ArgumentException("Harga tidak boleh kurang dari 0");
                }
            }
        }
        public string Deskripsi
        {
            get { return deskripsi; }
            set { deskripsi = value; }
        }
        public Ikan(int id_ikan, string jenis, string warna, int umur_bulan, int stok, long harga, string deskripsi, Boolean is_active)
            : base(id_ikan, is_active)
        {
            this.Jenis = jenis;
            this.Warna = warna;
            this.Umur_bulan = umur_bulan;
            this.Stok = stok;
            this.Harga = harga;
            this.Deskripsi = deskripsi;
        }
        public void TambahStok(int jumlah)
        {
            if (jumlah > 0)
            {
                Stok += jumlah;
            }
            else
            {
                throw new ArgumentException("Jumlah yang ditambahkan harus lebih besar dari 0");
            }
        }
        public void KurangiStok(int jumlah)
        {
            if (jumlah > 0)
            {
                if (Stok - jumlah >= 0)
                {
                    Stok -= jumlah;
                }
                else
                {
                    throw new ArgumentException("Stok tidak boleh kurang dari 0");
                }
            }
            else
            {
                throw new ArgumentException("Jumlah yang dikurangi harus lebih besar dari 0");
            }
        }
        public override void Nonaktifkan()
        {
            if (!Is_active)
            {
                throw new InvalidOperationException("Ikan ini sudah dihapus.");
            }
            base.Nonaktifkan();
        }

        public override string Deskripsikan()
        {
            return $"Ikan {Jenis} ({Warna}, {Umur_bulan} bln) - Rp {Harga:N0} - stok {Stok}";
        }
    }
}
