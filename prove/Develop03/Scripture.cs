using System;


public class Scripture
{
    private List<string> scripturelist;

    public List<string> WordList(string scripture)
    {
        List<string> words = new List<string>();
        string[] list = scripture.Split(' ');

        for (int i = 0; i < list.Length; i++)
        {
            string word = list[i];
            words.Add(word);
        }

        return words;
    }

    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines("scripture.csv");

        Reference reference = new Reference();

        Random random = new Random();
        int randomIndex = random.Next(0, lines.Length);

        string randomPair = lines[randomIndex];
        string[] parts = randomPair.Split("~");

        reference.SetReference(parts[0]);
        Console.WriteLine(reference.GetReference());
        string scripture = parts[1];

        scripturelist = WordList(scripture);
    }

    public void Display()
    {
        foreach (string word in scripturelist)
        {
            Console.Write($"{word} ");
        }
    }

    public void HideWords()
    {
            Random random = new Random();

        int index;

        do
        {
            index = random.Next(0, scripturelist.Count);
        } 
        while (scripturelist[index] == new string('_', scripturelist[index].Length));


        scripturelist[index] = new string('_', scripturelist[index].Length);
    }
 
    public bool IsCompletelyHidden()
    {
        return scripturelist.All(word => word.All(letter => letter == '_'));
    }



}