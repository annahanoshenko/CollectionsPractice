using System;
using System.Collections.Generic;
using System.Linq;

namespace StroreLine
{
    internal class Customer
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public int ItemsInCart { get; set; }

        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Items: {ItemsInCart}";
        }
    }
}
