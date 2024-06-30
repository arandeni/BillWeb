using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.BillWeb.Models
{
    public class Item
    {
        public int Id { get; set; }
        //[Required]
        public required string Name { get; set; }
        //[Required]
        public required decimal Price { get; set; }
    }
}
