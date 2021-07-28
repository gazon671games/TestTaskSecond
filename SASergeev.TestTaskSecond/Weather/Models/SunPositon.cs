using System;

namespace SASergeev.TestTaskSecond.Models
{
    static class SunPositon
    {
        public static DateTime ConvertToDateGMT(int TimeStamp)
        {
            return ConvertingToDate(TimeStamp).ToUniversalTime();
        }
        public static DateTime ConvertToDateLocal(int TimeStamp)
        {
            return ConvertingToDate(TimeStamp).ToLocalTime();
        }
        private static DateTime ConvertingToDate(int time)
        {
            var TimeStampToConvert = time;
            var timeStamptoDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(TimeStampToConvert);
            return timeStamptoDateTime;
        }
    }
}
