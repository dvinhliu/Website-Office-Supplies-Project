﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VanPhongPham.Models
{
    public class OrderDetailViewModel
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public bool isReviewed { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
    }
}