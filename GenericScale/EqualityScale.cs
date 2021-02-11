using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale
    {
        public static bool AreEqual<T>(T left, T right)
        {
            bool result = false;
            if(left.Equals(right))
            {
                result = true;
            }

            return result;
        }

    }
}
