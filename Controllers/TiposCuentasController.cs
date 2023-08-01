using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers
{
	public class TiposCuentasController : Controller
	{

		private readonly string connectionString;

		public TiposCuentasController(IConfiguration configuration)
		{
			connectionString = configuration.GetConnectionString("DefaultConnection");
		}
		
		public IActionResult Crear()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Crear(TipoCuenta tipoCuenta)
		{
			if (!ModelState.IsValid)
			{
				return View(tipoCuenta);
			}

			return View();
		}
	}
}
