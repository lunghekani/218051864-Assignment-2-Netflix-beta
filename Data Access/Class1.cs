using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Access
{
    public class Class1
    {
    }
    public class clsDataLayer  {
        public StreamReader CreateLink()
        {

            var stream = new StreamReader(@"../../netflix_titles.csv"); // setting the connection to the CSV file

            return stream;
        }
    }

}
