using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GetDateFromName
{
    /// <summary>
    /// Summary description for GetNameDayService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetNameDayService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetName(string name)
        {
             var nameToLower = name.ToLower();
            if (!string.IsNullOrEmpty(nameToLower))
            {
                var myListOfNameDays = File.ReadAllLines(@"C:\Users\jakob_000\Win14\WCF\Namnsdagar.txt");
                foreach (var nameDay in myListOfNameDays)
                {
                    var newNameDay = nameDay.ToLower();
                    if (newNameDay.Contains(nameToLower))
                    {
                        var newArray = newNameDay.Split(' ');
                        switch (newArray[1])
                        {
                            case "1":
                                newArray[1] = "Januari";
                                break;
                            case "2":
                                newArray[1] = "Februari";
                                break;
                            case "3":
                                newArray[1] = "Mars";
                                break;
                            case "4":
                                newArray[1] = "April";
                                break;
                            case "5":
                                newArray[1] = "Maj";
                                break;
                            case "6":
                                newArray[1] = "Juni";
                                break;
                            case "7":
                                newArray[1] = "Juli";
                                break;
                            case "8":
                                newArray[1] = "Augusti";
                                break;
                            case "9":
                                newArray[1] = "September";
                                break;
                            case "10":
                                newArray[1] = "Oktober";
                                break;
                            case "11":
                                newArray[1] = "November";
                                break;
                            case "12":
                                newArray[1] = "December";
                                break;
                        }
                        return newArray[0] + " " + newArray[1];
                    }
                }
            }
            else
            {
                return "No name were typed";
            }
            return "The name day could not be found";
        }
    }
}
