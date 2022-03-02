using System;
using System.Threading;

namespace ConsoleApp8 {
    class Game {
        public static Random r = new Random();
        public static Player p;
        public static Item target = new Item();
        private static bool storyEnded = false;
        static void Main(string[] args) {
            World.init();
            p = new Player("Гепи");
            startStory();
            while (!storyEnded) {
                tick();
            }
            for(int i=0;i<3;i++)Console.WriteLine("     -----     -----");
            ColledgeTasks.runAll();
        }

        static void startStory() {
            int year = r.Next(1000, 3000);
            Console.WriteLine($"Шёл далёкий {year} год... {(year-1)/100+1} век нашей эры...");

            Item item = new Item();
            Console.WriteLine($"Наша история начинается с {p.name}. Он долгое время занимался кое-чем, и с тех времён остался у него артефакт - {item.name}.");
            Console.WriteLine($"Всю жизнь {p.name} мечтал отправиться в приключение, чтобы заполучить {target.name}.");
            knewAboutPlace();
        }

        static void knewAboutPlace() {
            Loc loc = World.getRandomLoc();
            Console.Write(sel("Прогуливаясь, ","Сидя на лавочке, ","Размышляя о всяком, "));
            Console.Write(p.name);
            Console.Write(sel(" узнал"," разузнал"," понял"));
            Console.Write($", что в {loc.name} можно найти информацию о {target.name}.");
            Console.WriteLine();
            p.setTargetLoc(loc);
        }

        public static void tick() {
            if (r.NextDouble() <= 0.1) {
                World.changeWeather();
            }
            if (p.targetLoc != null) {
                GameEvents.someoneKnewAboutYou();
            } else {
                p.setTargetLoc(World.getRandomLoc());
            }
            if (r.NextDouble() <= 0.1) {
                Console.WriteLine("Герой умер от старости, конец.");
                storyEnded = true;
            }
        }

        public static string sel(params string[] sts) {
            return sts[r.Next(0, sts.Length - 1)];
        }
    }
}
