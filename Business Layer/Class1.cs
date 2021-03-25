using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Data_Access;
using System.Text.RegularExpressions;

using System.Windows.Forms;
/**
* For the brave souls who get this far: You are the chosen ones,
* 
* Regards - 218051864 LV Langa 
*/

namespace Business_Layer
{
    public class Class1
    {
    }

    public class clsMovieOperations {
        clsDataLayer objData = new clsDataLayer(); // creating an instance (object) of the Data Access Layer class 

        List<string> lstMovies = new List<string>();
        List<string> lstShows = new List<string>();


        //this metthid will populate both lists in order to show and cut down the runtime
        // runs im O(n^2) time
        public List<string> PopulateContentLists () {
            List<string> lstReleases = new List<string>();
            var stream = objData.CreateLink(); // assigning the object to a local variable
            
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine();
                //var val = line.Split(',');
                string patt = @",(\d{4}),";
                //string patst = @"(\d{3} min)|(\d{2} min)|(\d[0-2] Season)";

                foreach (var item in lstMovies)
                {
                    MatchCollection matches = Regex.Matches(item, patt);
                    foreach (Match m in matches)
                    {
                        string cleaned = m.ToString().Replace(",","");
                        
                        if (lstReleases.Contains(cleaned))
                        {

                        }
                        else
                        {
                            lstReleases.Add(cleaned);
                        }
                    }
                }
                              
             
                if (line.Contains(",Movie"))
                {
                    lstMovies.Add(line);
                }
                else {
                    lstShows.Add(line);
                }

            }
            lstReleases.Sort();
            return lstReleases;
        }
        // grabbing the years of releases
       

        //display fields on presentation layer
        public List<string> GetFromCriteria(string yr = "2020", string contenttype = "Movie" ) {
            List<string> lstOutput = new List<string>();

            string patt = @",(\d{4}),";
            if (string.Compare(contenttype, "movie", true) == 0)
            {

                // regex years 
                foreach (var item in lstMovies)
                {
                    var ripped = item.Split(',');
                    MatchCollection matches = Regex.Matches(item,patt);


                    foreach (Match m in matches)
                    {
                        lstOutput.Add(item);
                    }
                }

            }
            else { 
            
            }
            return lstOutput;
        }

    }
}
