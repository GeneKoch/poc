using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            object value = "11/06/2003";

            var date = DateTime.ParseExact(value.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

            var today = DateTime.Today;
            var age = today.Year - date.Year;

            var minimumAgeResult = date.AddYears(18) < DateTime.Now;

            if (minimumAgeResult)
            {
               
            }
        }

        public static int CalculateAge(DateTime birthDay)
        {
            int years = DateTime.Now.Year - birthDay.Year;

            if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
                years--;

            return years;
        }
    }
}
