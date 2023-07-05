namespace SimpleMethod

    /*This example gives me a basic understanding of how to create and call a method,
     * while also using the concept of inheritence.*/
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Console.ReadLine();
        }
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World! This is a helper method being accessed within the same class.");
        }
    }
    public class ChildProgram : Program
    {
        public static void Main(string[] args)
        {

        }
    }
}