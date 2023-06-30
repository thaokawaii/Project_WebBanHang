using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class GioHang
    {
        QLBHDataContext db = new QLBHDataContext();
        public int masp { get; set; }
        public string Tensp { get; set; }
        public string anh { get; set; }
        public float dongia { get; set; }
        public int soluong { get; set; }
        public double ThanhTien
        {
            get { return soluong * dongia; }
        }
        public GioHang(int maSP)
        {
            masp = maSP;
            SANPHAM sp = db.SANPHAMs.Single(n => n.MASP == masp);
            Tensp = sp.TENSP;
            anh = sp.ANH;
            dongia = float.Parse(sp.DONGIA.ToString());
            soluong = 1;


        }
       
    }
}