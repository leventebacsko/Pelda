using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    public static class IntArrayExtensions
    {
        public static void Output(this int[] arr, string prefix) {
            arr.ToList().Output(prefix);
        }
        public static void Output(this List<int> arr, string prefix) {
            prefix += ": ";
            var listaString = new StringBuilder();
            foreach(var i in arr) {
                listaString.Append(
                    listaString.Length == 0 ? i.ToString() : ", " + i.ToString()
                );
            }
            Console.WriteLine(prefix + listaString.ToString());
        }
    }
}