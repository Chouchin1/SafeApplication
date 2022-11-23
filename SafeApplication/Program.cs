using SafeApplication;

public class Program
{
    public static void Main(string[] args)
    {
        Safe safe = new Safe();
        safe.lockUnlockRand();
        safe.enterNum();
    }
}