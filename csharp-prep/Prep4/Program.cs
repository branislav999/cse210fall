using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> words = new List<string>();
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        // Console.Write(words.Count);

        // foreach (string word in words){
        //     Console.WriteLine(word);

        // for (int i = 0; i < words.Count; i++){
        //     Console.WriteLine(words[i]);


        List<int> numbers = new List<int>();

        bool number = false;
        int sum = 0;
        float average = 0;
        int max = 0;

        while (!number)
        {
            Console.Write("Type a number, enter 0 when done ");
            int input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
            else
            {
                number = true;
            }

        }
        // sum
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        // average
        average = ((float)sum) / numbers.Count;

        //highest

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is {sum} ");
        Console.WriteLine($"The average is {average} ");
        Console.WriteLine($"Highest number is {max} ");

    }


}