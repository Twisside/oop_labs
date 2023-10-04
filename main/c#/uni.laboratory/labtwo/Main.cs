using System.Runtime.CompilerServices;
using main.c_.uni.laboratory.labtwo.Classes;

namespace main.c_.uni.laboratory.labtwo;

class Labtwo
{
    private static string entry;
    private static int switch_loop_brake = 0;
    private static string g_commands;
    private static int g_switch = 0;
    private static string f_commands;
    private static int f_switch = 0;
    private static string s_commands;
    private static int s_switch = 0;
    private static List<Faculty> facultyList;

    static void Main(String[] args) // im stupid, i don't know what i'm doing, i'm trying my best
    {
        Console.WriteLine("Welcome to the Student Manager!");
        Console.WriteLine("Here are the start commands:");
        Console.WriteLine("g - general operations");
        Console.WriteLine("f - faculty operations");
        Console.WriteLine("s - student operations");
        Console.WriteLine("q - quit program");
        Console.WriteLine("Type in 'help' to see command details.");



        while (entry != "q")
        {
            do
            {
                Console.Write("Your operation input>");
                entry = Console.ReadLine();
                switch (entry)
                {

                    case "g":
                        Console.WriteLine("Available general commands:");
                        Console.WriteLine(
                            "bk - back to previous choice"); // i have nothing to add yet --------------------
                        Console.WriteLine("cf - create faculty");
                        do
                        {
                            Console.Write("Your input>");
                            g_commands = Console.ReadLine();
                            switch (g_commands)
                            {
                                case "cf": // add commands
                                    Faculty faculty = new Faculty();
                                    facultyList.Add(faculty);
                                    faculty.create_faculty();
                                    break;
                                case "bk":
                                    continue;
                                default:
                                    Console.WriteLine("Invalid command. Try again.");
                                    g_switch = 1;
                                    break;
                            }
                        } while (g_switch == 1);

                        switch_loop_brake = 0;
                        break;

                    case "f":

                        Console.WriteLine("Available faculty commands:");
                        Console.WriteLine(
                            "bk - back to previous choice"); // i have nothing to add yet --------------------
                        do
                        {
                            Console.Write("Your input>");
                            f_commands = Console.ReadLine();
                            switch (f_commands)
                            {
                                case "": // add commands
                                    break;
                                case "bk":
                                    continue;
                                default:
                                    Console.WriteLine("Invalid command. Try again.");
                                    f_switch = 1;
                                    break;
                            }
                        } while (f_switch == 1);

                        switch_loop_brake = 0;
                        break;

                    case "s":
                        Console.WriteLine("Available student commands:");
                        Console.WriteLine(
                            "bk - back to previous choice"); // i have nothing to add yet --------------------
                        do
                        {
                            Console.Write("Your input>");
                            s_commands = Console.ReadLine();
                            switch (s_commands)
                            {
                                case "": // add commands
                                    break;
                                case "bk":
                                    continue;
                                default:
                                    Console.WriteLine("Invalid command. Try again.");
                                    s_switch = 1;
                                    break;
                            }
                        } while (s_switch == 1);

                        switch_loop_brake = 0;
                        break;
                    case "q":
                        switch_loop_brake = 0;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        switch_loop_brake = 1;
                        break;
                }
            } while (switch_loop_brake == 1);
        }
    }
}


       