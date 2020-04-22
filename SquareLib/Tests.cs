using System;
using SquareDLL;

namespace SquareLib
{
    class Tests
    {
        static void Main(string[] args)
        {
            //Test 1 Constructor check(incorrect values)
            try
            {
                Circle a = new Circle(-5);
            }
            catch (Exception ex) {
                if (ex.Message == "Radius lower then zero")
                    Console.WriteLine("Test 1 completed");
                else
                {
                    Console.WriteLine("Test 1 FAILED");
                }
            }

            //Test 2 border values
            try
            {
                Circle a = new Circle(0);
                if (a.GetSquare() == 0)
                    Console.WriteLine("Test 2 completed");
                else
                {
                    Console.WriteLine("Test 2 FAILED");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Test 3 Normal values
            try
            {
                Circle a = new Circle(1);
                if (a.GetSquare() == Math.PI)
                    Console.WriteLine("Test 3 completed");
                else
                {
                    Console.WriteLine("Test 3 FAILED");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Test 4 Constructor check(incorrect values)
            try
            {
                Triangle a = new Triangle(-1,1,1);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Side/Sides lower/equal then zero")
                    Console.WriteLine("Test 4 completed");
                else
                {
                    Console.WriteLine("Test 4 FAILED");
                }
            }

            //Test 5 Normal values for right triangle
            try
            {
                Triangle a = new Triangle(3, 4, 5);
                if (a.GetSquare() == 6)
                    Console.WriteLine("Test 5 completed");
                else
                {
                    Console.WriteLine("Test 5 FAILED");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Test 6 Normal values
            try
            {
                Triangle a = new Triangle(1, 1, 1);
                if (a.GetSquare() == 0.4330127018922193)
                    Console.WriteLine("Test 6 completed");
                else {
                    Console.WriteLine("Test 6 FAILED");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            
            








        }
    }
}
