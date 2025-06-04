using System.Collections.Generic;
using System.Windows.Forms;  // Do MessageBox

public class Ekwipunek<T>
{
    private List<T> items = new List<T>();

    public void Dodaj(T item)
    {
        items.Add(item);
    }

    public bool Usun(T item)
    {
        return items.Remove(item);
    }

    public List<T> PobierzWszystkie()
    {
        return new List<T>(items);
    }

    public void PokazWszystkie()
    {
        if (items.Count == 0)
        {
            MessageBox.Show("Ekwipunek jest pusty.", "Informacja");
            return;
        }

        string tekst = "Ekwipunek zawiera:\n";
        foreach (var item in items)
        {
            tekst += item.ToString() + "\n";
        }

        MessageBox.Show(tekst, "Zawartość ekwipunku");
    }
}
