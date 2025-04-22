using System;
using System.Globalization;

namespace OrderManagemetSystem.Utils
{
	public static class DateTimeExtensions
	{
		public static string ToPersian(this DateTime dateTime)
		{
			PersianCalendar pc = new PersianCalendar();

			string persianDate = $"{pc.GetYear(dateTime).ToString("0000")}/{pc.GetMonth(dateTime).ToString("00")}/{pc.GetDayOfMonth(dateTime).ToString("00")}";

			return persianDate;
		}

		public static DateTime ToGregorian(this string persianDate)
		{
			var parts = persianDate.Split('/');
			int year = int.Parse(parts[0]);
			int month = int.Parse(parts[1]);
			int day = int.Parse(parts[2]);

			PersianCalendar pc = new PersianCalendar();
			return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
		}
	}
}
