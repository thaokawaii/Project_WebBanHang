using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ADController : Controller
    {
        // GET: AD
        QLBHDataContext db = new QLBHDataContext();
        public ActionResult QLSP()
        {
            var SP = (from s in db.SANPHAMs select s).ToList();

            return View(SP);
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
 
            else
            {
                ADMIN ad = db.ADMINs.SingleOrDefault(n => n.TENDN == tendn && n.MATKHAU == matkhau);
                if(ad!=null)
                {
                    ViewBag.Thongbao = "Chúc mừng đăng nhập thành công";
                    Session["Taikhoanad"] = ad;
                    return RedirectToAction("Index", "AD");
                }    
                else
                {
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }    
            }
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MANCC = new SelectList(db.NHACUNGCAPs.ToList().OrderBy(n => n.TENNCC), "MANCC", "TENNCC");
            ViewBag.MALOAI = new SelectList(db.LOAISPs.ToList().OrderBy(n => n.TENLOAI), "MALOAI", "TENLOAI");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SANPHAM sp,HttpPostedFileBase File)
        {
            ViewBag.MANCC = new SelectList(db.NHACUNGCAPs.ToList().OrderBy(n => n.TENNCC), "MANCC", "TENNCC");
            ViewBag.MALOAI = new SelectList(db.LOAISPs.ToList().OrderBy(n => n.TENLOAI), "MALOAI", "TENLOAI");

            if (File == null)
            {
                ViewBag.Thongbao = "vui lòng chọn ảnh";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var filename = Path.GetFileName(File.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/assets/img/ao"), filename);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Ảnh đã tồn tại";
                    }
                    else
                    {
                        File.SaveAs(path);
                    }
                    sp.ANH = filename;
                    db.SANPHAMs.InsertOnSubmit(sp);
                    db.SubmitChanges();
                }
                return RedirectToAction("QLSP");
            }


        }

        public ActionResult Detail (int id)
        {
            SANPHAM sp = db.SANPHAMs.SingleOrDefault(n => n.MASP == id);
            ViewBag.MASP = sp.MASP;
            if(sp==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            SANPHAM sp = db.SANPHAMs.SingleOrDefault(n => n.MASP == id);
            ViewBag.MASP = sp.MASP;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult XacNhanXoa(int id)
        {
            SANPHAM sp = db.SANPHAMs.SingleOrDefault(n => n.MASP == id);
            ViewBag.MASP = sp.MASP;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.SANPHAMs.DeleteOnSubmit(sp);
            db.SubmitChanges();
            return RedirectToAction("QLSP");
        }
        [HttpGet]
        public ActionResult Edit( int id) 
        {
            SANPHAM sp = db.SANPHAMs.SingleOrDefault(n => n.MASP == id);
            //ViewBag.MASP = sp.MASP;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MANCC = new SelectList(db.NHACUNGCAPs.ToList().OrderBy(n => n.TENNCC), "MANCC", "TENNCC", sp.MANCC);
            ViewBag.MALOAI = new SelectList(db.LOAISPs.ToList().OrderBy(n => n.TENLOAI), "MALOAI", "TENLOAI", sp.MALOAI);
            return View(sp);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(SANPHAM sp, HttpPostedFileBase File)
        {
            ViewBag.MANCC = new SelectList(db.NHACUNGCAPs.ToList().OrderBy(n => n.TENNCC), "MANCC", "TENNCC");
            ViewBag.MALOAI = new SelectList(db.LOAISPs.ToList().OrderBy(n => n.TENLOAI), "MALOAI", "TENLOAI");

            if (File==null)
            {
                ViewBag.Thongbao = "vui lòng chọn ảnh";
                return View();
            }
            else
            {
                if(ModelState.IsValid)
                {

                    var filename = Path.GetFileName(File.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/assets/img/ao"), filename);
                    if (System.IO.File.Exists(path))
                     {
                        ViewBag.Thongbao = "Ảnh đã tồn tại";
                    }
                    else
                    {
                        File.SaveAs(path);
                    }
                    sp.ANH = filename;
                    UpdateModel(sp);
                    db.SubmitChanges();
                }
                return RedirectToAction("QLSP");
            }
            
            
        }
    }
}