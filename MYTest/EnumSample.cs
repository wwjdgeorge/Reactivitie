  
namespace MYTest
{
    //ctor
    //ctorf
    //ctorp
    public class EnumSample
    {
        public EnumSample()
        {
               
        }
        

        public void Get()
        {

            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Monday);
        }
    }
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

}
