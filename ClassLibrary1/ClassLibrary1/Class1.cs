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
            string number = Console.ReadLine();
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
            if (!Regex.IsMatch(number, ))
                if (number = regex(@"\d{A-H}"))
                {
                }
        } 

    }
}