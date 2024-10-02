
public class TryCatch
{
    static void Main()
    {
        int a = 2;
        int b = 0;
        int c = a / b;
        try
        {
            Console.WriteLine("Value of c", c);
        }
        catch (Exception ex)
        {
            Console.WriteLine("exception is: ", ex.Message);
        }
    }
}

public class Tc
{
    //Just for testt
}
public class Tcc
{
    //Just for testt
}