﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace Project.Domain.Order
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public float Value { get; set; }
        public float Total { get; set; }
        public IEnumerable<SelectListItem> Customers { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }
    }
}