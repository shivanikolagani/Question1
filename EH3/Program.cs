namespace EH3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 23, 54, 4, 45 };

            try
            {
                int res = arr[arr.Length + 1];
                Console.WriteLine(res);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
