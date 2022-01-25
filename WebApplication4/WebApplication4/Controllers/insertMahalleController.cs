//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace WebApplication4.Controllers
//{
//    public class insertMahalleController : Controller
//    {

//        // GET: insertMahalle
//        public ActionResult Index()
//        {
//            return View();
//        }
//        public JsonResult Get()
//        {
//            List<Mahalle> mahalle_;
//            string BaglantiAdresi = @"Data Source=LAPTOP-3BAQ1I7Q\SQLEXPRESS;Initial Catalog=webApplication;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
//            SqlConnection Baglanti = new SqlConnection(BaglantiAdresi);
//            Baglanti.Open();

//            using (var _command = Baglanti.CreateCommand())
//            {
//                _command.CommandText = "insert into Mahalle values ('mahalle_kodu'/*,'mahalle_adi','koordinatlar'*/) ";

//                DataTable dataTable = new DataTable();
//                dataTable.Load(_command.ExecuteReader());

//                mahalle_ = dataTable.AsEnumerable().Select(x => new Mahalle
//                {
//                    mahalle_kodu = Convert.ToInt32(x["mahalle_kodu"]),
//                    //mahalle_adi = x["mahalle_adi"].ToString(),
//                    //koordinatlar = x["koordinatlar"].ToString(),
//                }).
//                ToList();
//            }
//            return Json(mahalle_, JsonRequestBehavior.AllowGet);
//        }
//    }
//}