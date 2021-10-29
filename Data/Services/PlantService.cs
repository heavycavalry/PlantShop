using Microsoft.EntityFrameworkCore;
using PlantShop.Data.Base;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Data.Services
{
    public class PlantService : EntityBaseRepository<Plant>, IPlantService
    {
        private readonly AppDbContext _context;
        public PlantService(AppDbContext context) : base(context)
        {
            _context = context;

        }

        public async Task<Plant> GetPlantById(int id)
        {
            var plantDetails = _context.Plants
                .Include(p => p.Plants_Categories).ThenInclude(c => c.Category)
                 .FirstOrDefaultAsync(i => i.Id == id);

            return await plantDetails;
        }
    }
}
