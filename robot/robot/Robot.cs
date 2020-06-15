using System;
using System.Collections.Generic;
using System.Text;

namespace robot
{
    enum RobotType
    {
        Translator,
        CoffeeMaking,
        Bartender
    }
    class Robot
    {
        public string Name { get; set; }
        public RobotType Type { get; set; }
        private static List<string> names = new List<string>();
        private bool unique { get; set; }
        private Random random = new Random();

        public Robot()
        {
            nameGenerate();

            names.Add(Name);
            TypeGenerate();
        }

        public void Reset()
        {
            string name = Name;

            nameGenerate();

            names.Remove(name);

            names.Add(Name);
        }

        private void nameGenerate()
        {
            do
            {
                for (int i = 0; i < 2; i++)
                {
                    Name += (char)('a' + random.Next(0, 25));
                }
                Name += (random.Next(100, 1000)).ToString();

                unique = true;

                foreach (var item in names)
                {
                    if (item == Name)
                    {
                        unique = false;
                    }
                }

            } while (unique == false);
        }

        private void TypeGenerate()
        {
            switch (random.Next(1,4))
            {
                case 1:
                    Type = RobotType.Translator;
                    break;
                case 2:
                    Type = RobotType.CoffeeMaking;
                    break;
                case 3:
                    Type = RobotType.Bartender;
                    break;
            }
        }
    }
}
