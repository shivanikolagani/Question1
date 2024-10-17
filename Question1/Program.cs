namespace Question1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringstack = new Stack<string>();
            stringstack.Push("Hello Welcome to My Code:");
            stringstack.Push("World ! ");
            stringstack.Push("My");
            stringstack.Push("to");
            stringstack.Push("Welcome");
            stringstack.Push("Hello");
            foreach (string word in stringstack)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Before Pop :");
            Console.WriteLine(stringstack.Peek());
            Console.WriteLine("Poping the element :");
            Console.WriteLine(stringstack.Pop());
            Console.WriteLine("After Pop :");
            Console.WriteLine(stringstack.Peek());
            Console.WriteLine("After Pop :");
            Console.WriteLine(stringstack.Pop());
        }
    }
}
