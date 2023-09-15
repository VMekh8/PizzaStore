using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Models
{
    public class PizzaContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}