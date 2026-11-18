using System;
using System.Collections.Generic;
using System.Text;

namespace MyMyIwak.Models
{
    public class Detailtransaksi
    {
        private int id_detail_transaksi;
        private int id_transaksi;
        private int id_ikan;
        private int jumlah;
        private long harga_satuan;

        public Detailtransaksi(int id_detail_transaksi, int id_transaksi, int id_ikan, int jumlah, long harga_satuan)
        {
            if (jumlah <= 0)
            {
                throw new ArgumentException("Jumlah harus lebih dari 0.");
            }
            if (harga_satuan < 0)
            {
                throw new ArgumentException("Harga tidak boleh negatif.");
            }
            this.id_detail_transaksi = id_detail_transaksi;
            this.id_transaksi = id_transaksi;
            this.id_ikan = id_ikan;
            this.jumlah = jumlah;
            this.harga_satuan = harga_satuan;
        }
        public int IdDetailTransaksi => id_detail_transaksi;
        public int IdTransaksi => id_transaksi;
        public int IdIkan => id_ikan;
        public int Jumlah => jumlah;
        public long HargaSatuan => harga_satuan;

        public long HitungSubTotal() => harga_satuan * jumlah;
    }


}
