using LinkedList.Perpustakaan;

namespace LinkedList.ManajemenKaryawan;

public class DaftarKaryawan
{
    private KaryawanNode? Head;
    private KaryawanNode? Tail;
    public void TambahKaryawan(Karyawan data)
    {
        KaryawanNode newNode = new KaryawanNode(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
    }
    public bool HapusKaryawan (string nomor)
    {
        KaryawanNode current = Head;
        while (current !=  null)
        {
            if (nomor == current.Karyawan.NomorKaryawan)
            {
                if (current.Prev != null)
                {
                    current.Prev.Next =current.Next;
                }
                else
                {
                    Head = current.Next;  
                }
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    Tail = current.Prev;
                }
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public Karyawan[] CariKaryawan(string kataKunci)
    {
        List<Karyawan> daftarkaryawan = new List<Karyawan>();
        KaryawanNode? current = Head;
        while(current != null)
        {
            if (current.Karyawan.Nama.Contains(kataKunci,StringComparison.OrdinalIgnoreCase) ||
                current.Karyawan.Posisi.Contains(kataKunci,StringComparison.OrdinalIgnoreCase))
            {
                daftarkaryawan.Add(current.Karyawan);
            }
            current = current.Next;
        }
        return daftarkaryawan.ToArray();
    }

    public string TampilkanDaftar()
    {   
        List<string> hasil = new List<string>();
        KaryawanNode current = Tail;
        while (current != null)
        {
            hasil.Add($"{current.Karyawan.NomorKaryawan}; {current.Karyawan.Nama}; {current.Karyawan.Posisi}");
            current = current.Prev;
        }
        return string.Join("\n", hasil);
    } 

}




