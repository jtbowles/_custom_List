using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public static class UI
    {
        public static int GetListMenuResponse()
        {
            int userInput = 0;
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to your List Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter [1] to view your list");
            Console.WriteLine("  enter [2] to add to your list");
            Console.WriteLine("  enter [3] to remove from your list");
            Console.WriteLine("  enter [4] to quit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                GetListMenuResponse();
            }
            return userInput;
        }

        public static int GetListType()
        {
            int userInput = 0;
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("     What type of list are we making?");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter [1] for ints");
            Console.WriteLine("  enter [2] for strings");
            Console.WriteLine("  enter [3] for doubles");
            Console.WriteLine("  enter [4] to quit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                GetListMenuResponse();
            }
            return userInput;
        }
    }
}
