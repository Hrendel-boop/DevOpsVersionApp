
public class Program
{
    public static string GetVersion()
    {
        return typeof(Program).Assembly
            .GetName().Version?.ToString(3) ?? "1.0.0";
    }

    public static void Main()
    {
        Console.WriteLine("DevOps Version App");
        Console.WriteLine($"Version: {GetVersion()}");
        Console.WriteLine("Status: Success");
    }
}// Artifact test 233
