using Microsoft.EntityFrameworkCore;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(n => n.Id == id);
            _context.Categories.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Category> GetById(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var result = await _context.Categories.ToListAsync();
            return result;
        }

        public async Task<Category> Update(int id, Category newCategory)
        {
            _context.Update(newCategory);
            await _context.SaveChangesAsync();
            return newCategory;
        }
    }
}
