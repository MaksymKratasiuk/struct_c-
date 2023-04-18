namespace struct_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number 1 - 3 0 - exit");
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Task1.task1();
                        break;
                    case 2:
                        Task2.task2();
                        break;
                    case 3:
                        Task3.task3();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("there`s no such task");
                        break;
                }


            }


        }
    }
}