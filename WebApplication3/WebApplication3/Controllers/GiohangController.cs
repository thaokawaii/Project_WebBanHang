using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GiohangController : Controller
    {
        // GET: Giohang
        QLBHDataContext db = new QLBHDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public List<GioHang> laygiohang()
        {
            List<GioHang> lstGH = Session["Giohang"] as List<GioHang>;
            if (lstGH == null)
            {
                lstGH = new List<GioHang>();
                Session["Giohang"] = lstGH;
            }
            return lstGH;
        }
        public ActionResult themGH(int maSP, string strURL)
        {
            List<GioHang> lstGH = laygiohang();
            GioHang sp = lstGH.Find(n => n.masp == maSP);
            if (sp == null)
            {
                sp = new GioHang(maSP);
                lstGH.Add(sp);
                return Redirect(strURL);
            }
            else
            {
                sp.soluong++;
                return Redirect(strURL);
            }
        }

        public int TongSL()
        {
            int Tong = 0;
            List<GioHang> lstGH = Session["Giohang"] as List<GioHang>;
            if (lstGH != null)
            {
                Tong = lstGH.Sum(n => n.soluong);
            }
            return Tong;
        }
        private double TongTien()
        {
            double Tong = 0;
            List<GioHang> lstGH = Session["Giohang"] as List<GioHang>;
            if (lstGH != null)
            {
                Tong = lstGH.Sum(n => n.ThanhTien);
            }
            return Tong;

        }
        public ActionResult GioHang()
        {
            List<GioHang> lstGH = laygiohang();
            if (lstGH.Count == 0)
            {
                return RedirectToAction("Index", "TrangChu");
            }
            ViewBag.TongSL = TongSL();
            ViewBag.TongTien = TongTien();
            return View(lstGH);
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.TongSL = TongSL();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
        public ActionResult Xoa(int id)
        {
            List<GioHang> lstGH = laygiohang();
            GioHang sp = lstGH.SingleOrDefault(n => n.masp == id);
            if (sp != null)
            {
                lstGH.RemoveAll(n => n.masp == id);
                return RedirectToAction("GioHang");
            }
            if (lstGH.Count == 0)
            {
                return RedirectToAction("Index", "TrangChu");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult CapNhat(int id, FormCollection f)
        {

            List<GioHang> lstGH = laygiohang();
            GioHang sp = lstGH.SingleOrDefault(n => n.masp == id);
            if (sp != null)
            {
                sp.soluong = int.Parse(f["txtSL"].ToString());

            }
            return RedirectToAction("GioHang");
        }
        public ActionResult xoaALL()
        {
            List<GioHang> lstGH = laygiohang();
            lstGH.Clear();
            return RedirectToAction("Index", "TrangChu");
        }
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "User");
            }
            if (Session["Giohang"] == null) {
                return RedirectToAction("Index", "TrangChu");

            }
            List<GioHang> lstGH = laygiohang();
            ViewBag.TongSL = TongSL();
            ViewBag.TongTien = TongTien();
            return View(lstGH);
         }
        public ActionResult DatHang(FormCollection collection)
        {
            DONDATHANG ddh = new DONDATHANG();
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];
            List<GioHang> gh = laygiohang();
            ddh.MAKH = kh.MAKH;
            ddh.NGAYDH = DateTime.Now;
            var ngaygiao = string.Format("{0:MM/dd/yyyy}", collection["NGAYGIAO"]);
            ddh.NGAYGIAO = DateTime.Parse(ngaygiao);
            ddh.TINHTRANG ="Đang giao";
            ddh.DATHANHTOAN = null;
            db.DONDATHANGs.InsertOnSubmit(ddh);
            db.SubmitChanges();
            foreach(var item in gh)
            {
                CTDONHANG ctdh = new CTDONHANG();
                ctdh.SODH = ddh.SODH;
                ctdh.MASP = item.masp;
                ctdh.SOLUONG = item.soluong;
                ctdh.DONGIA = (decimal)item.dongia;
                db.CTDONHANGs.InsertOnSubmit(ctdh);

            }
            db.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("XacNhanDH", "Giohang");
        }
        public ActionResult XacNhan()
        {
            return View();
        }
        public ActionResult XacNhanDH()
        {
            return View();
        }
        public RedirectToRouteResult RemoveALL()
        {
            List<GioHang> shoppingCart = Session["Giohang"] as List<GioHang>;
            shoppingCart.Clear();
            return RedirectToAction("GioHang");
        }
    }
}