using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    class Score
    {
        public static void Main(string[] arg)
        {
            //88 76 91 57 66 79 84 99 75 63
            //88,76,91,57,66,79,84,99,75,63
            int[] score = new int[10];
            Console.WriteLine("输入10个成绩，每个数用空格分隔");
            string stringScore = Console.ReadLine();
            Console.WriteLine("输入字符串为：" + stringScore);
            string[] arr = stringScore.Split(' ');
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = int.Parse(arr[i]);
            }
            Console.WriteLine("最高分为：" + Max(score));
            Console.WriteLine("最低分为：" + Min(score));
            Console.WriteLine("平均分为：" + Avg(score));
            Console.WriteLine("总分为：" + Sum(score));
            Console.WriteLine("排序前成绩：");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write(score[i] + " ");
            }
            Sort(ref score);
            Console.WriteLine("排序后成绩：");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write(score[i] + " ");
            }
            Console.ReadKey();
        }

        public static int Max(int[] score)
        {
            int max = score[0];
            for (int i = 0; i < score.Length; i++)
            {
                if (max < score[i])
                {
                    max = score[i];
                }
            }
            return max;
        }

        public static int Min(int[] score)
        {
            int min = score[0];
            for (int i = 0; i < score.Length; i++)
            {
                if (min > score[i])
                {
                    min = score[i];
                }
            }
            return min;
        }

        public static int Sum(int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            return sum;
        }

        public static double Avg(int[] score)
        {
            double avg = 0;
            int sum = Sum(score);
            avg = sum / score.Length;
            return avg;
        }

        public static void Sort(ref int[] score)
        {
            for (int i = 0; i < score.Length - 1; i++)
            {
                for (int j = 0; j < score.Length - i - 1; j++)
                {
                    if (score[j] > score[j + 1])
                    {
                        int temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                }
            }
        }
    }
}
