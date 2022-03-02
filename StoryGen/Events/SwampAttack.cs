using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Events {
    class SwampAttack {
        /*
         * Так. Болото. Тут можно тонуть, тут могут напасть крокодилы, тут можно заболеть малярией. Обычных разбойников не забываем.
         * А ещё тут можно собрать ягод, поохотиться.
         * И ещё всякие ведьмы, почему бы и нет?
         * АААА, чёрт! Окей. Начал тонуть в болоте И на него нападают крокодилы. Что делать?
         * Ухватиться за бревно и отбиваться палкой, либо заюзать артефакт для поразительного эффекта...
         * Чего я хочу от этого ивента? Если тупо прописать всё заранее - скучная игра.
         * Выход должен быть непредсказуем даже для меня, кодера. Так как?
         * Прописать универсальные мувы, что игрок может сделать против любых живых тварей, и угарать с "чел ведёт переговоры с Крокодилами")
         * 
         */
        int time = 100;
        int swampDying = -1;
        int crocodileDying = -1;
        public SwampAttack() {
            Console.WriteLine(Game.p+" угодил в болото!");

        }

        private void tick() {
            while (time-->0) {
                if (swampDying==-1){
                    if (Game.r.NextDouble() <= 0.05) {
                        Console.WriteLine("Он начал тонуть в болоте!");
                    }
                } else {
                    swampDying--;
                }
                if (crocodileDying == -1){
                    if (Game.r.NextDouble() <= 0.05) {
                        Console.WriteLine("Его заметили крокодилы!");
                    }
                } else {
                    crocodileDying--;
                }

            }
        }
    }
}
