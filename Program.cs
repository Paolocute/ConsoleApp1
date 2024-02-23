namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line:");
            double grade  = Convert.ToDouble(Console.ReadLine());   
            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
                
            double total = (grade + grade1 + grade2 + grade3 + grade4 + grade4 ) / 5;
            double squareRoot = Math.Round(total);
            Console.WriteLine("the average is " + total + " and round off to " + squareRoot);
            Console.WriteLine("Press any key to exit...");






        }
    }
}