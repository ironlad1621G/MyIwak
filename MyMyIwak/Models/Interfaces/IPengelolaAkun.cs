namespace MyMyIwak.Models.Interfaces
{
    internal interface IPengelolaAkun
    {
        void NonaktifkanAkun(Akun akun);
        void AktifkanAkun(Akun akun);
    }
}
