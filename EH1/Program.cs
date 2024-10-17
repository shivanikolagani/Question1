namespace EH1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the input1:");
                int input1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the input2 :");
                int input2 = int.Parse(Console.ReadLine());

                int input3 = input1 / input2;
                Console.WriteLine(input3);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("provide a integer number which is divided by zero");
            }
        }
    }
}
