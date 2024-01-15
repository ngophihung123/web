using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwââ.Models;

namespace wwââ.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        private QLBanHangQuanAoEntities3  db = new QLBanHangQuanAoEntities3(); // Thay YourDbContext bằng tên của DbContext của bạn

        public ActionResult Index()
        {
            // Lấy tất cả các loại phân loại
            var phanLoais = db.PhanLoais.ToList();

            // Truyền danh sách phân loại vào view để hiển thị
            return View(phanLoais);
        }
    }
}