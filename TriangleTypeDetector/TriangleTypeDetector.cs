using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace TriangleTypeDetector
{
    public class TriangleTypeDetector
    {
        public enum TriangleTypes
        {
            [Description("Прямоугольный")]
            Rectangular,
            [Description("Тупоугольный")]
            Obtuse,
            [Description("Остроугольный")]
            AcuteAngled
        }

        public static TriangleTypes GetTriangleType(int[] sides)
        {
            if (sides.Length != 3) throw new Exception("У треугольника должно быть 3 стороны");
            if (sides.Where(x => x <= 0).Count() > 0) new Exception("Длины всех сторон должны быть положительными");
            int[] sortedSides = sides.OrderByDescending(x => x).ToArray();
            int s1Square = sortedSides[0] * sortedSides[0];
            int s2Square = sortedSides[1] * sortedSides[1];
            int s3Square = sortedSides[2] * sortedSides[2];

            if (s1Square == s2Square + s3Square) return TriangleTypes.Rectangular;
            else if (s1Square < s2Square + s3Square) return TriangleTypes.AcuteAngled;
            else return TriangleTypes.Obtuse;            
        }

        public static string GetDescription(Enum enumElement)
        {
            Type type = enumElement.GetType();

            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return enumElement.ToString();
        }

    }
}
