using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.BillWeb.ViewModels
{
    public class ItemList
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public decimal itemPrice { get; set; }
        public int itemQuantity { get; set; }
        public decimal itemDiscount { get; set; }
        public decimal itemTotal { get; set; }
    }
}
