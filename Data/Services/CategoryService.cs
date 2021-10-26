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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetById(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Category Update(int id, Category newCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var result = await _context.Categories.ToListAsync();
            return result;
        }
    }
}
