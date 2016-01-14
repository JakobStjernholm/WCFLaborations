using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RepublicanRepresentens
{
    /// <summary>
    /// Summary description for CandidatesAmericaRepublican
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CandidatesAmericaRepublican : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetAllYears()
        {
            var listOfAllYears = new List<string>();
            var listOfAllCandidates = File.ReadAllLines(@"C:\Users\jakob_000\Win14\RepublikanskaKandidater.txt");
            foreach (var candidate in listOfAllCandidates)
            {
                var oneYearWithCandidate = candidate.Split(' ');
                listOfAllYears.Add(oneYearWithCandidate[0]);
            }

            return listOfAllYears;
        }
        [WebMethod]
        public List<string> GetAllCandidates(string fromYear,string tooYear)
        {
            var intFromYear = int.Parse(fromYear);
            var intToYear = int.Parse(tooYear);
            var listOfAll = new List<string>();
            var listOfAllCandidates = File.ReadAllLines(@"C:\Users\jakob_000\Win14\RepublikanskaKandidater.txt");
            foreach (var candidate in listOfAllCandidates)
            {
                
                var oneYearWithCandidate = candidate.Split(' ');
                var year = int.Parse(oneYearWithCandidate[0]);
                if (year >= intFromYear && year <= intToYear)
                {
                    listOfAll.Add(candidate);
                }
            }

            return listOfAll;
        }
    }
}
