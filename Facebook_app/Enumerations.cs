using System;
using System.ComponentModel;
using System.Reflection;

namespace Facebook_app
{
    internal class Enumerations
    {
        public static string GetEnumDescription(object value)
        {
            string enumDescription = string.Empty;
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                enumDescription = attributes[0].Description;
            }
            else
            {
                enumDescription = value.ToString();
            }

            return enumDescription;
        }
    }
}