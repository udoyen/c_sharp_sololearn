using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class WriteToFile
    {
        public void fileWrite()
        {
            try
            {
                string str = "Some text";
                File.WriteAllText("C:\Users\ekojo\Documents\sample-doc", str);
                
            }
            catch (Exception e)
            {

                Console.WriteLine("File write error: " + e.Message);
            }
        }
    }
}
