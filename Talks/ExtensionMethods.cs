using System;
using System.Collections.Generic;

namespace talks.Controllers
{
    public static class Extensions {

        public static String toBedrag(this int value) {
            return "€ " + value + ",-";
        }

        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action) {
            foreach(var item in items) {
                action(item);
            }
        }


    }
}
