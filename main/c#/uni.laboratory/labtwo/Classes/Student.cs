using System.Runtime.InteropServices.JavaScript;
using System.Xml;

namespace main.c_.uni.laboratory.labtwo.Classes;

public class Student
{
    private static string localFirstName;
    private static string localLastName;
    private static string localEmail;
    private static DateTime localEnrolmentDate;
    private static DateTime localDateOfBirth;
    private static String ID;
    
    public String firstName = localFirstName;
    public String lastName = localLastName;
    public String email = localEmail;
    public DateTime enrolmentDate = localEnrolmentDate;
    public DateTime dateOfBirth = localDateOfBirth;
    public bool outsidegGraduate = graduate;
    public static List<Faculty>? enrollments;
    public List<Faculty> outsideEnrollment = enrollments;

    public String outsideID = ID;
    public static bool graduate = false;
    
    public static List<Faculty>? _facultyList;
    public static List<Student>? _studentList;


    public static void check_faculty_enroll()
    {
        Console.WriteLine("Enter student id>");
        string? id = Console.ReadLine();
        for (int i = 0; i < _studentList?.Count; i++)
        {
            if (_studentList[i].outsideID == id)
            {
                for (int j = 0; j < enrollments.Count; j++)
                {
                    Console.WriteLine($"{enrollments[j]}");
                }
            }
        }
        
    }
    public void create_student()
    {
        int ans_check = 0;
        do
        {
            Console.WriteLine("You are now adding a new student. Want to proceed? y/n");
            string answ = Console.ReadLine();
            switch (answ)
            {
                case "y":
                    ans_check = 0;
                    continue;
                case "n":
                    ans_check = 0;
                    return;
                default:
                    Console.WriteLine("Invalid answer.");
                    ans_check = 1;
                    break;
            }

        } while (ans_check == 1);
        
        Console.WriteLine("First Name>");
        localFirstName = Console.ReadLine();
        Console.WriteLine("Last name>");
        localLastName = Console.ReadLine();
        Console.WriteLine("Email>");
        localEmail = Console.ReadLine();
        
        Console.WriteLine("Date of birth>");
        string birthdate = Console.ReadLine();
        try
        {
            DateTime.TryParse(birthdate, out localDateOfBirth);
        }
        catch (Exception e)
        {
            Console.WriteLine($"{birthdate} is not a valid date string. Try again.");
            throw;
        }

        Console.WriteLine("Enrolment date (yyyy/mm/dd)>");
        string enrdate = Console.ReadLine();
        try
        {
            DateTime.TryParse(enrdate, out localEnrolmentDate);
        }
        catch (Exception e)
        {
            Console.WriteLine($"{enrdate} is not a valid date string. Try again.");
            throw;
        }
        
        Console.WriteLine("Student ID>");
        ID = Console.ReadLine();
        
        Console.WriteLine("Operation completed");
    }
    
    void show_info()
    {
        Console.WriteLine($"First name: {localFirstName}");
        Console.WriteLine($"Last name: {localLastName}");
        Console.WriteLine($"Date of birth: {localDateOfBirth}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Graduate: {graduate}");
        
    }
    
    void graduate_student()
    {
        graduate = true;
        Console.WriteLine("Operation completed");
    }

}