using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.App_Start
{
    public class UserController : Controller
    {
        QLBHDataContext db = new QLBHDataContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DK()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DK(FormCollection collection, KHACHHANG kh)
        {
            var hoten = collection["HotenKH"];
           
            var tendb = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            var matkhaunhaplai = collection["Matkhaunhaplai"];
            var diachi = collection["Diachi"];
        
            var email = collection["Email"];
            var dienthoai = collection["Dienthoai"];
            var ngaysinh = string.Format("{0:MM/dd/yyyy}", collection["Ngaysinh"]);
            if (string.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if (string.IsNullOrEmpty(tendb))
            {
                ViewData["Loi2"] = "Phải nhập";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải nhập";
            }
            else if (string.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["Loi4"] = "Phải nhập";
            }
            if (string.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Email không được để trống";
            }
            if (string.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi5"] = "Phải nhập";
            }
            else
            {
                kh.TENKH = hoten;
                kh.TENDN = tendb;
                kh.MATKHAU = matkhau;
                kh.EMAIL = email;
                kh.DIACHI = diachi;
                kh.SDT = dienthoai;
              
                kh.NGAYSINH = DateTime.Parse(ngaysinh);
                db.KHACHHANGs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return RedirectToAction("Dangnhap");

            }
            return this.DK();
        }
        public ActionResult DangNhap(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if(string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi"] = "Phải nhập tên đăng nhập";
            }    
            else if(string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }    
            else
            {
                KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(n => n.TENDN == tendn && n.MATKHAU == matkhau);
                if (kh != null)
                {
                    ViewBag.thongbao = "Chúc mừng đăng nhập thành công";
                    Session["Taikhoan"] = kh;
                }
                else
                    ViewBag.thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }    
            return View();
        }
    }
}