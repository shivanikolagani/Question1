namespace Question3
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(123);
            list.AddFirst(26);
            list.AddFirst(39);
            list.AddFirst(443);
            list.AddFirst(362);

            int num = list.Count;
            if (num % 2 == 0)
            {
                Console.WriteLine("There is no Middle element found");
            }
            else
            {
                int list1 = (num / 2) + 1;
                int c = 0;

                for (LinkedListNode<int> node = list.First; node != null; node = node.Next)
                {
                    c++;
                    if (c == list1)
                    {
                        Console.WriteLine(node.Value);
                    }


                }
            }
        }
    }
}
