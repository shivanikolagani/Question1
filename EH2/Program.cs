namespace EH2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            try
            {
                int result = s1.Length;
                Console.WriteLine(result);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
