﻿using System.Runtime.InteropServices.JavaScript;

namespace main.c_.uni.laboratory.labtwo.Classes;

public class Student
{
    private static String localFirstName;
    private static String localLastName;
    private static String localEmail;
    private static DateTime localEnrolmentDate;
    private static DateTime localDateOfBirth;
    private static String ID;
    
    public String firstName;
    public String lastName;
    public String email;
    public DateTime enrolmentDate;
    public DateTime dateOfBirth;
    public bool outsidegGraduate = graduate;
    
    public String outsideID = ID;
    public static bool graduate = false;
    public static DateTime graduateDate;

    static void create_student()
    {
        int ans_check = 0;
        do
        {
            Console.WriteLine("You are now adding a new student. Want to proceed? y/n");
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
    }
    
    static void show_info()
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
        
    }

}