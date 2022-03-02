using ConsoleApp8.Environment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8 {
    static class World {
        public static List<Guy> guys = new List<Guy>();
        public static List<Loc> locs = new List<Loc>();

        public static Weather weather = Weather.Default;
        
        public static void init() {
            locs.Add(new Loc("Рынок"));
            locs.Add(new Loc("Пещера"));
            locs.Add(new Loc("Хата"));
        }

        public static Loc getRandomLoc() {
            return locs[Game.r.Next(0,locs.Count)];
        }

        public static void changeWeather() {
            if (weather == Weather.Rain) {
                Console.WriteLine("Дождь прошёл.");
                weather = Weather.Default;
            } else {
                Console.WriteLine("Начался сильный дождь.");
                weather = Weather.Rain;
            }
        }
    }
}
