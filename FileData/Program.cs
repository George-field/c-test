using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            functionality functionality = new functionality();
            functionality.GetFileData(functionality.GetType(), string[0]args);
        }
    }

    public  class functionality{
        //test value function will test to see if there is a -v, --v, /v,. -s, --s, /s in the filename
        //function is used in the GetFileDetails function
        public String Testvalue(String file)
        {
            string result = null;
            if (file.Contains("-v") || file.Contains("--v")||file.Contains("/v"))
            {
                result = "v";
            }else if(file.Contains("-s") || file.Contains("--s") || file.Contains("/s"))
            {
                result = "s";
            }
            else
            {
                result = "invalid";
            }
            return result;
        }
        //function returns the values of size and version number based upon the input from filename
        public String GetFileData(Func<string>TestValue,String Filename)
        {
            FileDetails fileDetails = new FileDetails();
            String returnvalue = null;

            if(TestValue.Equals("v"))
            {
                returnvalue = fileDetails.Version(Filename);
               
            }else if (TestValue.Equals("s"))
            {
                returnvalue = fileDetails.Size(Filename).ToString();
            }
            return returnvalue;

        }
    }
}
