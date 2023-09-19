using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlC_
{
    public class Order
    {
        public int id { get; set; }
        public int custumerId { get; set; }
        public DateTime date { get; set; }
    }
}