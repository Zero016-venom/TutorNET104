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
        public ActionResult Create(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Add(khachHang);
                _context.SaveChanges();

                return RedirectToAction("Index", "KhachHang"); 
            }
            catch
            {
                return Content("Them that bai");
            }
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(string sdt)
        {
            var editKH = _context.KhachHangs.Find(sdt);
            return View(editKH);
        }

        // POST: KhachHangController/Edit/5
        [HttpPost]
        public ActionResult Edit(KhachHang khachHang) //Action nay thuc hien viec sua theo data nhap vao
        {
            try
            {
                var editKH = _context.KhachHangs.Find(khachHang.Sdt); // TIm chinh xac toi doi tuong can sua
                editKH.Email = khachHang.Email;
                editKH.DiaChi = khachHang.DiaChi;
                editKH.Status = khachHang.Status;
                editKH.Point = khachHang.Point;
                editKH.Ten = khachHang.Ten;

                _context.KhachHangs.Update(editKH);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: KhachHangController/Delete/5
        public ActionResult Delete(string sdt)
        {
            var deleteKH = _context.KhachHangs.Find(sdt);
            _context.KhachHangs.Remove(deleteKH);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: KhachHangController/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
