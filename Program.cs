using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle 
    {
        static void Main(string[] args)
        {
            bool rpt = true;
            while (rpt)
            {
                try
                {
                    Console.WriteLine("1. Enter triangle dimensions");
                    Console.WriteLine("2. Exit");
                   
                    int input = int.Parse(Console.ReadLine());


                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Please Enter Three Sides Triangle\n");
                            Console.WriteLine("Check it Form a triangle or not");
                            Console.WriteLine("triangle is scalene, isosceles or equilateral\n");
                            int s1 = 0;
                            int s2 = 0;
                            int s3 = 0;

                            Console.Write("Enter Value of Side 1 for Triangle: ");
                            s1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Value of Side 2 for Triangle:");
                            s2 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Value of Side 3 for Triangle: ");
                            s3 = Convert.ToInt32(Console.ReadLine());


                            string res = TriangleSolver.Analyze(s1, s2, s3);
                            Console.WriteLine(res);

                            break;

                        case 2:
                            Console.WriteLine("Thank you.\n");
                            System.Environment.Exit(0);
                            rpt = false;
                            break;


                        default:
                            Console.WriteLine("Wrong input! Enter 1 or 2 only \n ");

                            continue;
                    }
                }

                catch (Exception)
                {

                    Console.WriteLine("Please enter correct input");


                };
            }
            }
           
        }
    }

