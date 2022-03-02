using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8 {
    class Player {
        public List<Item> items = new List<Item>();

        public Loc targetLoc;

        public readonly string name;
        
        public Player(string name) {
            this.name = name;
        }

        public void setTargetLoc(Loc loc) {
            Console.Write("Решил наш герой ");
            if (targetLoc != null) Console.Write(Game.sel($"забыть о {targetLoc.name}, и ", $"послать {targetLoc.name}, и ", $"не идти в {targetLoc.name}, а "));
            Console.Write(Game.sel("пойти в ", "ринуться в ", "добраться до ") + loc.name);
            Console.WriteLine(".");
            targetLoc = loc;
        }

        public void justSetTargetLoc(Loc loc) {
            targetLoc = loc;
        }

        public override string ToString() {
            return name;
        }

        public string me() {
            return Game.sel("наш герой",name);
        }
    }
}
