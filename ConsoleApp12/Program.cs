using System;

class Program
{
    static void Main()
    {
        List<Action> actions = new List<Action>();

        for (int i = 1; i <= 5; i++)
        {
            int copy = i;
            actions.Add(() => Console.WriteLine(copy));
        }

        foreach (var action in actions)
        {
            action();
        }
    }
}