using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Framework.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static DateTime? ConvertToDate(this string input)
        {
            try
            {
                var startDateYear = input.Split('/')[0];
                var startDateMonth = input.Split('/')[1];
                var startDateDay = input.Split('/')[2];
                return new DateTime(int.Parse(startDateYear), int.Parse(startDateMonth), int.Parse(startDateDay), new System.Globalization.PersianCalendar());
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public static string ToPersianDate(this DateTime input)
        {
            var calendar = new System.Globalization.PersianCalendar();
            return calendar.GetYear(input) + "/" + calendar.GetMonth(input) + "/" + calendar.GetDayOfMonth(input);
        }
    }
}
