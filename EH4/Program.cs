namespace EH4
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = File.ReadAllText("retyuiytre");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Internal error");
            }
        }
    }
}
