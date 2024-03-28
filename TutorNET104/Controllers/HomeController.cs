using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using TutorNET104.Data;
using TutorNET104.Models;

namespace TutorNET104.Controllers
{
	public class HomeController : Controller
	{
		// Khai báo DbContext
		DEMOCODE1STContext _context;

		public HomeController(ILogger<HomeController> logger)
		{
			_context = new DEMOCODE1STContext();
		}

		public IActionResult Login()
		{
            return View();
		}
		[HttpPost]
		public IActionResult Login(string email, string sdt) // Su ly DB dang nhap
		{
            // Kiem tra xem thong tin nhap vao co trung khop voi doi tuong trong Db ko?

            var account = _context.KhachHangs.ToList();
			// Lay ra thong tin account
			var acc = account.FirstOrDefault(a => a.Email == email && a.Sdt == sdt);
			// Kiem tra lay du lieu
			if (acc != null)
			{
				TempData["login"] = email;
				return RedirectToAction("Index");
			}
			else
			{
                return View();
			}

		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

	}
}