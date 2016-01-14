using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OscarWinner
{
    /// <summary>
    /// Summary description for OscarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OscarService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetAllYears()
        {
            var theYears = new List<string>();
            var myArray = File.ReadAllLines(@"C:\Users\jakob_000\Win14\OscarWinnerAndWhoeHeBeat.txt");
            foreach (var yearWinnerAndNominees in myArray)
            {
                var result = yearWinnerAndNominees.Replace(':', ' ').Split(' ');
                theYears.Add(result[0]);
            }
            return theYears;
        }
        [WebMethod]
        public string GetWinnerForSelectedYear(string year)
        {
            if (!string.IsNullOrEmpty(year))
            {
                var myArray = File.ReadAllLines(@"C:\Users\jakob_000\Win14\OscarWinnerAndWhoeHeBeat.txt");
                foreach (var yearWinnerAndNominees in myArray)
                {
                    if (yearWinnerAndNominees.Contains(year))
                    {
                        return yearWinnerAndNominees;
                    }
                    
                }
            }
            return "No year was selected";
        }
    }
}
