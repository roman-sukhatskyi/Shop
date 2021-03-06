﻿using MarmyzaShop.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MarmyzaShop.Models.Product
{
    public class Product : Entity
    {
        public Product()
        {
            Images = new List<Image.Image>();
        }
        public int? Code { get; set; }

        public decimal? Price { get; set; }

        public string Description { get; set; }

        public ProductCategory Category { get; set; }
        [ForeignKey("Category")]
        public Guid? CategoryId { get; set; }

        public virtual ICollection<OrderProduct.OrderProduct> OrderProducts { get; set; }

        public virtual ICollection<Image.Image> Images { get; set; }
    }
}
