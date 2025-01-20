namespace Lesson10Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputUsers = Console.ReadLine();
            try
            {
                if (inputUsers.Contains('!') || inputUsers.Contains('?') || inputUsers.Contains(':'))
                {
                    throw new ArgumentException("Недопустимый символ");
                }
                else
                {
                    Console.WriteLine(inputUsers);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Обнаружен запрещённый символ");
            }
            Console.ReadKey();
        }
    }
}
