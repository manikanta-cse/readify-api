using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readify_API.Services
{
    public class TriangleTypeService
    {

        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            // There should also be a side length check
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }

            if (a == b && a == c) // These could also be their own methods
            {
                return TriangleType.Equilateral;
            }
            if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }
            return TriangleType.Scalene;
        }
    }


    public enum TriangleType
    {
        Equilateral,
        Isosceles,
        Scalene,
        Error
    }
}