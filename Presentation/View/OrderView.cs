using Domain.Entities;

namespace Presentation.View
{
    public sealed class OrderView
    {
        public void DisplayOrder(Order order)
        {
            Console.Clear();
            Console.WriteLine("===============Zamówienie===============");
            Console.WriteLine("Lp. Nazwa Ilość Cena Razem");
            for (int i = 0; i < order.Items.Count; i ++)
            {
                Console.WriteLine($"{i+1}. {order.Items[i].Product.Name} {order.Items[i].Amount} x {order.Items[i].Product.Price} {order.Items[i].TotalPrice}");
            }
            Console.WriteLine();
            Console.WriteLine($"Zniżka za kilka produktów: {order.GetFirstDiscount()}");
            Console.WriteLine($"Zniżka za zamówienie powyżej 5k: {order.GetSecondDiscount()}");
            Console.WriteLine($"Razem: {order.GetTotalPrice()}");
            Console.WriteLine();
            Console.WriteLine("Aby powrócić do menu wpisz #");
        }
    }
}
