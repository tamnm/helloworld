using System;
using System.Dom;
using System.Html;

namespace HelloWorld.Strings
{
    public static class StringHelper
    {
        public static string FormatWith(this string format, params object[] @paramas)
        {
            var str = format;
            for (var i = 0; i < @paramas.length; i++)
            {
                str = str.replace("{" + i + "}", @paramas[i].toString());
            }
            return str;
        }
    }
}
