using Microsoft.AspNetCore.Mvc;
using PlantShop.Data;
using PlantShop.Data.Services;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCategories = await _service.GetAll();
            return View(allCategories);
        }

        //GET: CATEGORIES/CREATE 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Icon,Description")] Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            await _service.Add(category);
            return RedirectToAction(nameof(Index));
        }

        //GET: CATEGORIES/DESCRIPTION/1

        public async Task<IActionResult> Edit(int id)
        {
            var categoryDescription = await _service.GetById(id);

            if (categoryDescription == null) return View("Empty");
            return View(categoryDescription);
        }
    }
}
