﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace stjernholm.nu.ASMX_Demo
{
    /// <summary>
    /// Summary description for Weather
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Weather : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            var rnd = new Random();
            var list = new List<string> {"Cloud", "Sun", "Rain", "Snow"};
            return "Hello World " + list[rnd.Next(1,4)];
        }
    }
}
