using Domain.Entities;

namespace Presentation.View
{
    public sealed class MenuView
    {
        public void ClearLastConsoleLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        public void DisplayMenu(List<Product> products)
        {
            Console.Clear();
            Console.WriteLine("===============Produkty===============");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name}: {products[i].Price} PLN");
            }
            Console.WriteLine();
            Console.WriteLine("Wybierz produkt wpisując jego numer oraz literę \"a\" aby dodać go do zamówienia, lub \"r\" aby usunąć."); 
            Console.WriteLine("Potwierdź wybór wciskając Enter");
            Console.WriteLine("Wciśnij ESC aby wyjść z aplikacji");
            Console.WriteLine("Wciśnij ALT aby zobaczyć zamówienie");
        }
    }
}
