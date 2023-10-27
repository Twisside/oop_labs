
using main.c_.uni.laboratory.lab2;

namespace main.c_.uni.laboratory;

public class Lab2
{
    private static void Main(String[] args)
    {
        Check check = new Check();
        Timerr timer = new Timerr();
        
        Thread thread = new Thread(timer.live_tracking_change);
        thread.Start();
        check.tracking_change(); 
        
        
    }
}
