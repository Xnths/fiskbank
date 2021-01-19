using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Extention
{
    public static class ListExtention
    {
        public static void AddVariousItems<T>(this List<T> list, params T[] items)
        {
            foreach(T item in items)
            {
                list.Add(item);
            }
        }
    }
}
