using System;
using System.ComponentModel;
using System.Linq;

namespace Autopsy.Formats.PeCoff.Common
{
    public static class ReflectionHelpers
    {
        public static string GetCustomDescription(Enum value)
        {
            // TODO: Check attribute before!
            var attribute = 
                value.GetType()
                     .GetField(value.ToString())
                     .GetCustomAttributes(typeof(DescriptionAttribute), false)
                     .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static string ToDesc(this Enum value)
        {
            return GetCustomDescription(value);
        }
    }
}
