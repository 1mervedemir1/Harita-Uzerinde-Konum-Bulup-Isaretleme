using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        //string BaglantiAdresi = @"Data Source=LAPTOP-3BAQ1I7Q\SQLEXPRESS;Initial Catalog=webApplication;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        //SqlConnection Baglanti = new SqlConnection(BaglantiAdresi);




        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
     }
}