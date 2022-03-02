using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Guy {
        private static Random r = Game.r;
        private static String[] names = { "Сталин", "Пыня", "Санякас", "Гепирякас", "Пикочо", "ГРИИИБ", "Олег"};
        public string name;

        public Guy() {
            name = names[r.Next(0, names.Length-1)];
        }

        public override string ToString() {
            return name;
        }
    }
}
