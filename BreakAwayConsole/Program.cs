using System;
using Model;
using DataAccess;


namespace BreakAwayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertDestination();
        }

        private static void InsertDestination()
        {
            var destination = new Destination()
            {
                Country = "Nigeria",
                Description = "African Country with Crude oil",
                Name = "Lagos"
            };

            using (var context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
            

        }
    }
}
