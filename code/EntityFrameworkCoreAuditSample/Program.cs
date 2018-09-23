namespace EntityFrameworkCoreAuditSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SampleContext())
            {
                // Insert a row
                var customer = new Customer();
                customer.FirstName = "John";
                customer.LastName = "doe";
                context.Customers.Add(customer);
                context.SaveChangesAsync().Wait();

                // Update the first customer
                customer.LastName = "Doe";
                context.SaveChangesAsync().Wait();

                // Delete the customer
                context.Customers.Remove(customer);
                context.SaveChangesAsync().Wait();
            }
        }
    }
}
