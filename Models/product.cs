using System;
using System.ComponentModel.DataAnnotations;

namespace ProductCSAPI
{
    public class Products
    {
        public int prodID { get; set; }

        public string prodName { get; set; }

        public string prodCode { get; set; }

        public string prodDescription { get; set; }
    }
}
