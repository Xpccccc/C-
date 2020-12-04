

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Square : Father, Shape
    {
        private double length;
        public double Area()
        {
            if (length <= 0)
            {
                throw new InputExcption("输入的值应大于0");
            }
            else
            {
                double area = length * length;
                return area;
            }
        }

        public Square(double length)
        {
            this.length = length;
        }

        public override void Show(double area)
        {
            Console.WriteLine("长方形的面积为：" + area);
        }
    }
}