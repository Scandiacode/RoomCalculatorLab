using System;

namespace RoomCalcLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintCan = 5;
            int carpetTile = 5;
            string restartChoice;

            Console.WriteLine("Hello User, Welcome to the Room Calculator.\n");
            do
            {
                Console.WriteLine("Please enter the Length of the Room: ");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Width of the Room: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Height of the Room: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                double area = length * width;
                double perimeter = (2 * length) + (2 * width);
                double volume = (length * width) * height;

                Console.WriteLine($"The Perimeter of the Room is : {perimeter}");
                Console.WriteLine($"The Area of the Room is : {area}");
                Console.WriteLine($"The Volume of the Room is : {volume} \n");

                double resultCarpetTile = area / carpetTile;
                double resultPaintCan = perimeter * height / paintCan;

                Console.WriteLine($"This is the amount of Paint Cans you need : {resultPaintCan} ");
                Console.WriteLine($"This is the amount of Carpet Tile you need : {resultCarpetTile}  \n");

                Console.WriteLine("Would you like to do another measurement (Yes or No?)");
                restartChoice = Console.ReadLine();
                Console.WriteLine("");
            }
            while (restartChoice.ToLower() == "yes");
        
        }
    }
}
