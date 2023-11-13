
using main.c_.uni.laboratory.lab2;

namespace main.c_.uni.laboratory;

public class Lab2
{
    private static void Main2(String[] args)
    {
        Check check = new Check();
        Timer timer = new Timer();
        
        Thread thread = new Thread(timer.tracking_change);
        thread.Start();
        check.tracking_change();
    }
}
