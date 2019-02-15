using System;
using System.Collections.Generic;
using System.Text;

namespace AskGetConsole
{
    public static class ExtensionMethods
    {
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
    
    class ConsoleAsk
    {
        static public string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static public string Ask(int question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        static public int AskInt(string question)
        {
            try
            {
                Console.WriteLine(question);
                return Console.ReadLine().toInt();
            }
            catch (Exception)
            {
                throw new FormatException("Inputed value was not a number");
            }
        }
    }
}
