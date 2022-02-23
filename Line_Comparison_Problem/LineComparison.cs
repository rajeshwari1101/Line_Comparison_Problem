using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    internal class LineComparison
    {

        public int X_1, X_2, Y_1, Y_2, S_1, S_2, R_1, R_2;

        public double Length_XY, Length_SR;
        
        public void length_line()
        {

            Console.WriteLine("Enter x, y co ordinates of the line 1 :");

            Console.WriteLine("Enter value X_1");
            X_1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter vale X_2");
            X_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale Y_One");
            Y_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale Y_2");
            Y_2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter x, y co ordinates of the line 2 :");

            Console.WriteLine("Enter value of S_1");
            S_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of S_2");
            S_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale R_1");
            R_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale R_Two");
            R_2 = Convert.ToInt32(Console.ReadLine());



            double Length_XY = Math.Sqrt(Math.Pow((X_1 - X_2), 2) + Math.Pow((Y_2 - Y_1), 2));
            Console.WriteLine("Length of Line 1 is:: " + Length_XY);

            double Length_SR = Math.Sqrt(Math.Pow((S_2 - S_1), 2) + Math.Pow((R_2 - R_1), 2));
            Console.WriteLine("Length of Line 2 is: " + Length_SR);
            Console.ReadLine();

        }


        public void check_equality() 
        {
            bool equal_result = Length_XY.Equals(Length_SR);

            if (equal_result == false)
                Console.WriteLine(" Length of XY and Length of SR are NOT Equal");
            else
                Console.WriteLine("Length of XY and Length of SR are Equal");
            Console.ReadKey();
        }
    }
}
