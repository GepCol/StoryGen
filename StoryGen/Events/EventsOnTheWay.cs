using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Events {
    static class EventsOnTheWay {
        public static void prefixOnTheWay() {
            Console.Write(Game.sel("На пути ", "Идя и размышляя, ", "Двигаясь вперёд, ") + Game.p.me());
        }
        public static void swampAttack() {

        }
    }
}
