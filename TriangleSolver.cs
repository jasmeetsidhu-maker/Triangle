using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static int checkValidity(int a, int b,
                                 int c)
        {

            if (a == 0 || b == 0 || c == 0)
            {
                
                return 0;
            }
            else if (a + b <= c || a + c <= b ||
                                b + c <= a) 
            {
               
                return 0; 
            }

            else
                return 1;
        }

        

        public static string Analyze (int triangleValue1, int triangleValue2, int triangleValue3)
        {
            string triangle = string.Empty;


            // find whether its Equilateral or not
            
            if ((triangleValue1 == triangleValue2) && (triangleValue2 == triangleValue3) & (triangleValue3 == triangleValue1))
            {
                triangle = "Triangle is Equilateral \n";
            }
            
       

            //find whether its isoceles or not
            else if (triangleValue1 == triangleValue2 || triangleValue1 == triangleValue3 || triangleValue2 == triangleValue3)
            {
                triangle = "Triangle is Isosceles \n";
                
            }
           
           
            //  find whether its scalene or not
            else if ((triangleValue1 != triangleValue2) || (triangleValue2 != triangleValue3) | (triangleValue3 != triangleValue1))
            {
                triangle = "Triangle is Scalene \n";
            }
           


            else
            {
                triangle = " It's not a Triangle";
            }
            return triangle;


        }







    }

    
}
