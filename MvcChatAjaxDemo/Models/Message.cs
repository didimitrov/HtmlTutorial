using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcChatAjaxDemo.Models
{
    public class Message
    {
        public string  Name { get; set; }
        public DateTime Time { get; set; }
        public string Content { get; set; }
    }
}