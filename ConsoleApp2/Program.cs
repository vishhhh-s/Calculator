namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию");
            string op = Console.ReadLine();

            Console.WriteLine("Введите 2 число");
            double b = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case "+":
                    Console.WriteLine(a+b);
                    break;
                case "-":
                    Console.WriteLine(a-b);
                    break;
                case "/":
                    if(b!=0)
                    Console.WriteLine(a/b);
                    else
                        Console.WriteLine("Ошибка");
                        break;
                case "*":
                    Console.WriteLine(a *b);
                    break;
                case "%":
                    Console.WriteLine(a%b);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}
