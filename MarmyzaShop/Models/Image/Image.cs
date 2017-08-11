﻿using MarmyzaShop.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MarmyzaShop.Models.Image
{
    public class Image : Entity
    {
        public Image()
        {
            Products = new List<Product.Product>();
        }
        public string Data { get; set; }

        public string Key { get; set; }

        public Product.Product Product { get; set; }
        [ForeignKey("Product")]
        public Guid? ProductId { get; set; }

        public virtual ICollection<Product.Product> Products { get; set; }
    }
}