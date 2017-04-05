using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HelloMonkey.Helpers
{
    public static class EnumerableExtensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> self)
        {
            var col = new ObservableCollection<T>();
            col.AddRange(self);
            return col;
        }

        public static void AddRange<T>(this ObservableCollection<T> self, IEnumerable<T> itemsToAdd)
        {
            foreach (var item in itemsToAdd)
            {
                self.Add(item);
            }
        }
    }
}
