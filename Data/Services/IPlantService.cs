﻿using PlantShop.Data.Base;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Data.Services
{
    public interface IPlantService : IEntityBaseRepository<Plant>
    {
        Task<Plant> GetPlantById(int id);

    }
}