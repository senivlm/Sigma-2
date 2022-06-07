namespace Task_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            string startFile = "Start File.txt";
            string endFile = "End File.txt";
            TextProcessing textProcessing = new TextProcessing(startFile, endFile);
            textProcessing.EditTextAndFindWords();
        }
    }
}