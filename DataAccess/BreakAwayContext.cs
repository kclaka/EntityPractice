using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Model;

namespace DataAccess
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
    }
}
