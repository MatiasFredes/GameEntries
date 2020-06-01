using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Add an element to the array and shift elements to the right
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"> Array of T</param>
        /// <param name="element">Itm to add</param>
        /// <param name="position">Position</param>
        public static void InsertInto<T>(this T[] source, T element, int position)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (source.Length - 1 < position)
                throw new IndexOutOfRangeException();

            T temp = source[position];
            source[position] = element;
            int index = position + 1;

            while (index < source.Length)
            {
                T otherTemp = source[index];
                source[index] = temp;
                temp = otherTemp;
                index++;
            }
        }

        public static bool IsNullOrEmpty<T>(this T[] source)
        {
            return source == null || source.Count() == 0;
        }
    }

}
