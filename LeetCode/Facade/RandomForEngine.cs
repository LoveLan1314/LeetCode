using System;
using System.Collections.Generic;

namespace ConsoleApplication.Facade
{
    // while (true)
    // {
    //     Console.WriteLine("请输入最少个数:");
    //     int minCount = int.Parse(Console.ReadLine());
    //     Console.WriteLine("请输入最多个数:");
    //     int maxCount = int.Parse(Console.ReadLine());
    //     Console.WriteLine("请输入最小点数:");
    //     int minPoint = int.Parse(Console.ReadLine());
    //     Console.WriteLine("请输入最大点数:");
    //     int maxPoint = int.Parse(Console.ReadLine());
    //     RandomForEngine engine = new RandomForEngine(minCount, maxCount, minPoint, maxPoint);
    //     engine.Calc();
    //     Console.WriteLine("正确点数:" + string.Join(",", engine.RigthNums) + "\t个数：" + engine.RigthNums.Count);
    //     Console.WriteLine("错误点数:" + string.Join(",", engine.WrongNums) + "\t个数：" + engine.WrongNums.Count);
    //     Console.WriteLine("正确率:" + engine.Precent);
    //     Console.WriteLine("计算结束，输入q退出，回车继续");
    //     if (Console.ReadLine() == "q")
    //     {
    //         return;
    //     }
    // }
    class RandomForEngine
    {
        private int minCount;
        private int maxCount;
        private int minPoint;
        private int maxPoint;
        private double precent;
        private List<int> rigthNums = new List<int>();
        private List<int> wrongNums = new List<int>();
        public RandomForEngine(int minCount, int maxCount, int minPoint, int maxPoint)
        {
            this.minCount = minCount;
            this.maxCount = maxCount;
            this.minPoint = minPoint;
            this.maxPoint = maxPoint;
        }

        public double Precent { get => precent; private set => precent = value; }
        public List<int> RigthNums { get => rigthNums; private set => rigthNums = value; }
        public List<int> WrongNums { get => wrongNums; private set => wrongNums = value; }

        public void Calc()
        {
            Random random = new Random();
            int count = random.Next(minCount, maxCount + 1);
            int rightCount = count * random.Next(70, 91) / 100;
            int wrongCount = count - rightCount;
            precent = (double)rightCount / (double)count * 100;
            for (int i = 0; i < rightCount; i++)
            {
                rigthNums.Add(random.Next(minPoint, maxPoint + 1));
            }
            for (int i = 0; i < wrongCount; i++)
            {
                if (minPoint >= 0)
                {
                    wrongNums.Add(random.Next(maxPoint + 1, maxPoint + 4));
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        wrongNums.Add(random.Next(maxPoint + 1, maxPoint + 4));
                    }
                    else
                    {
                        wrongNums.Add(random.Next(minPoint - 3, minPoint));
                    }
                }
            }
        }
    }
}