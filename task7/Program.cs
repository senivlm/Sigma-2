namespace Shop
{
    public class Program
    {
        static void Main(string[] args)
        {

            Storage s = new Storage();
            s.ParseFromFile();
            Console.WriteLine(s.ToString());
            s.OutputLogs();
        }
    }
}