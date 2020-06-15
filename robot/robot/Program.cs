using System;
using System.Collections.Generic;

namespace robot
{
    class Program
    {
        static void Main()
        {
            List<Robot> Robots = new List<Robot>();

            Robots.Add(new Robot());
            Robots.Add(new Robot());
            Robots.Add(new Robot());
            Robots.Add(new Robot());

            foreach (var item in Robots)
            {
                Console.WriteLine(item.Name + " " + item.Type);
            }

            Console.ReadKey();
        }
    }
}
