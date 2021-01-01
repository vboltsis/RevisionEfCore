using System;
using System.Linq;

namespace EntityFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ButcherContext())
            {
                var orders = context.Orders
                    .ToList();

                var customers = context.Customers
                    .Take(10)
                    .ToList();

                var takis = context.Customers
                    .FirstOrDefault(c => c.FirstName == "Takis");

                takis.Age = 55;
                context.SaveChanges();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
                }

                foreach (var order in orders)
                {
                    Console.WriteLine(order.DeliveryDate);
                }
            }
        }
    }
}
