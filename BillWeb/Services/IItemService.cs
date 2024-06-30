using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCourse.BillWeb.Models;

namespace UdemyCourse.BillWeb.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAll();
        Task<Item> GetbyId(int id);
        Task SaveItem(Item item);
        Task DeleteItem(int id);
        Task UpdateItem(Item item);
    }
}
