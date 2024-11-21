using System;

class Program
{
    static void Main(string[] args)
    {
        Method instance = new Method();
        bool loop = true;

        while (loop)
        {
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Edit Goals");
            Console.WriteLine("   4. Save Goals");
            Console.WriteLine("   5. Load Goals");
            Console.WriteLine("   6. Record Event");
            Console.WriteLine("   7. Quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    instance.CreateNewGoal();
                    break;
                case 2:
                    instance.ListGoals();
                    break;
                case 3:
                    instance.Edit();
                    break;
                case 4:
                    instance.Save();
                    break;
                case 5:
                    instance.Load();
                    break;
                case 6:
                    instance.RecordEvent();
                    break;
                case 7:
                    loop = false;
                    break;
                
                
            }
        }
    }
}