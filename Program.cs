public class Program
{
    public static void Main()
    {
        Random random = new Random();

        // Simulate a dice roll
        int diceRoll = random.Next(1, 7); // Generates random numbers between 1 and 6
        Console.WriteLine($"You rolled a {diceRoll}!");

        // Generate random enemy spawn location
        double x = random.NextDouble() * 100; // Random x-coordinate between 0 and 100
        double y = random.NextDouble() * 100; // Random y-coordinate between 0 and 100
        Console.WriteLine($"Enemy spawned at ({x}, {y}).");

        // Simulate loot drop chance
        double lootDropChance = random.NextDouble(); // Random chance between 0.0 and 1.0
        if (lootDropChance < 0.5)
        {
            Console.WriteLine("Loot dropped!");
        }
        else
        {
            Console.WriteLine("No loot this time.");
        }
    }
}