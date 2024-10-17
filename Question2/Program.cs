namespace Question2
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            Console.WriteLine("Enter the number of elements: ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the values: ");

            for (int i = 0; i < num; i++)
            {
                int values = int.Parse(Console.ReadLine());

                list.AddLast(values);
            }

            LinkedList<int> reverselist = new LinkedList<int>();

            foreach (int item in list)
            {
                reverselist.AddFirst(item);
            }
            Console.WriteLine("Reversed List");

            foreach (int item in reverselist)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
    }
}
