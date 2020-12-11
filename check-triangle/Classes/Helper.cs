using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T7_2180617_TranHoangAnh.Classes
{
    class Helper
    {

        public static string[] splitFileLine(String line)
        {
            string[] result =  Regex.Split(line, @"\t|\|{1,2}");
            return result;
        }
        public static DateTime getTime(String timeString)
        {
            try
            {

            return DateTime.ParseExact(timeString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }catch(Exception e)
            {
            return DateTime.ParseExact("01/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            //return  DateTime.Parse(timeString, CultureInfo.InvariantCulture);
        }
    }
}
