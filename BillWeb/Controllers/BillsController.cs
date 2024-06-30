using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UdemyCourse.BillWeb.Models;
using UdemyCourse.BillWeb.Services;
using UdemyCourse.BillWeb.ViewModels;

namespace UdemyCourse.BillWeb.Controllers
{
    public class BillsController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ICustomerService _customerService;
        private readonly IBillService _billService;

        public BillsController(IItemService itemService, ICustomerService customerService, IBillService billService)
        {
            _itemService = itemService;
            _customerService = customerService;
            _billService = billService;
        }

        public IActionResult SaveItems(BillViewModel vm) 
        {
            Customer customer = new Customer();
            customer.Name = vm.CustomerName;
            _customerService.AddCustomer(customer);

            List<BillDetails> billDetails = new List<BillDetails>();
            foreach (var item in vm.Items) 
            {
                billDetails.Add(new BillDetails()
                {
                    ItemId = item.itemId,
                    ItemName = item.itemName,
                    CustomerId = customer.Id,
                    Price = item.itemPrice,
                    Discount = item.itemDiscount,
                    Quantity = item.itemQuantity,
                    Total = item.itemTotal
                });
            }
            _billService.AddBillDetails(billDetails);

            Bill bill = new Bill();
            bill.CustomerId = customer.Id;
            bill.BillDate = DateTime.Now;
            bill.TotalAmount = vm.GrandTotal;
            _billService.AddBill(bill);

            BillRecieptViewModel reciept = new BillRecieptViewModel();
            reciept.BillNumber = bill.Id;
            reciept.BillDetails = billDetails;
            reciept.FromAddress = "my restuarent";
            reciept.CustomerName = customer.Name;
            reciept.TotalAmount = vm.GrandTotal;

            return PartialView("_bill", reciept);
            //return View();
        }

        public async Task<IActionResult> Create()
        {
            var Items = await _itemService.GetAll();
            ViewBag.ItemsList = new SelectList(Items, "Id", "Name");
            return View();
        }

        public async Task<JsonResult> GetPrice(int id) 
        { 
            var item = await _itemService.GetbyId(id);
            var price = item.Price;
            return Json(price);
        }
    }
}
