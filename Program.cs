namespace ExtraCredit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take user input
            Console.Write("Enter the First Number: ");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            int SecondNumber = int.Parse(Console.ReadLine());

            // Choose the operation to be performed through user input
            Console.Write("Choose one operation to be performed from following list +, -, * and /: ");
            string operation = Console.ReadLine();

            double result;
            // Choose the arithmetic operation to be performed

            if (operation == "+")
            {
                result = FirstNumber + SecondNumber;
            }
            else if (operation == "-") 
            {
                result = FirstNumber - SecondNumber;
            }
            else if (operation == "*")
            {
                result = FirstNumber * SecondNumber;
            }

            else if(operation == "/")
            {
                result = FirstNumber / SecondNumber;
            }
            else
            {
                Console.WriteLine("Invalid operation selected.");
                return;
            }

            Console.WriteLine($"Result:{FirstNumber} {operation} {SecondNumber} = {result}");
        }
    }
}
