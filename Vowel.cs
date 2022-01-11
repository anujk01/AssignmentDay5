using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Vowel
    {
        public void VowelOrConstant()
        {
            Console.WriteLine("enter any alphabet");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("alphabet is vowel");
            }
            else
            {
                Console.WriteLine("alphabet is constant");
            }
        }
    }
}