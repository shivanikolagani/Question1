namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(21);
            list.AddFirst(22);
            list.AddFirst(23);
            list.AddFirst(24);
            list.AddFirst(25);

            Queue<int> queue = new Queue<int>(list);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
