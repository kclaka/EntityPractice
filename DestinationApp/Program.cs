using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace DestinationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new MusicContext())
            {
                
                context.Albums.Add(new Album() { Price = 9.99m, Title = "Wish" });
                var count = context.Albums.Count();
                Console.WriteLine(count);

                
                context.SaveChanges();
                Console.WriteLine(count);
                Console.ReadLine();
            }
            
        }

        
    }


    public class Album
    {
        public Album()
        {
            
        }

        public int Albumid { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class Destination
    {
        public int DestinationId { get; set; }
        public string  Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }

        public List<Lodging> Lodgings { get; set; }
    }

    public class Lodging
    {
        public int LodgingId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }

        public Destination Destination { get; set; }
    }


    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }

    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
    }

}
