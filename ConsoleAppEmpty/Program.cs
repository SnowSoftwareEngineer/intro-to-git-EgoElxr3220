using GameEnums;

public class Program
{
    static void Main(string[] args)
    {
        GameDifficulty difficulty = new GameDifficulty();
        Console.WriteLine("Select a difficulty");
        foreach (var item in Enum.GetValues<GameDifficulty>())
        {
            Console.WriteLine($"{(int)item}. {item}");
        }
        int response = int.Parse(Console.ReadLine().ToLower().Trim());
        CharacterClass characterClass = new CharacterClass();
        Console.WriteLine("Select a character class");
        foreach (var item in Enum.GetValues<CharacterClass>())
        {
            Console.WriteLine($"{(int)item}. {item}");
        }
        int response2 = int.Parse(Console.ReadLine().ToLower().Trim());



        Console.WriteLine( + "\n" + );
        //Console.WriteLine($"You selected:\nDifficulty:");
    }
}