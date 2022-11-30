using SafeApplication;
namespace SafeApplication
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Safe safe = new Safe(new Safe.Something());
        }
    }
}