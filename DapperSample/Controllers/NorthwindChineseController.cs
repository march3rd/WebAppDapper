using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using Dapper;
using NorthwindChineseMapping;

namespace WebApplication1.Controllers
{
    public class NorthwindChineseController : Controller
    {
        // GET: NorthwindChinese
        public ActionResult Index()
        {
            ViewBag.m1 = "訊息1";
            ViewBag.m2 = "訊息2";
            ViewBag.IsEnabled = true;



            // 這裡要用 Dapper 來回傳資料，並利用強型別的方式傳到 View 中。
            List<Employee> mydata = new List<Employee>();

            string cnStr = @"Data Source=.\SQLExpress; Initial Catalog=NorthwindChinese; User ID=sa; Password=duekldj;";
            string sql = "select * from employees";
            using (var cn = new SqlConnection(cnStr))
            {
                mydata = cn.Query<Employee>(sql).ToList();
                return View(mydata);
            }
        }
    }
}