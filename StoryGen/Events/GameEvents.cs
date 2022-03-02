using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8 {
    static class GameEvents {
        static List<Delegate> list = new List<Delegate>();
        public static void someoneKnewAboutYou() {
            Guy guy = new Guy();
            Console.WriteLine($"{guy} прознал о планах нашего героя...");
            World.guys.Add(guy);
        }
    }
}
