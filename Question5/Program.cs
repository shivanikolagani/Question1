namespace Question5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sortedlist");
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddFirst(5);
            list1.AddFirst(2);
            list1.AddFirst(6);
            list1.AddFirst(4);
            list1.AddFirst(7);

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddFirst(10);
            list2.AddFirst(20);
            list2.AddFirst(30);
            list2.AddFirst(40);

            LinkedList<int> sortedlist = new LinkedList<int>();

            foreach (int num in list1)
            {
                sortedlist.AddFirst(num);
            }
            foreach (int num in list2)
            {
                sortedlist.AddFirst(num);
            }
            foreach (int num in sortedlist.Order())
            {
                Console.WriteLine(num);
            }
        }
    }
}
