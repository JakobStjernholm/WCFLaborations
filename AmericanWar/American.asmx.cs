using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AmericanWar
{
    /// <summary>
    /// Summary description for American
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class American : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> CheckAmericanWar(string year)
        {
            var array = File.ReadAllLines(@"C:\Users\jakob_000\Win14\AmerikanskaInbördeskriget.txt");
            var warsToShow = new List<string>();
            foreach (var s in array)
            {
                if (s.Contains(year))
                {
                    warsToShow.Add(s);
                }

            }

            return warsToShow;
        }
    }
}
