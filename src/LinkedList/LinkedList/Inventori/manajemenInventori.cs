namespace LinkedList.Inventori;

public class ManajemenInventori
{
    LinkedList<Item> inventori = new LinkedList<Item>();

    public void TambahItem(Item item)
    {
        inventori.AddLast(item);
    }

    public bool HapusItem(string nama)
    {
        var current = inventori.First;
        while(current != null)
        {
            if (nama == current.Value.Nama)
            {
                inventori.Remove(current);
                return true;
            }
            current = current.Next;
        }
        return false;
    }
    
    public string TampilkanInventori()
    {
        string hasil =""; 
        var current = inventori.First;
        while (current != null)
        {
            hasil += $"{current.Value.Nama}; {current.Value.Kuantitas}{Environment.NewLine}";
            current = current.Next;
        }
        return hasil.TrimEnd();
    }

}