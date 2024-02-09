using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace equation_training
{
    internal class Program
    {
        static byte StartMenu()
        {
            byte selection = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n");
                switch (selection)
                {
                    case 0:
                        Console.WriteLine("\t\t\t\t=== Start ===");
                        Console.WriteLine("\t\t\t\t    Setting");
                        Console.WriteLine("\t\t\t\t    Exit");
                        break;
                    case 1:
                        Console.WriteLine("\t\t\t\t    Start");
                        Console.WriteLine("\t\t\t\t=== Setting ===");
                        Console.WriteLine("\t\t\t\t    Exit");
                        break;
                    case 2:
                        Console.WriteLine("\t\t\t\t    Start");
                        Console.WriteLine("\t\t\t\t    Setting");
                        Console.WriteLine("\t\t\t\t=== Exit ===");
                        break;
                }

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    return selection;
                }

                if (key.Key == ConsoleKey.UpArrow && selection > 0)
                {
                    selection--;
                }
                if (key.Key == ConsoleKey.DownArrow && selection < 2)
                {
                    selection++;
                }
            }
        }
        static void SettingMenu()
        {
            return;
        }
        static void MainMenu()
        {
            return;
        }


        static void Main(string[] args)
        {
            var menu1 = StartMenu();
            switch (menu1)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    SettingMenu();
                    break;
                case 2:
                    return;
            }
        }
    }
}
