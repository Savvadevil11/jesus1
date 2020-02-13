using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

 
namespace VIN_LIB
{
    public class Program
    {
        public bool CheckVIN (string[] vin)
        {
            string s = "vvvv";
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
            if (regex != )
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }
        }

        
    }
}