namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleas enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Pleas enter the last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Pleas enter the salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n {firstName} {lastName} / {salary}");
        }
    }
}
