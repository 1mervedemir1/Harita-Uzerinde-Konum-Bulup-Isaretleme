using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class MahalleController : Controller
    {
        // GET: Mahalle
        public ActionResult Index()
        {
            return View();
        }
       
        public JsonResult Get()
        {
            List<Mahalle> _mahalleList;

            try
            {
                webApplicationEntities7 _entity = new webApplicationEntities7();


                _mahalleList = _entity.Mahalle.ToList();
            }
            catch (Exception _ex)
            {
                _mahalleList = new List<Mahalle>();
            }

            return Json(_mahalleList, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult Add(Mahalle _mahalle)
        {
            var _result = false;

            try
            {
                
                _mahalle.Koordinatlar = _mahalle.Koordinatlar.Substring(0, _mahalle.Koordinatlar.Length - 1);
                webApplicationEntities7 _entity = new webApplicationEntities7();

                _entity.Mahalle.Add(_mahalle);

                _entity.SaveChanges();

                _result = true;
            }
            catch (Exception _ex)
            {

            }

            return Json(_result, JsonRequestBehavior.AllowGet);
        }
    }
}