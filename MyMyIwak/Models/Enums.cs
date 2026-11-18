namespace MyMyIwak.Models
{
    public enum MetodePembayaran { TransferBank, EWallet, Qris }
    public enum StatusPembayaran { Menunggu, Lunas, Ditolak }
    public enum StatusPengiriman { Menunggu, Dikemas, Dikirim, Diterima, Dibatalkan }
    public enum Role { Owner, Admin, Customer }
}
