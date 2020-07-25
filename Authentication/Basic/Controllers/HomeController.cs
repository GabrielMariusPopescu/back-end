using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Authorize]
		public IActionResult Secret()
		{
			return View();
		}


		public IActionResult Authenticate()
		{
			var grandmaClaims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, "Gabriel"),
				new Claim(ClaimTypes.Email, "gabymarius@hotmail.com"),
				new Claim("Grandma.Says", "Very nice boy!")
			};

			var cnpClaims = new List<Claim>
			{
				new Claim(ClaimTypes.Country, "Romania"),
				new Claim(ClaimTypes.SerialNumber, "00000000")
			};

			var grandmaIdentity = new ClaimsIdentity(grandmaClaims, "Grandma Identity");

			var licenseIdentity = new ClaimsIdentity(cnpClaims, "License Identity");

			var userPrincipal = new ClaimsPrincipal(new[]
			{
				grandmaIdentity,
				licenseIdentity
			});

			HttpContext.SignInAsync(userPrincipal);

			return RedirectToAction("Index");
		}
	}
}
