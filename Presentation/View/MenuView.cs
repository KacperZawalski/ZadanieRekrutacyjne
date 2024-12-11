using Domain.Entities;

namespace Presentation.View
{
    public sealed class MenuView
    {
        public void DisplayMenu(List<Product> products)
        {
            Console.Clear();
            Console.WriteLine("===============Products===============");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name}: {product.Price} PLN");
            }
            Console.WriteLine();
            Console.WriteLine("Choose product by typing number and \"a\" to add or \"r\" to remove it from order, then confirm by pressing Enter");
        }
    }
}
