using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static string Analyze (int angle1, int angle2, int angle3 )
        {
            string trianlge = string.Empty;


            if ((angle1 != angle2 || (angle2 != angle3) | (angle3 != angle1)))
                {
                trianlge = "Triangle is Scalene \n ";
            }

            else if (angle1==angle2 | angle2==angle3 | angle3==angle1)
            {
                trianlge = "Triangle is Isosceles \n";
            }

            else if ((angle1==angle2)&& (angle2 == angle3) & (angle3 == angle1))
            {
                trianlge = "Triangle is Equilateral \n ";
            }
            else
            {
                trianlge = " It's not a Triangle";
            }
            return trianlge;

        }






        }

    
}
