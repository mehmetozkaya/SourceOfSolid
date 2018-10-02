using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public static class ConvertHelper
    {
        private static object TryTo(Type type, object value, object defaultValue, string cultureInfo, out bool convertSucceed)
        {
            CultureInfo info = string.IsNullOrEmpty(cultureInfo) ? System.Threading.Thread.CurrentThread.CurrentCulture : new CultureInfo(cultureInfo);
            convertSucceed = true;
            try
            {
                string valueAsString = value.ToString();

                if (type == typeof(Guid))
                {
                    return Guid.Parse(valueAsString);
                }
                else if (type.IsEnum)
                {
                    return Enum.Parse(type, valueAsString);
                }
                else if (type == typeof(Uri))
                {
                    if (string.IsNullOrEmpty(valueAsString))
                    {
                        return null;
                    }
                    return new Uri(valueAsString, UriKind.RelativeOrAbsolute);
                }
                else if (value.GetType() == typeof(Guid))
                {
                    return ((Guid)value).ToString();
                }
                //if (!CheckIsConvertible(value))
                //{
                //    return valueAsString;
                //}
                return Convert.ChangeType(value, type, info);
            }
            catch
            {
                convertSucceed = false;
                return Default(type, value, defaultValue);
            }
        }

        public static bool CheckIsConvertible(object value)
        {
            IConvertible convertible = value as IConvertible;
            return convertible != null;
        }
        public static object To(Type type, object value, object defaultValue = null, string cultureInfo = null)
        {
            if (value == null || value == DBNull.Value)
                return Default(type, value, defaultValue);

            Type underlyingType = Nullable.GetUnderlyingType(type);
            bool convertSucceed;

            if (underlyingType != null)
            {
                var underlyingConverted = TryTo(underlyingType, value, defaultValue, cultureInfo, out convertSucceed);

                if (!convertSucceed)
                {
                    return Default(type, value, defaultValue);
                }

                return underlyingConverted;
            }
            return TryTo(type, value, defaultValue, cultureInfo, out convertSucceed);
        }


        public static object Default(Type type, object value = null, object defaultValue = null)
        {
            if (type.IsValueType)
            {
                if (defaultValue == null)
                {
                    return Activator.CreateInstance(type);
                }
                return defaultValue;
            }

            if (value == null || value == DBNull.Value) return defaultValue;

            if (type == typeof(string))
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    return defaultValue;
            }
            return value;
        }

        public static T Default<T>(T val, T def)
        {
            return (T)Default(typeof(T), val, def);
        }

        public static T To<T>(object val, T def = default(T), string cultureInfo = null)
        {
            object result = To(typeof(T), val, def, cultureInfo);

            return (T)result;
        }

        public static decimal ToDecimal(string value)
        {
            var culture = new CultureInfo("tr-TR");
            var seperator = ",";
            var clearText = value.Replace(".", seperator).Trim();
            return decimal.Parse(clearText, CultureInfo.GetCultureInfo("tr-TR"));
        }

        public static int ToInt(string value)
        {
            if (int.TryParse(value, out int res))
                return res;
            return 0;
        }


    }
}
