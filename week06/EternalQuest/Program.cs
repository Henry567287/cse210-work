using System;

/*
CREATIVITY
- Added leveling system (every 1000 points = level up)
- Displays user level
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}