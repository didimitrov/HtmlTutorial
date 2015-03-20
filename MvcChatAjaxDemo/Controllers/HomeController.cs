using MvcChatAjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcChatAjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StartChat(string name)
        {
            Session["user"] = name;
            return PartialView("Chat");
        }
        public ActionResult Chat(string msg)
        {
            var message = new Message()
            {
                Name = (string)Session["user"],
                Time = DateTime.Now,
                Content = msg
                
            };
            
            return PartialView("Message", message);
        }
    }
}