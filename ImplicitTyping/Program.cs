using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            // When first initalised its data type can no longer be changed
            var firstName = "John";
            string lastName;

            var age = 15;
            int oldAge;

            var test = (string)null;
            // good way to make a string builder
            var sb = new StringBuilder();
        }
    }
}
