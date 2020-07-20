using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaFit.Infrastructure.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveMask(this string number)
        {
            return number.Replace(".", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("/", "").Replace(" ", "");
        }

        public static string FormatoCpfCnpj(this string strIn)
        {
            if (!string.IsNullOrWhiteSpace(strIn))
            {
                if (strIn.Length == 11)
                {
                    //return Convert.ToUInt64(strIn).ToString(@"000\.000\.000\-00");
                    return strIn.Substring(0, 3)
                        + "." + strIn.Substring(3, 3)
                        + "." + strIn.Substring(6, 3)
                        + "-" + strIn.Substring(9, 2);
                }

                if (strIn.Length == 14)
                {
                    return strIn.Substring(0, 2)
                        + "." + strIn.Substring(2, 3)
                        + "." + strIn.Substring(5, 3)
                        + "/" + strIn.Substring(8, 4)
                        + "-" + strIn.Substring(12, 2);
                }
            }

            return "";
        }

        public static string FormatoTelCel(this string strIn)
        {
            if (!string.IsNullOrWhiteSpace(strIn))
            {
                if (strIn.Length == 10)
                {     
                    //return Convert.ToUInt64(strIn).ToString(@"000\.000\.000\-00");
                    return "(" + strIn.Substring(0, 2)
                        + ") " + strIn.Substring(2, 4)
                        + "-" + strIn.Substring(5, 4);
                }
                
                if (strIn.Length == 11)
                {
                    return "(" + strIn.Substring(0, 2)
                        + ") " + strIn.Substring(2, 5)
                        + "-" + strIn.Substring(6, 4);
                }
            }

            return "";
        }

        public static string FormatoCref(this string strIn)
        {
            if (!string.IsNullOrWhiteSpace(strIn))
            {
                if (strIn.Length == 9)
                {   
                    //return Convert.ToUInt64(strIn).ToString(@"000\.000\.000\-00");
                    return strIn.Substring(0, 6)
                        + "-" + strIn.Substring(6, 1)
                        + "/" + strIn.Substring(7, 2);
                }
            }

            return "";
        }
    }
}
