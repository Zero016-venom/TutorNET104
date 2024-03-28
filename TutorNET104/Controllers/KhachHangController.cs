using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorNET104.Data;
using TutorNET104.Models;

namespace TutorNET104.Controllers
{
    public class KhachHangController : Controller
    {
        DEMOCODE1STContext _context;

        public KhachHangController()
        {
            _context = new DEMOCODE1STContext();
        }

        // GET: KhachHangController
        public ActionResult Index()
        {
            var khachHangs = _context.KhachHangs.ToList();
            return View(khachHangs);
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(string sdt)
        {
            var khachHang = _context.KhachHangs.ToList().FirstOrDefault(a=>a.Sdt == sdt);

            return View(khachHang);
        }

        // GET: KhachHangController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Add(khachHang);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Content("Them that bai");
            }
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KhachHangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, KhachHang khachHang)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHangController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KhachHangController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
