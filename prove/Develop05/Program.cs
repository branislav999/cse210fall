using System;

class Program
{
    static void Main(string[] args)
    {
        Method _instance = new Method();
        bool _loop = true;

        while (_loop)
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
            int _choice = int.Parse(Console.ReadLine());

            switch (_choice)
            {
                case 1:
                    _instance.CreateNewGoal();
                    break;
                case 2:
                    _instance.ListGoals();
                    break;
                case 3:
                    _instance.Edit();
                    break;
                case 4:
                    _instance.Save();
                    break;
                case 5:
                    _instance.Load();
                    break;
                case 6:
                    _instance.RecordEvent();
                    break;
                case 7:
                    _loop = false;
                    break;
            }
        }
    }
}
