using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantShop.Data;
using PlantShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Controllers
{
    public class PlantsController : Controller
    {
        private readonly IPlantService _service;

        public PlantsController(IPlantService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPlants = await _service.GetAll();
            return View(allPlants);
        }

        //GET: PLANTS/DESCRIPTION

        public async Task<IActionResult> Description(int id)
        {
            var plantDescription = await _service.GetPlantById(id);
            return View(plantDescription);
        }
    }
}