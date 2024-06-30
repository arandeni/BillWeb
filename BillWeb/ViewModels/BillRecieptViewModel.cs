using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCourse.BillWeb.Models;

namespace UdemyCourse.BillWeb.ViewModels
{
    public class BillRecieptViewModel
    {
        public int BillNumber { get; set; }
        public string CustomerName { get; set; }
        public List<BillDetails> BillDetails { get; set; }
        public decimal TotalAmount { get; set; }
        public string FromAddress { get; set; }
    }
}
