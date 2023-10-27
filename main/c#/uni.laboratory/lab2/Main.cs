using System.Threading.Tasks;
using main.c_.uni.laboratory.lab2;

namespace main.c_.uni.laboratory;

public class Lab2
{
    private static void Main(String[] args)
    {
        Check check = new Check();
        
        check.tracking_change(); 
        check.StartTimer();
        
    }
}
