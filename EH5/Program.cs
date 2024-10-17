namespace EH5
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(input);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error internally");
            }
        }
    }
}
