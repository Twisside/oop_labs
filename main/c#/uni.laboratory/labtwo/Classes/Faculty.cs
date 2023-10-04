using System.Reflection.PortableExecutable;

namespace main.c_.uni.laboratory.labtwo.Classes;

public class Faculty
{
    String name;
    String abbreviation;
    private static List<Student> localStudents;
    StudyField studyField;

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
    
    void add_student(Student student) 
    {
        localStudents.Add(student);
        student.enrollments.Add(this);
        
    }

    void list_students() 
    {
        for (int i = 0; i < localStudents.Count; i++)
        {
            if (!localStudents[i].outsidegGraduate)
            {
                Console.WriteLine($"{localStudents[i].firstName} {localStudents[i].lastName}");
            }
        }
    }
    
    void list_graduates()
    {
        for (int i = 0; i < localStudents.Count; i++)
        {
            if (!localStudents[i].outsidegGraduate)
            {
                Console.WriteLine($"{localStudents[i].firstName} {localStudents[i].lastName}");
            }
        }
    }
}