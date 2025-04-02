namespace Personalregister
{
    internal class Program
    {

        static List<(string name, int salary)> employee = new List<(string, int)>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose 1 for add an employee");
                Console.WriteLine("Choose 2 to show list of employee");
                Console.WriteLine("Choose 3 to close");
                Console.WriteLine("Please, enter your choice");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    addEmployee();
                }
                else if (choice == "2")
                {
                    showList();
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }

        static void addEmployee()
        {
            Console.Write("enter the name: \n");
            string name = Console.ReadLine();
            Console.Write("enter the salary: \n");
            if (int.TryParse(Console.ReadLine(), out int salary))
            {
                employee.Add((name, salary));
                Console.WriteLine("Employee has been added");
            }
            else
            {
                Console.WriteLine("Invalid salary");
            }
        }

        static void showList()
        {
            for(int i = 0; i < employee.Count; i++)
            {
                Console.WriteLine($"Name: {employee[i].name}, Salary: {employee[i].salary}");
            }
        }
    }
}
