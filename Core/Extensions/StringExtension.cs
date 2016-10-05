using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class StringExtension
    {
        public static string Truncate(this string source, int length)
        {
            if (source == null || source.Length < length)
            {
                return source;
            }
            //int nextSpace = source.LastIndexOf(" ", length);
            return string.Format("{0}...", source.Substring(0, length).Trim()); //(nextSpace > 0) ? nextSpace : length
        }


        /// <summary> 
        /// Récupère la valeur textuelle d'une énumération. 
        /// </summary> 
        /// <param name="value">Enum</param> 
        /// <returns>string</returns> 
        public static string GetStringValue(this Enum value)
        {
            var stringValueAttributeArray = value.GetType().GetField((value).ToString()).GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            return stringValueAttributeArray != null && stringValueAttributeArray.Length > 0 ? stringValueAttributeArray[0].StringValue : null;

        }

    }
}
