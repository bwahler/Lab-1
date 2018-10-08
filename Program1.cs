using System;

namespace Lab_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("Please enter test Length:");
            String Length = Console.ReadLine();
            double lengthRoom = double.Parse(Length);

            Console.WriteLine("Please enter the width");
            String Width = Console.ReadLine();
            double widthRoom = double.Parse(Width);

            double area = lengthRoom * widthRoom;
            double perimeter = 2 * lengthRoom + 2 * widthRoom;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);


