using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCourse.BillWeb.Models;

namespace UdemyCourse.BillWeb.ViewModels
{
    public class BillViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public PaymentType PaymentType { get; set; }
        [Display(Name ="Item List")]
        public int ItemId { get; set; }
        public List<SelectListItem> ItemList { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public decimal Total { get; set; }
        public decimal GrandTotal { get; set; }
        public List<ItemList> Items { get; set; } = new List<ItemList>();
    }
}
