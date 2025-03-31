namespace LinkedList.ManajemenKaryawan;

public class KaryawanNode
{
    public Karyawan Karyawan{get;}
    public KaryawanNode? Next{get;set;}
    public KaryawanNode? Prev{get;set;}
    public KaryawanNode(Karyawan data)
    {
        Next = null;
        Prev = null;
        Karyawan = data;
    }
}