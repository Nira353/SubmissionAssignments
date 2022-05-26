using System;

namespace AssignmentGP03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = Square(num);
            Console.WriteLine("result square " + result);
            result = Factorial(num);
            Console.WriteLine("result factorial " + result);

            Console.WriteLine("\nWrite a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nand its exponent: ");
            int exp = Convert.ToInt32(Console.ReadLine());

            result = Power(num, exp);
            Console.WriteLine("result: " + result);

            Console.WriteLine("\nWrite something!\n");
            string String = Console.ReadLine();

            bool palind = PalindromeFinder(String);
            Console.WriteLine("this " + String + " is " + palind);

            string comp = CompressString(String);
            Console.WriteLine("compressed string is " + comp);

            int Square(int _value)
            {
                int s;
                s = _value * _value;

                return s;
            }

            int Power(int _value, int _power)
            {
                int r = 1;
                int i = 0;

                while (i < _power)
                {
                    r *= _value;
                }

                return r;
            }

            string CompressString(string _text)
            {
                string compressed = "";
                char controlChar;
                int counter = 0;

                while (_text != string.Empty)
                {
                    controlChar = _text[0];

                    foreach(char ch in _text)
                    {
                        if(controlChar == ch)
                        {
                            counter++;
                            _text = _text.Replace(ch.ToString(), String.Empty);
                        }
                    }

                    compressed += counter.ToString();
                    compressed += controlChar;

                    counter = 0;
                }

                return compressed;
            }

            bool PalindromeFinder(string _text)
            {
                int lenght = _text.Length - 1;

                foreach(char ch in String)
                {
                    if (ch != String[lenght] || lenght < 0) return false;
                    lenght--;
                }

                return true;
            }

            int Factorial(int _value)
            {
                int factorial = 0;

                while (_value > 0)
                {
                    factorial += _value;
                    _value--;
                }

                return factorial;
            }
        }
    }
}
