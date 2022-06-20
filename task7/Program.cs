namespace Shop
{
    public class Program
    {
        static void Main(string[] args)
        {//8 завдання не знайшла!

            Storage s = new Storage();
            s.ParseFromFile();
            Console.WriteLine(s.ToString());
            s.OutputLogs();
        }
    }
}
