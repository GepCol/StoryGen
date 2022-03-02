using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Events {
    class Cigane:SocialConflictEvent {
        public Cigane(): base("Нас окружили цыгане!") {
            

            switch (Game.r.Next(1, 3)) {
                case 1:
                    Console.WriteLine("Бежим!");
                    break;
                case 2:
                    Console.WriteLine("Атакуем!");
                    break;
                case 3:
                    Console.WriteLine("Дипломатия!");
                    break;
            }
        }

        public override void onFail() {
            throw new NotImplementedException();
        }
    }
}
