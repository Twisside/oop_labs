namespace main.c_.uni.laboratory.labtwo.Classes;

public class Student
{
    private static String firstName;
    private static String lastName;
    private static String email;
    private static DateTime enrolmentDate;
    private static DateTime dateOfBirth;

    private static string? ID;
    private static bool graduate;
    private static DateTime graduateDate;

    static void add_student()
    {
        // add entry to a file and all the rest operations will be using that file. it'll be a json most probably, or an enum
    }
    
    static void show_info()
    {
        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Date of birth: {dateOfBirth}");
        if (ID == null && graduate == false)
        {
            Console.WriteLine($"Email: Not a student yet");
            Console.WriteLine($"ID: Not a student yet");
            Console.WriteLine($"Enrolment date: Not a student yet");
        }
        else
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Graduate date: {graduateDate}");
        }
        
    }
    

}