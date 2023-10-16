namespace main.c_.uni.laboratory.labtwo.Classes;

public class Faculty
{
    public string? name;
    public string? abbreviation;
    static List<Student> localStudents = new List<Student>();
    public List<Student> Students = localStudents;
    StudyField studyField;
    
    public static List<Faculty>? _facultyList = new List<Faculty>();

    public static void chech_student_belong()
    {
        int check = 1; 
        Console.WriteLine("Enter student id>");
        string? id = Console.ReadLine();
        Console.WriteLine("Enter faculty abbreviation>");
        string? abr = Console.ReadLine();
        for (int i = 0; i < Student._studentList?.Count; i++)
        {
            if (Student._studentList[i].outsideID == id)
            {
                for (int j = 0; j < _facultyList.Count; j++)
                {
                    if (_facultyList[j].abbreviation == abr)
                    {
                        for (int k = 0; k < localStudents.Count; k++)
                        {
                            if (id == localStudents[k].outsideID)
                            {
                                Console.WriteLine("Does belong");
                                check = 0;
                            }
                        }
                    }
                }
            }
        }

        if (check == 1)
        {
            Console.WriteLine("Student id or faculty abbreviation wrong or not yet existent");
            
        }
    }
    public void create_faculty()
    {
        int ans_check = 0;
        do
        {
            Console.WriteLine("You are now adding a new faculty. Want to proceed? y/n");
            string answ = Console.ReadLine();
            switch (answ)
            {
                case "y":
                    continue;
                case "n":
                    return;
                default:
                    Console.WriteLine("Invalid answer.");
                    ans_check = 1;
                    break;
            }

        } while (ans_check == 1);
        
        Console.WriteLine("Name>");
        name = Console.ReadLine();
        Console.WriteLine("abbreviation>");
        abbreviation = Console.ReadLine();
        
        // i still have no idea what the studyField is supposed to be
    }
    
    public static void add_student(string id) 
    {
        int check = 1;
        Console.WriteLine("Enter faculty abbreviation>");
        string? abr = Console.ReadLine();
        for (int i = 0; i < Student._studentList?.Count; i++)
        {
            if (Student._studentList[i].outsideID == id)
            {
                for (int j = 0; j < _facultyList?.Count; j++)
                {
                    if (_facultyList[j].abbreviation == abr)
                    {
                        _facultyList[j].Students.Add(Student._studentList[i]);
                        Student.enrollments.Add(_facultyList[j]);
                        check = 0;
                        //there definitely was a cleaner way
                    }
                }
            }
        }

        if (check == 1)
        {
            Console.WriteLine("Student id or faculty abbreviation wrong are not yet existent");
        }
        
        
    }

    public static void list_students()
    {
        int check = 1;
        Console.WriteLine("Enter faculty abbreviation>");
        string? abr = Console.ReadLine();
        for (int j = 0; j < _facultyList?.Count; j++)
        {
            if (_facultyList[j].abbreviation == abr)
            {
                for (int i = 0; i < localStudents.Count; i++)
                {
                    if (!localStudents[i].outsidegGraduate)
                    {
                        Console.WriteLine($"{localStudents[i].firstName} {localStudents[i].lastName}");
                        check = 0;
                    }
                }
            }
        }
        if (check == 1)
        {
            Console.WriteLine("Faculty abbreviation wrong are not yet existent");
        }
    }

    public static void list_graduates()
    {
        int check = 1;
        Console.WriteLine("Enter faculty abbreviation>");
        string? abr = Console.ReadLine();
        for (int j = 0; j < _facultyList?.Count; j++)
        {
            if (_facultyList[j].abbreviation == abr)
            {
                for (int i = 0; i < localStudents.Count; i++)
                {
                    if (localStudents[i].outsidegGraduate)
                    {
                        Console.WriteLine($"{localStudents[i].firstName} {localStudents[i].lastName}");
                        check = 0;
                    }
                }
            }
        }
        if (check == 1)
        {
            Console.WriteLine("Faculty abbreviation wrong are not yet existent");
        }
    }
}
