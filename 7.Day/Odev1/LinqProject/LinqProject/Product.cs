using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public short UnitInStock { get; set; }
    }
}
