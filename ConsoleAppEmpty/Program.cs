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
        difficulty = (GameDifficulty)Enum.Parse(typeof(GameDifficulty), Console.ReadLine().ToLower().Trim(), true);
        string difficultyStr = "";

        CharacterClass characterClass = new CharacterClass();
        Console.WriteLine("Select a character class");
        foreach (var item in Enum.GetValues<CharacterClass>())
        {
            Console.WriteLine($"{(int)item}. {item}");
        }
        characterClass = (CharacterClass)Enum.Parse(typeof(CharacterClass), Console.ReadLine().ToLower().Trim(), true);
        string characterClassStr = "";

        if (difficulty == GameDifficulty.Easy)
        {
            difficultyStr = difficulty.ToString();
        }
        else if (difficulty == GameDifficulty.Medium)
        {
            difficultyStr = difficulty.ToString();
        }
        else if (difficulty == GameDifficulty.Hard)
        {
            difficultyStr = difficulty.ToString();
        }

        if (characterClass == CharacterClass.Warrior)
        {
            characterClassStr = characterClass.ToString();
        }
        else if (characterClass == CharacterClass.Mage)
        {
            characterClassStr = characterClass.ToString();
        }
        else if (characterClass == CharacterClass.Rogue)
        {
            characterClassStr = characterClass.ToString();
        }


        Console.WriteLine($"You selected:\nDifficulty: {difficultyStr}\nCharacter Class: {characterClassStr}");
    }
}