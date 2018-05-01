using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using SupportTool.Models;

namespace SupportTool
{
    class Program
    {
        public static Appsettings Appsettings { get; set; }
        private static ProgramsEnum _chosenProgram;
        private static EnvironmentsEnum _chosenEnvironment;

        static void Main(string[] args)
        {
            WriteIntroduction();

            WriteChoiceOfProgram();

            WriteChoiceOfEnvironment();

            BuildConfiguration();

            StartWithChosenOptions();
        }

        private static void WriteIntroduction()
        {
            Console.WriteLine("Welcome to Support Tool !");
            Console.WriteLine("First set emails in input.csv file, this will be the emails you want to work with.");
            Console.WriteLine("Then follow the steps.");
            Console.WriteLine("");
        }

        private static void WriteChoiceOfProgram()
        {
            Console.WriteLine("# Which program you want to run (hit 1 for Program1)?");
            Console.WriteLine("1. Program 1\n2. Program 2\n3. Program 3\n4. Program 4\n5. Program 5\n6. Program 6\n7. Program 7\n8. Program 8\n9. Program 9\n10. Program 10");
            Console.Write("> Program: ");
            _chosenProgram = (ProgramsEnum)int.Parse(Console.ReadLine());

            if(!Enum.IsDefined(typeof(ProgramsEnum), _chosenProgram))
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, but the chosen program is not recognized.");
                WriteChoiceOfProgram();
            }
            else
            {
                Console.WriteLine("");
            }                  
        }

        private static void WriteChoiceOfEnvironment()
        {
            Console.WriteLine("# Which environment you want to work with (hit 1 for Dev)?");
            Console.WriteLine("1. Dev\n2. Uat\n3. Prod");
            Console.Write("> Environment: ");
            _chosenEnvironment = (EnvironmentsEnum)int.Parse(Console.ReadLine());

            if (!Enum.IsDefined(typeof(EnvironmentsEnum), _chosenEnvironment))
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, but the chosen environment is not recognized.");
                WriteChoiceOfEnvironment();
            }
            else
            {
                Console.WriteLine("");
            }
        }

        private static void StartWithChosenOptions()
        {
            Console.WriteLine($"=> You will now run {_chosenProgram} in {_chosenEnvironment}");
            Console.Write("\nPress any key to continue");
            Console.ReadKey(true);
        }

        private static void BuildConfiguration()
        {
            var environment = _chosenEnvironment.ToString().ToLower();

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.{environment}.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            Appsettings = new Appsettings();
            configuration.Bind(Appsettings);
        }
    }
}
