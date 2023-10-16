using main.c_.uni.laboratory.labtwo.Classes;

namespace main.c_.uni.laboratory.labtwo;

class Labtwo
{
    private static string? _entry;
    private static int _switchLoopBrake;
    private static string? _gCommands;
    private static int _gSwitch;
    private static string? _fCommands;
    private static int _fSwitch;
    private static string? _sCommands;
    private static int _sSwitch;
    

    static void Main(String[] args) // im stupid, i don't know what i'm doing, i'm trying my best
    {
        
        Console.WriteLine("Welcome to the Student Manager!");
        Console.WriteLine("Here are the start commands:");
        Console.WriteLine("");
        
        while (_entry != "q")
        {
            Console.WriteLine("g - general operations");
            Console.WriteLine("f - faculty operations");
            Console.WriteLine("q - quit program");
            Console.WriteLine("");
            
            do
            {
                Console.Write("Your operation input>");
                _entry = Console.ReadLine();
                switch (_entry)
                {

                    case "g":
                        Console.WriteLine("Available general commands:");
                        Console.WriteLine("bk - back to previous choice");
                        Console.WriteLine("cf - create faculty");
                        Console.WriteLine("ssf - search faculty that the student belongs to");
                        Console.WriteLine("uf - display university faculties");
                        do
                        {
                            Console.Write("Your input>");
                            _gCommands = Console.ReadLine();
                            switch (_gCommands)
                            {
                                case "cf":
                                    Faculty faculty = new Faculty();
                                    faculty.create_faculty();
                                    Faculty._facultyList?.Add(faculty);
                                    _gSwitch = 0;
                                    break;
                                case "ssf":
                                    Student.check_faculty_enroll();
                                    _gSwitch = 0;
                                    break;
                                case "uf":
                                    for (int i = 0; i < Faculty._facultyList?.Count; i++)
                                    {
                                        Console.WriteLine($"{Faculty._facultyList[i].name}");
                                    }
                                    _gSwitch = 0;
                                    break;
                                case "gs":
                                    Console.WriteLine("student id>");
                                    string input = Console.ReadLine();

                                    Student.graduate_student(input);
                                    _gSwitch = 0;
                                    break;
                                case "bk":
                                    _gSwitch = 0;
                                    continue;
                                default:
                                    Console.WriteLine("Invalid command. Try again.");
                                    _gSwitch = 1;
                                    break;
                            }
                        } while (_gSwitch == 1);

                        _switchLoopBrake = 0;
                        break;

                    case "f":

                        Console.WriteLine("Available faculty commands:");
                        Console.WriteLine("bk - back to previous choice");
                        Console.WriteLine("as - add student and add to faculty");
                        Console.WriteLine("de - display enrolled students");
                        Console.WriteLine("dg - display graduated students");
                        Console.WriteLine("btf - tell if a student belongs to faculty");
                        
                        do
                        {
                            Console.Write("Your input>");
                            _fCommands = Console.ReadLine();
                            switch (_fCommands)
                            {
                                case "as":
                                    Student student = new Student();
                                    student.create_student();
                                    Student._studentList?.Add(student);
                                    Faculty.add_student(student.outsideID);
                                        _fSwitch = 0;
                                    break;
                                case "de":
                                    Faculty.list_students();
                                    _fSwitch = 0;
                                    break;
                                case "dg":
                                    Faculty.list_graduates();
                                    _fSwitch = 0;
                                    break;
                                case "btf":
                                    Faculty.chech_student_belong();
                                    _fSwitch = 0;
                                    break;
                                case "bk":
                                    _fSwitch = 0;
                                    continue;
                                default:
                                    Console.WriteLine("Invalid command. Try again.");
                                    _fSwitch = 1;
                                    break;
                            }
                        } while (_fSwitch == 1);

                        _switchLoopBrake = 0;
                        break;
                    
                    case "q":
                        _switchLoopBrake = 0;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        _switchLoopBrake = 1;
                        break;
                }
            } while (_switchLoopBrake == 1);
        }
    }
}


       