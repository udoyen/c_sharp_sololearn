using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class MyFile
    {
        public void fileRead()
        {
            //path to file
            string fpath = @"C:\Users\ekojo\Documents\sample-doc\test.txt";

            //check if file exists
            if (File.Exists(fpath))
            {
                try
                {                   
                    string txt = File.ReadAllText(fpath);
                    Console.WriteLine(txt);

                }
                catch (FieldAccessException e)
                {
                    Console.WriteLine("File write error: " + e.Message);

                }
                catch (Exception e)
                {

                    Console.WriteLine("File write error: " + e.Message);
                }
            }
            else
            {
                throw new FileNotFoundException("File not found!", fpath);
            }

        }

        public void fileWrite()
        {
            try
            {
                string str = "Some text";
                string fpath = @"C:\Users\ekojo\Documents\sample-doc\test.txt";
                File.WriteAllText(fpath, str);
               
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine("File write error: " + e.Message);

            }
            catch (Exception m)
            {
                Console.WriteLine("File write error: " + m.Message);
            }
        }
    }
}
