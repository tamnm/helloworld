using System;
using System.Dom;
using System.Html;

namespace HelloWorld.Strings
{
    public static class StringHelper
    {
        public static string FormatWith(this string format,params object[] @params)
        {
            var str = format;
            for (var i = 0; i < @params.length; i++)
            {
                str = str.replace("{" + i + "}", @params[i].toString());
            }
            return str;
        }
    }
}
