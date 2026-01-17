using System;
using System.Collections.Generic;

class Character
{
    private string name;
    private int lives;
    private int level;

    // Informatie over de Karakter
    public Character(string nameInput, int livesInput, int levelInput)
    {
        name = nameInput;
        lives = livesInput;
        level = levelInput;
    }

    public void ShowStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Lives: " + lives);
        Console.WriteLine("Level: " + level);
    }


}

class Program
{
    static void Main(string[] args)
    {
        // Karakter wordt hier gemaakt.
        Character player1 = new Character("Speler1", 3, 5);
        Character player2 = new Character("Speler2", 2, 10);
        Character player3 = new Character("Speler3", 4, 15);

        List<Character> characters = new List<Character>();
        characters.Add(player1);
        characters.Add(player2);
        characters.Add(player3);


        // Voegt Character toe aan de lijst.
        for (int i = 0; i < characters.Count; i++)
        {
            characters[i].ShowStats();
        }

        // Print Karakter.
        // player1.ShowStats();
        // player2.ShowStats();
        // player3.ShowStats();
    }
}
