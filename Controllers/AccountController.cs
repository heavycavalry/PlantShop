using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Data;
using PlantShop.Data.ViewModels;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;
		private readonly AppDbContext _context;

		public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext context)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_context = context;

		}
		public IActionResult Login()
		{

			var response = new Login();
			return View(response);
		}
	}
}
