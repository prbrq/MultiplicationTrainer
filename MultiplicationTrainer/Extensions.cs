using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTrainer
{
    static class ListExtensions
    {
        static Random random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            for (var n = list.Count - 1; n > 1; n--)
            {
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
