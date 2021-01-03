using System.Linq;

namespace EntityFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ButcherContext())
            {
                /*var goodCustomers = context.Customers
                    //inner join
                    .Include(c => c.Orders)
                    .Where(c => c.Orders.Any(o => o.IsCancelled == true))
                    .ToList();*/

                /*var orders = context.Orders
                    //the first order that was cancelled
                    //firstOrDefault returns null if no elements match the expression
                    //first returns an error if no element matches the expression
                    .FirstOrDefault(o => o.IsCancelled == true);*/

                var orders = context.Orders
                    .OrderBy(o => o.Id)
                    //the first order that was cancelled
                    //firstOrDefault returns null if no elements match the expression
                    //first returns an error if no element matches the expression
                    .LastOrDefault(o => o.IsCancelled == true);

                var customerIds = context.Customers
                    .Where(c => c.Age > 40)
                    .Select(c => c.Id)
                    .ToArray();

                var customerNames = context.Orders
                    .Select(o => o.Customer.FirstName)
                    .Distinct()
                    .ToList();

                System.Console.WriteLine();
            }
        }
    }
}
