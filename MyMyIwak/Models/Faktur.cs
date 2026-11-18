using System.Text;

namespace MyMyIwak.Models
{
    public class Faktur
    {
        private readonly int id_faktur;
        private readonly int id_transaksi;
        private readonly string nomor_faktur;
        private readonly DateTime tanggal_terbit;

        public Faktur(int id_faktur, int id_transaksi, string nomor_faktur, DateTime tanggal_terbit)
        {
            if (string.IsNullOrWhiteSpace(nomor_faktur))
            {
                throw new ArgumentException("Nomor faktur wajib diisi.");
            }
            this.id_faktur = id_faktur;
            this.id_transaksi = id_transaksi;
            this.nomor_faktur = nomor_faktur;
            this.tanggal_terbit = tanggal_terbit;
        }
        public int IdFaktur => id_faktur;
        public int IdTransaksi => id_transaksi;
        public string NomorFaktur => nomor_faktur;
        public DateTime TanggalTerbit => tanggal_terbit;

        public static string BuatNomor(DateTime tanggal, int id_transaksi)
        {
            return $"INV-{tanggal:yyyyMMdd}-{id_transaksi:D4}";
        }


        public string Cetak(Transaksi transaksi, long ongkir)
        {
            var sb = new StringBuilder();
            sb.AppendLine("========== FAKTUR MyIwak ==========");
            sb.AppendLine($"No. Faktur : {nomor_faktur}");
            sb.AppendLine($"Tanggal    : {tanggal_terbit:dd/MM/yyyy HH:mm}");
            sb.AppendLine("-----------------------------------");

            foreach (var d in transaksi.Detail)
            {
                sb.AppendLine($"Ikan #{d.IdIkan}   {d.Jumlah} x Rp {d.HargaSatuan:N0} = Rp {d.HitungSubTotal():N0}");
            }
            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Subtotal   : Rp {transaksi.HitungSubtotal():N0}");

            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Ongkir     : Rp {ongkir:N0}");
            sb.AppendLine($"TOTAL      : Rp {transaksi.TotalPembayaran:N0}");
            return sb.ToString();
        }
    }
}