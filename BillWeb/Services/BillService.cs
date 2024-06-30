using System;

using UdemyCourse.BillWeb.Data;
using UdemyCourse.BillWeb.Models;

namespace UdemyCourse.BillWeb.Services
{
    public class BillService : IBillService
    {
        private ApplicationDbContext _context;

        public BillService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void AddBill(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }

        public void AddBillDetails(List<BillDetails> details) 
        {
            _context.BillDetails.AddRange(details);
            _context.SaveChanges();
        }
    }
}
