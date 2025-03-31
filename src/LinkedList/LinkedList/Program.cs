using LinkedList.Perpustakaan;
using LinkedList.ManajemenKaryawan;
using LinkedList.Inventori;

namespace LinkedList;


class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        KoleksiPerpustakaan perpustakaan = new KoleksiPerpustakaan();

        perpustakaan.TambahBuku(new Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        perpustakaan.TambahBuku(new Buku("Makanya Mikir", "Abigail dan Cania", 2025));
        perpustakaan.TambahBuku(new Buku("Kotenbu Series", "Yonezawa Honobu", 2015));

        Console.WriteLine("Daftar Buku:\n");
        Console.WriteLine(perpustakaan.TampilkanKoleksi());

        Console.WriteLine("\nMenghapus buku makanya mikir\n");
        perpustakaan.HapusBuku("Makanya Mikir");
        Console.WriteLine(perpustakaan.TampilkanKoleksi());


        Console.WriteLine("\nMencari Buku yang ada o nya \n");
        var hasilPencarian = perpustakaan.CariBuku("o");
        foreach (var buku in hasilPencarian)
        {
            Console.WriteLine($"\"{buku.Judul}\"; {buku.Penulis}; {buku.Tahun}");
        }


        // Soal ManajemenKaryawan
        DaftarKaryawan DaftarKaryawan = new DaftarKaryawan();

        Console.WriteLine("\nMenampilkan Daftar Karyawan secara terbalik\n");
        DaftarKaryawan.TambahKaryawan(new Karyawan("001","Tony Stark", "Office Boy"));
        DaftarKaryawan.TambahKaryawan(new Karyawan("002","Gojo Satoru", "Penjual Kantin"));
        DaftarKaryawan.TambahKaryawan(new Karyawan("003","Oreki Hotarou", "Senior Manager"));
        DaftarKaryawan.TambahKaryawan(new Karyawan("004","Kairi", "Staff"));

        Console.WriteLine(DaftarKaryawan.TampilkanDaftar());
        Console.WriteLine("\nMengapus karyawan nomor sekian\n");
        DaftarKaryawan.HapusKaryawan("001");
        Console.WriteLine(DaftarKaryawan.TampilkanDaftar());

        Console.WriteLine("\nMencari Karyawan dengan katakunci ...\n");
        var hasilPencarianKaryawan = DaftarKaryawan.CariKaryawan("o");
        foreach (var k in hasilPencarianKaryawan)
        {
            Console.WriteLine($"{k.NomorKaryawan}; {k.Nama}; {k.Posisi}"); 
        }

        // Soal Inventori
        ManajemenInventori inventori = new ManajemenInventori();
        inventori.TambahItem(new Item("robux", 500));
        inventori.TambahItem(new Item("R99", 1));
        inventori.TambahItem(new Item("Cindo Fine Shyt", 5));

        Console.WriteLine("\nMenampilkan Item\n");
        Console.WriteLine(inventori.TampilkanInventori()); 
        Console.WriteLine("\nMengapus item\n");
        inventori.HapusItem("R99");
        Console.WriteLine(inventori.TampilkanInventori()); 




    }
}
