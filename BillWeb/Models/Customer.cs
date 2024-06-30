using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.BillWeb.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Bill> Bills { get; set; }
        public ICollection<BillDetails> BillDetails { get; set; }
    }
}
