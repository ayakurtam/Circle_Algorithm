using System;

namespace Circle_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int xCenter, yCenter, Radius;

            // To read Start point
            Console.WriteLine("Enter the center point");
            string xCenter_string, yCenter_string;
            Console.WriteLine("X1:");
            xCenter_string = Console.ReadLine();
            xCenter = Convert.ToInt32(xCenter_string);
            Console.WriteLine("Y1:");
            yCenter_string = Console.ReadLine();
            yCenter = Convert.ToInt32(yCenter_string);

            // To read the Radius of the circle in cm
            Console.WriteLine("Enter the radius in cm");
            string Radius_string;
            Radius_string = Console.ReadLine();
            Radius = Convert.ToInt32(Radius_string);

            midPointCircleDraw(xCenter, yCenter, Radius);
        }

        static void midPointCircleDraw(int x_centre, int y_centre, int Radius)
        {
            // Assume center of circle is at the origin
            int y = 0;
            int x = Radius;
            // Printing the initial point on the axis after translation
            Console.Write("(" + (x + x_centre) + ", " + (y + y_centre) + ")");
            // When radius is zero only a single point will be printed
            if (Radius > 0)
            {
                Console.Write("(" + (x + x_centre) + ", " + (-y + y_centre) + ")");
                Console.Write("(" + (y + x_centre) + ", " + (x + y_centre) + ")");
                Console.WriteLine("(" + (-y + x_centre) + ", " + (x + y_centre) + ")");
            }

            // Initialising the value of P
            int P = 1 - Radius;
            while (x > y)
            {
                y++;
                // Mid-point is inside or on the perimeter
                if (P <= 0)
                    P = P + 2 * y + 1;
                else // Mid-point is outside the perimeter
                {
                    x--;
                    P = P + 2 * y - 2 * x + 1;
                }

                // All the perimeter points have already been printed
                if (x < y)
                    break;

                // Printing the generated point and its reflection in the other octants after translation
                Console.Write("(" + (x + x_centre) + ", " + (y + y_centre) + ")");
                Console.Write("(" + (-x + x_centre) + ", " + (y + y_centre) + ")");
                Console.Write("(" + (x + x_centre) + ", " + (-y + y_centre) + ")");
                Console.WriteLine("(" + (-x + x_centre) + ", " + (-y + y_centre) + ")");

                // If the generated point is on the line x = y then the perimeter points have already been printed
                if (x != y)
                {
                    Console.Write("(" + (y + x_centre) + ", " + (x + y_centre) + ")");
                    Console.Write("(" + (-y + x_centre) + ", " + (x + y_centre) + ")");
                    Console.Write("(" + (y + x_centre) + ", " + (-x + y_centre) + ")");
                    Console.WriteLine("(" + (-y + x_centre) + ", " + (-x + y_centre) + ")");
                }
            }

        }
    }
}
