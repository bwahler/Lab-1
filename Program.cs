using System;

namespace Lab_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            do
            {
                Console.WriteLine("Please enter the Length:");
                String Length = Console.ReadLine();
                double lengthRoom = double.Parse(Length);

                Console.WriteLine("Please enter the width:");
                String Width = Console.ReadLine();
                double widthRoom = double.Parse(Width);

                Console.WriteLine("Please enter the height:");
                String Height = Console.ReadLine();
                double heightRoom = double.Parse(Height);

                double area = lengthRoom * widthRoom;
                double perimeter = 2 * lengthRoom + 2 * widthRoom;
                double volume = widthRoom * lengthRoom * heightRoom;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Continue (y/n)");

            } 
            //If anything other than a y is entered the program will exit
            while (Console.ReadLine() == "y");
        }
    }
}