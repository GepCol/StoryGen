using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Events {
    abstract class SocialConflictEvent {
        /*
         * Общий класс всех ивентов-конфликтов с людьми:
         * Цыгане, бандиты, пираты, полиция, ...
         * Из них всегда 3 пути выхода:
         * - Бежать
         * - Атаковать
         * - Договориться
         * Ну и внезапности эффекты, когда кто-то вмешивается и устраняет угрозу, или когда атакуют внезапно и сделать особо ничего не успеешь.
         * 
         * Любой успешный выход - универсальный, а вот фейлы... Цигане просто обворуют, тогда как полиция - посадит.
         */

        public SocialConflictEvent(string appear) {
            Console.WriteLine(appear);
            Console.WriteLine(Game.sel("Бежим!","Атакуем!","Дипломатия!"));
            if (Game.r.NextDouble() < 0.5) {//success
                Console.WriteLine("Получилось!");//Мне лень уже пилить прям реально нормальное описание.
            } else {//fail
                if (Game.p.items.Count > 0 && Game.r.NextDouble() < 0.5) {
                    Item item = Game.p.items[Game.r.Next(0, Game.p.items.Count - 1)];
                    item.fightUsage();
                    Game.p.items.Remove(item);
                } else {
                    onFail();
                }
            }
        }
        public abstract void onFail();
    }
}
