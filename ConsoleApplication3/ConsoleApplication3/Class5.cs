using System;

namespace ConsoleApp1
{
    class MainTest
    {
        static void Main(string[] args)
        {
            Console.Write("请输入长方形的长：");
            double length = double.Parse(Console.ReadLine());
            Square square = new Square(length);
            square.Show(square.Area());
            Console.Write("请输入圆的半径：");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.Show(circle.Area());
        }
    }
}
