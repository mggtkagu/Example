using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class Mark
    {
        Boolean CheckMARK(String mark)
        {
            Regex regex = new Regex(@"/ ^[АВЕКМНОРСТУХ]{ 2 }\d{ 3} (?<!000)\d{ 2,3}$/ ui");
            return regex.IsMatch(mark);
        }

        String GetNextMarkAfter(String mark)
        {
            Regex regex = new Regex(@"/^[АВЕКМНОРСТУХ]{ 2 }\d{ 3} (?<!000)\d{ 2,3}$/ ui");
           // return 
        }

      /*  String GetNextMarkAfterInRange(String prevMark, String rangeStart, String rangeEnd)
        {

        }

        Int32 GetCombinationsCountInRange(String mark1, String mark2)
        {

        }*/
    }
}
