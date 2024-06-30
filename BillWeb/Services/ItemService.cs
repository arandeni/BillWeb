﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCourse.BillWeb.Data;
using UdemyCourse.BillWeb.Models;

namespace UdemyCourse.BillWeb.Services
{
    public class ItemService : IItemService
    {
        private readonly ApplicationDbContext _context;

        public ItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item> GetbyId(int id)
        {
            return await _context.Items.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task SaveItem(Item item)
        {
            _context.Add(item);
            //await _context.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateItem(Item item)
        {
            _context.Items.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
