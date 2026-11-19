using MyMyIwak.Controllers;
using MyMyIwak.Models;
using MyMyIwak.Repositories;


IAkunRepository akunRepo = new AkunRepositoryMemori();
IIkanRepository ikanRepo = new IkanRepositoryMemori();
IKeranjangRepository keranjangRepo = new KeranjangRepositoryMemori();
IKomentarRepository komentarRepo = new KomentarRepositoryMemori();
ILayananPengirimanRepository layananRepo = new LayananPengirimanRepositoryMemori();

var setup = new SetupController(akunRepo);
var auth = new AuthController(akunRepo);
var akunCtrl = new AkunController(akunRepo);
var ikanCtrl = new IkanController(ikanRepo);
var keranjangCtrl = new KeranjangController(keranjangRepo, ikanRepo, layananRepo);
var komentarCtrl = new KomentarController(komentarRepo, ikanRepo);

layananRepo.Tambah(new Layananpengiriman(1, "Reguler", 20000, "2-3 hari"));
layananRepo.Tambah(new Layananpengiriman(2, "Kilat", 45000, "1 hari"));

void Coba(string judul, Action aksi)
{
    try
    {
        aksi();
        Console.WriteLine($"[OK]    {judul}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"[DITOLAK] {judul} -> {e.Message}");
    }
}

Owner owner = setup.BuatOwnerPertama("owner", "Pak Owner", "rahasia", "0811", "Surabaya");
Console.WriteLine($"Owner dibuat: {owner}");
Coba("Setup Owner kedua kali", () => setup.BuatOwnerPertama("owner2", "X", "x", "1", "x"));

Admin admin = akunCtrl.TambahAdmin(owner, "admin1", "Bu Admin", "admin123", "0812", "Malang");
Console.WriteLine($"Admin dibuat: {admin}");

auth.Register("budi", "Budi Santoso", "budi123", "0813", "Sidoarjo");
Akun login = auth.Login("budi", "budi123");
Console.WriteLine($"Login sebagai: {login}");
Customer budi = (Customer)login;
Coba("Login ganda tanpa logout", () => auth.Login("admin1", "admin123"));
auth.Logout();
Coba("Login dengan password salah", () => auth.Login("budi", "salah"));

ikanCtrl.TambahIkan(admin.Role, new Ikan(1, "Cupang Halfmoon", "Merah", 4, 10, 75000, "Sirip lebar", true));
ikanCtrl.TambahIkan(owner.Role, new Ikan(2, "Koi Kohaku", "Putih-Merah", 8, 3, 1500000, "Kualitas kontes", true));
Coba("Customer menambah ikan", () => ikanCtrl.TambahIkan(budi.Role, new Ikan(3, "Guppy", "Biru", 2, 5, 10000, "", true)));
Coba("Ikan dengan harga negatif", () => ikanCtrl.TambahIkan(admin.Role, new Ikan(4, "Molly", "Hitam", 3, 5, -1, "", true)));
ikanCtrl.UbahHarga(admin.Role, 1, 80000);
Console.WriteLine("Katalog:");
foreach (var i in ikanCtrl.Katalog())
{
    Console.WriteLine($"  - {i}");
}

Keranjang item = keranjangCtrl.TambahKeKeranjang(budi, 1, 2);
keranjangCtrl.TambahKeKeranjang(budi, 1, 1);
keranjangCtrl.TambahKeKeranjang(budi, 2, 1);
Console.WriteLine($"Keranjang: {item}");
Console.WriteLine($"Subtotal cupang: Rp {keranjangCtrl.HitungSubtotal(item):N0}, total keranjang: Rp {keranjangCtrl.HitungTotal(budi):N0}");
Coba("Tambah melebihi stok", () => keranjangCtrl.TambahKeKeranjang(budi, 2, 99));
keranjangCtrl.UbahJumlah(budi, item.Id_keranjang, 1);
Console.WriteLine($"Setelah ubah jumlah: {item}");
keranjangCtrl.HapusDariKeranjang(budi, item.Id_keranjang);
Console.WriteLine($"Isi keranjang setelah dihapus: {keranjangCtrl.IsiKeranjang(budi).Count} item");
Console.WriteLine("Layanan kirim:");
foreach (var l in keranjangCtrl.DaftarLayananKirim())
{
    Console.WriteLine($"  - {l.NamaLayanan}: Rp {l.Ongkir:N0} ({l.Estimasi})");
}

Komentar k = komentarCtrl.TulisKomentar(budi, 1, "Masih ada yang warna biru?");
komentarCtrl.BalasKomentar(admin, k.Id_komentar, "Ada kak, stok minggu depan.");
komentarCtrl.UbahKomentar(budi, k.Id_komentar, "Masih ada yang warna biru? Butuh 2 ekor.");
Console.WriteLine("Komentar ikan #1:");
foreach (var km in komentarCtrl.DaftarKomentar(1))
{
    Console.WriteLine($"  - {km}");
}
komentarCtrl.HapusKomentar(owner, k.Id_komentar);
Console.WriteLine($"Komentar aktif setelah dihapus: {komentarCtrl.DaftarKomentar(1).Count}");

akunCtrl.NonaktifkanAkun(owner, admin.Id_akun);
Coba("Admin nonaktif mencoba login", () => auth.Login("admin1", "admin123"));
Coba("Owner menonaktifkan dirinya sendiri", () => akunCtrl.NonaktifkanAkun(owner, owner.Id_akun));
akunCtrl.AktifkanAkun(owner, admin.Id_akun);
Console.WriteLine($"Admin aktif lagi: {admin.Is_active}, jumlah admin: {akunCtrl.DaftarAdmin(owner).Count}");

akunCtrl.GantiPassword(budi, "budi123", "baru456");
Coba("Login dengan password lama", () => auth.Login("budi", "budi123"));
Coba("Login dengan password baru", () => auth.Login("budi", "baru456"));
