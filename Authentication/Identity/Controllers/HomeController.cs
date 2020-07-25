using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
	public class HomeController : Controller
	{
		public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signedInManager)
		{
			this.userManager = userManager;
			this.signedInManager = signedInManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		[Authorize]
		public IActionResult Secret()
		{
			return View();
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(string username, string password)
		{
			var user = await userManager.FindByNameAsync(username);

			if (user != null)
			{
				var signInResult = await signedInManager.PasswordSignInAsync(username, password, false, false);
				if (signInResult.Succeeded)
				{
					return RedirectToAction("Index");
				}
			}

			return BadRequest("There is a problem with sign in using your username and/or password.");
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(string username, string password)
		{
			var user = new IdentityUser
			{
				UserName = username
			};

			var result = await userManager.CreateAsync(user, password);

			if (result.Succeeded)
			{
				return RedirectToAction("Login");
			}

			return BadRequest("There is a problem with creating your user.");
		}

		public async Task<IActionResult> LogOut()
		{
			await signedInManager.SignOutAsync();
			return RedirectToAction("Index");
		}

		//

		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signedInManager;
	}
}
