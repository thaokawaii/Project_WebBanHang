using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        QLBHDataContext data = new QLBHDataContext();

        

        private List<SANPHAM> laySP(int count)
        {
            return data.SANPHAMs.OrderByDescending(a => a.NGAYCAPNHAT).Take(count).ToList();

        }
      
        public ActionResult Index()
        {
            var sp = laySP(3);
            return View(sp);
        }

        public ActionResult NHASX()
        {
            var loai = (from s in data.NHACUNGCAPs select s).ToList();

            return PartialView(loai);

        }
        public ActionResult ALLSP()
        {
            var SP = (from s in data.SANPHAMs select s).ToList();

            return PartialView(SP);

        }
        public ActionResult SPTheoNCC(int id)
        {
            return View(data.SANPHAMs.Where(t => t.MANCC == id).ToList());
        }
        public ActionResult Detail(int id)
        {

           SANPHAM s = new SANPHAM();
            s = data.SANPHAMs.Single(t => t.MASP == id);
            if (s == null)
                return HttpNotFound();
            return View(s);
        }
        public ActionResult Tim(string id)
        {
            var links = from l in data.SANPHAMs
                        select l;

            if (!String.IsNullOrEmpty(id))
            {
                links = links.Where(s => s.TENSP.Contains(id));
            }

            return View(links);
        }

        //public ActionResult Detail(int id)
        //{
        //    var sp = from s in data.SANPHAMs where s.MASP == id select s;
        //    return View(sp.Single());
        // }
    }
}