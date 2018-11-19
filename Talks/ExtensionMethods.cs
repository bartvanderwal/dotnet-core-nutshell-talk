using System;
using System.Collections.Generic;

namespace talks
{
    public static class Extensions {

        public static String toBedrag(this int value) {
            return "€ " + value + ",-";
        }

        public static void ForEach(this IList<Talk> items, Action<Talk> action) {
            foreach(var item in items) {
                action(item);
            }
        }


    }
}
