using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStore.Models
{
    public class Orders
    {

        public int Id { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public Pizza Pizza { get; set; }
        public int? ProductId { get; set; }
        public DateTime Date { get; set; }

    }
}