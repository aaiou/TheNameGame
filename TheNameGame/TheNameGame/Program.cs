using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name to start playing the name game!");
            var name = Console.ReadLine();

            Console.WriteLine("---------------------------------------");

            if (isVowel(name))
            {
                Console.WriteLine(name + ", " + name + " bo " + "B" + name.ToLower() + ",");
                Console.WriteLine("Bonana" + " fanna" + " fo " + "F" + name.ToLower() + ",");
                Console.WriteLine("Fee" + " fy" + " mo" + " M" + name.ToLower() + ",");
                Console.WriteLine(name + "!");
            }
            else
            {
                Console.WriteLine(name + ", " + name + " bo " + 'B' + name.Remove(0, 1) + ",");
                Console.WriteLine("Bonana" + " fanna" + " fo " + "F" + name.Remove(0, 1) + ",");
                Console.WriteLine("Fee" + " fy" + " mo" + " M" + name.Remove(0, 1) + ",");
                Console.WriteLine(name + "!");
            }

            System.Threading.Thread.Sleep(10000);  // Pause the program so we can sing along
        }

        /*
         *  Method to check if the first character in the name is a vowel
         */
        static bool isVowel(string a)
        {
            var lower = a.ToLower();

            if (lower[0] == 'a' || lower[0] == 'e' || lower[0] == 'i' || lower[0] == 'o' || lower[0] == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
