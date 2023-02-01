using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFirsrtLetterToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[5] { "bon", "don", "ron", "shaun", "mike" };

            int counter = 1;
            foreach (string friend in friends)
            {
                Console.WriteLine($"\tFriend Nr.{counter++}\n \t{char.ToUpper(friend[0]) + friend.Substring(1)} \n");
            }
        }
    }
}
