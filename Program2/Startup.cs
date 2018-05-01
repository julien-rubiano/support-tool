using System;

namespace Program2
{
    public class Startup
    {
        public static void Run()
        {
            WriteParameters();
        }

        private static void WriteParameters()
        {
            Console.WriteLine("You can run this program by using following options:");
            Console.WriteLine("-param1 : used to do a nice stuff");
            Console.WriteLine("-param2 : used to do something different");
            Console.WriteLine("-param2 : used to do the magical thing");
            Console.WriteLine("Write -param1=value -param2=value -param3=value");
            Console.Write("> run program with options: ");
        }
    }
}
