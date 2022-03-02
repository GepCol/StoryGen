using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8 {
    static class ColledgeTasks {
        public static void runAll() {
            MaxToFirst();
        }
        static void MaxToFirst() {
            int[] ints = { 1, 8, 5, 6, 4, 3, 7, 8, 5, 1};
            int mi = 0;
            for (int i=0;i<ints.Length;i++) {
                if (ints[i] > mi) mi = i;
            }
            if (mi == 0) return;
            ints[0] += ints[mi];
            ints[mi] = ints[0] - ints[mi];
            for (int i = 0; i < ints.Length; i++) Console.Write(ints[i]+"; ");
        }
    }
}
