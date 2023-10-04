namespace main.c_.uni.laboratory.labtwo.Classes;

public class Faculty
{
    private static String name;
    private static String abbreviation;
    private static List<String> students;
    private static StudyField studyField;

    static void create_faculty()
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
    
    static void add_student(String stdID) 
    {
        try
        {
            students.Add(stdID);
        }
        catch (Exception e)
        {
            Console.WriteLine("Not a valid student ID");
            throw;
        }
    }

    static void list_students()
    {
        Student student = new Student();
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i] == student.outsideID && !student.outsidegGraduate)
            {
                Console.WriteLine($"{student.firstName} {student.lastName}");
            }
        }
    }
    
    static void list_graduates()
    {
        Student student = new Student();
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i] == student.outsideID && student.outsidegGraduate)
            {
                Console.WriteLine($"{student.firstName} {student.lastName}");
            }
        }
    }
}