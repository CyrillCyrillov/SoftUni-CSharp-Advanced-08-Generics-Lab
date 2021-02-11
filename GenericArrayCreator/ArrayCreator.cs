using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T defoult)
        {
            T[] array = new T[length];
            for (int i = 0; i <= length - 1; i++)
            {
                array[i] = defoult;
            }

            return array;
        }

    }
}
