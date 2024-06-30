using System;
using UdemyCourse.BillWeb.Models;

namespace UdemyCourse.BillWeb.Services
{
    public interface IBillService
    {
        void AddBillDetails(List<BillDetails> details);
        void AddBill(Bill bill);
    }
}
