using Microsoft.AspNetCore.Mvc;
using UdemyCourse.BillWeb.Models;
using UdemyCourse.BillWeb.Services;
using UdemyCourse.BillWeb.ViewModels;

namespace UdemyCourse.BillWeb.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task<IActionResult> Index()
        {
            List<ItemViewModel> list = new List<ItemViewModel>();
            var items = await _itemService.GetAll();
            //foreach (var item in items) { }
            list.AddRange(items.Select(item => new ItemViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price
            }));
            return View(list);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateItemViewModel createViewModel) 
        {
            var model = new Item
            {
                Name = createViewModel.Name,
                Price = createViewModel.Price
            };
            await _itemService.SaveItem(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _itemService.GetbyId(id);
            var vm = new ItemViewModel 
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ItemViewModel itemViewModel)
        {
            var model = new Item
            {
                Id = itemViewModel.Id,
                Name = itemViewModel.Name,
                Price = itemViewModel.Price
            };
            await _itemService.UpdateItem(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) 
        {
            await _itemService.DeleteItem(id);
            return RedirectToAction("Index");
        }
    }
}
