namespace main.c_.uni.laboratory.labone 
    //if this doesn't work (and it probably won't) the original file is .../Cs stuffff/Carrrr.cs

{
    public class Car
    {
        private static string _colour = "red";
        private static string _state = "stationary";
        private static float _speed = 0;

        public void Details()
        {
            Console.WriteLine(Car._colour, Car._state, Car._speed);
        }

        public void Motion()
        {
            Car._speed = Convert.ToSingle(Console.ReadLine());
            if(Car._speed > 0)
            {
                Car._state = "moving";
            }
            if(Car._speed == 0)
            {
                Car._state = "stationary";
            }
            if(Car._speed < 0)
            {
                Console.WriteLine("That's not how reverse works...");
            }
        }
    }
}