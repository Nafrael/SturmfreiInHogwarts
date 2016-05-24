using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SturmfreiInHogwarts
{
    public static class IndexToCoordinateConverter
    {
        public static int Length { get; set; }

        public static Coordinates Convert(int x, int y)
        {
            Coordinates coordinates = new Coordinates();

            if (x == 0)
            {
                coordinates.X = x;
            }
            else
            {
                coordinates.X = x * Length;
            }

            if (y == 0)
            {
                coordinates.Y = y;
            }
            else
            {
                coordinates.Y = y * Length;
            }

            return coordinates;
        }
    }
}
