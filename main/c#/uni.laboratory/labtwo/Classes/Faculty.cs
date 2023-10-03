namespace main.c_.uni.laboratory.labtwo.Classes;

public class Faculty
{
    private static String name;
    private static String abbreviation;
    private static List<String> students;
    private static StudyField studyField;

    
    
    static void add_student(String stdID) // in process
    {
        students.Add(stdID);
    }

    static void list_students()
    {
        students.ForEach(i => Console.WriteLine("{0}\t", i)); // itll give only the id, mayyybe instead link their first and last names :'DDD
    }
}