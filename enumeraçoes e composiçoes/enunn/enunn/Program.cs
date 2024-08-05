using enunn.entidades;
using enunn.entidades.Enums;

namespace enunn
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1080, DateTime.Now, OrderStatus.PendingPayment);

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            int valor = (int)OrderStatus.PendingPayment;
            Console.WriteLine(valor);


        }
    }
}