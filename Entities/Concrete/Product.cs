using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity //başa yazılan public bu class'a diğer katmanlarda ulaşabilsin demek.
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short  UnitsInStock { get; set; } //short int in bir küçüğü

        public decimal UnitPrice { get; set; }
    }
}
