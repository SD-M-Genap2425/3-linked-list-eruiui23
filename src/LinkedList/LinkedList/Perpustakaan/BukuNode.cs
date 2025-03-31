namespace LinkedList.Perpustakaan;    
public class BukuNode
{
   public Buku Data{get;set;} 

   public BukuNode? Next{get;set;}
   public BukuNode(Buku buku)
   {
        Data = buku;
        Next = null;
   }
     
}