using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopsy.Formats.PeCoff
{
    public static class ReflectionHelpers
    {
        public static string GetCustomDescription(Enum value)
        {
            DescriptionAttribute attribute = value.GetType()
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
