using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{

    /// <summary>
    /// Problem: we have to pass datetimes to another system wich needs the dates as shown below 
    /// 20180205154537 <- the format is (yyyyMMddhhmmss)
    /// 9501301692456 <- same but the year is on two digits
    /// Solve: we are goning to make a simple implementation of Datetime extensions as below
    /// </summary>
    public static class DatetimeExtensions
    {
        public static string ToDeviceFormat(this DateTime dt) =>
            dt.Year >= 2000 ? dt.ToString("yyyyMMddhhmmss") : dt.ToString("yyyyMMddhhmmss").Substring(2);

    }
}
