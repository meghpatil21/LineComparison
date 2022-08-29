namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program.");
            Console.WriteLine();

            Console.WriteLine("Select option from following: \n1.Lengh of Line");
            int option=Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    LenghOfLine.LineLength();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}