using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class methodman
    {
        //Sorting method to ask for user input.
        public static string Read( string input)
        {
            string val = " "; // Start with empty value for input
            string vvStr = Console.ReadLine();
        return val; 
        } //Return value
        public static int[][] fileJag(int[][] jaggedarray, string nuInput)// Create a new input for the jagged array for the file.csv
        {

            //https://regexlib.com/REDetails.aspx?regexp_id=345&AspxAutoDetectCookieSupport=1 used this to filter file paths
            //https://stackoverflow.com/questions/6416065/c-sharp-regex-for-file-paths-e-g-c-test-test-exe also used this to determine file paths
            string file = @"(^([a-z]|[A-Z]):(?=\\(?![\0-\37<>:""/\\|?*])|\/(?![\0-\37<>:""/\\|?*])|$)|^\\(?=[\\\/][^\0-\37<>:""    /\\|?*]+)|^(?=(\\|\/)$)|^\.(?=(\\|\/)$)|^\.\.(?=(\\|\/)$)|^(?=(\\|\/)[^\0-\37<>:""/\\|?*]+)|^\.(?=(\\|\/)[^\0-\37<>:""  /\\|?*]+)|^\.\.(?=(\\|\/)[^\0-\37<>:""/\\|?*]+))((\\|\/)[^\0-\37<>:""/\\|?*]+|(\\|\/)$)*()$";
         
           
        }
    }
}
