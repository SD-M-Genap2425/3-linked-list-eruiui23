using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace LinkedList.Perpustakaan;    

public class KoleksiPerpustakaan
{
    private BukuNode Head;
    public void TambahBuku(Buku buku)
    {
        BukuNode nodebaru = new BukuNode(buku);
        if (Head ==null)
        {
            Head = nodebaru;
        }
        else
        {
            BukuNode current = Head;
            while(current.Next!=null)
            {
                current = current.Next;
            }
            current.Next = nodebaru;
        }
         
    }

    public bool HapusBuku(string judul)
    {
        if (Head == null)
        {
            return false;
        }
        if (Head.Data.Judul == judul || Head.Data.Judul.Contains(judul,StringComparison.OrdinalIgnoreCase))
        {
            Head = Head.Next;
            return true; 
        }

        BukuNode current = Head;
        while (current.Next != null)
        {
            if (current.Next.Data.Judul == judul || current.Next.Data.Judul.Contains(judul,StringComparison.OrdinalIgnoreCase))
            {
                current.Next = current.Next.Next;
                return true;
            }
            current = current.Next;
        }
        return false;
    }
    public Buku[] CariBuku(string kataKunci)
    {
        List<Buku> hasil = new List<Buku>();
        BukuNode? current = Head;
        while (current != null)
        {
            if (current.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
            {
                hasil.Add(current.Data);
            }
            current = current.Next;
        } 
        return hasil.ToArray();
    }
    public string TampilkanKoleksi()
    {
        BukuNode current = Head;
        List<string> hasil = new List<string>();
        while (current != null)
        {
            hasil.Add($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
            current = current.Next;
        }
        // while(current != null)
        // {
        //     Console.WriteLine($"\"{current.Buku.Judul}\"; {current.Buku.Penulis}; {current.Buku.Tahun}");
        //     current = current.Next;
        // }
        return string.Join("\n", hasil); 
    }
}








 











