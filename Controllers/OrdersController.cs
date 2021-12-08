using Microsoft.AspNetCore.Mvc;
using PlantShop.Data.Services;
using PlantShop.Data.Card;
using PlantShop.Data.ViewModels;

namespace PlantShop.Controllers
{
	public class OrdersController : Controller
	{
		private readonly IPlantService _plantService;
		private readonly ShoppingCard _shoppingCard;

		public OrdersController(IPlantService plantService, ShoppingCard shoppingCard)
		{
			_plantService = plantService;
			_shoppingCard = shoppingCard;
		}
		public IActionResult Index()
		{
			var items = _shoppingCard.GetShoppingCardItems();
			_shoppingCard.ShoppingCardItems = items;
			var response = new ShoppingCardViewModel()
			{
				ShoppingCard = _shoppingCard,
				ShoppingCardTotal = _shoppingCard.GetShoppingCardTotal()
			};
			return View(response);
		}
	}
}
