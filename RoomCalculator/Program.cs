using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                string userWantsToContinue;
               
                do
                {

                    decimal cansOfPaint = 0.2m;
                    decimal tilesOFCarpet = 0.2m;


                    Console.WriteLine("Please enter the values for the length and width of the classroom: ");

                    Console.WriteLine("Length: ");
                    decimal userLength = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Width: ");
                    decimal userWidth = decimal.Parse(Console.ReadLine());

                    decimal area = userLength * userWidth;
                    decimal userPerimeter = (userLength + userWidth) * 2 ;

                    Console.WriteLine("the area of the room is " + area);
                    Console.WriteLine("the perimeter of the room is " + (userPerimeter) + " square feet");
                    Console.WriteLine("You will need: " + (cansOfPaint * userPerimeter) + " cans of paint");
                    Console.WriteLine("You will need: " + (tilesOFCarpet * area) + " tiles of carpet");


                    Console.WriteLine("Do you want to continue? (y/n)");

                    userWantsToContinue = Console.ReadLine().ToUpper();

                } while (userWantsToContinue == "Y");

            }
        }
    }
}