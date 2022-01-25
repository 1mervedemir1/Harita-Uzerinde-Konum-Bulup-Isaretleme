using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    
    public class KapiController : Controller
    {
        // GET: Kapi
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get()
        {
            List<Kapi> kapi_list;

            try
            {
                webApplicationEntities7 entity = new webApplicationEntities7();

                kapi_list = entity.Kapi.ToList();
            }
            catch(Exception ex)
            {
                kapi_list = new List<Kapi>();
            }
            return Json(kapi_list,JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(Kapi kapi_)
        {
            var result = false;

            try
            {
               
                webApplicationEntities7 entity = new webApplicationEntities7();
                
                entity.Kapi.Add(kapi_);
                
                entity.SaveChanges();

                result = true;
            }
            catch(Exception ex)
            {

            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}