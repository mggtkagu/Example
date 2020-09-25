using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Vin
    {
        public Boolean CheckVIN(String vin)
        {
            Regex regex = new Regex("[A-HJ-NPR-Z0-9]{13}[0-9]{4}");
            return regex.IsMatch(vin);
        }

        public String GetVINCountry(String vin)
        {
            string str = vin.Substring(0,2);                       
            return str;
        }

        public Int32 GetTransportYear(String vin)
        {
            //1 2 3 4 5 6 7 8 9 10
            //J H M C M 5 6 5 5 7 C 4 0 4 4 5 3
            string[] str = vin.Split(' ');
           /* for (int i = 1; i <= 10; i++)
            {
                if (i == 10) return str[9];
            }*/

            return str[9];
        }

    }
}
