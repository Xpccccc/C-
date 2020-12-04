using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle : Father, Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new InputExcption("输入的值应大于0");
            }
            else
            {
                this.radius = radius;
            }
        }

        public double Area()
        {
            double area;
            area = radius * Math.PI;
            return area;
        }

        public override void Show(double area)
        {
            Console.WriteLine("圆形的面积为：" + area);
        }
    }
}