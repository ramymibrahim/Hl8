using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello World");
            //Primitive DataTypes
            /*
            short s1;
            ushort s2;
            int i1 = 32;
            uint i2 = 12;
            long l1;
            ulong l2;

            float f1;
            double d1;

            char c = 'a';

            bool isActive = true;

            //Value DataType
            string myName = "Ashraf"; // Array of characters
            char[] myNamechar =new char[] { 'A', 's', 'h', 'r', 'a', 'f' };
            char[] myNamechar2 = myNamechar;
            myNamechar2[1] = 'd';

            int x = 5;
            int y = x;
            y = 6;
            Console.Out.WriteLine(x);
            string myName2 = myName;
            myName2 = "Ezz";
            Console.Out.WriteLine(myName);
            Console.Out.WriteLine(myNamechar);
            */

            Console.Out.Write("Please enter your name: ");
            string myName = Console.In.ReadLine();
            Console.Out.Write("Please enter your age: ");
            string myAge = Console.In.ReadLine();

            Console.Out.WriteLine("Welcome ," + myName + " , you are " + myAge + " old");

            int myAgeInt;
            if (int.TryParse(myAge,out myAgeInt))
            {
                Console.Out.WriteLine(myAgeInt * 2);
            }
            string username = "Ezz";
            string password = "123";
            string command = "SELECT * FROM users WHERE username = '"+ username + "' and password ='"+password+"'";
            Console.Out.WriteLine(command);

            Console.In.ReadLine();
        }
    }
}
