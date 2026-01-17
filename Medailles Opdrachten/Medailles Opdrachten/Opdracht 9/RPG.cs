using System;
using System.Collections.Generic;

class Weapon
{
 
    private string name;
    private int damage;
    private string type;

    public Weapon(string nameInput, int damageInput, string typeInput) { 
        name = nameInput;
        damage = damageInput;
        type = typeInput;
    }

    public void ShowStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Damage: " + damage);
    }

    // This should increase the weapon's damage
    public void UpgradeItem(int damageToAdd)
    {
        // Increases Damage by damageToAdd
        damage = damage + damageToAdd;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Weapon firstWeapon = new Weapon("Daggers", 5, "Short Knife");
        firstWeapon.ShowStats();

        Console.WriteLine();

        Weapon secondWeapon = new Weapon("Longbow", 15, "Bow");
        Weapon thirdWeapon = new Weapon("Long Spear", 20, "Spear");
        Weapon fourthWeapon = new Weapon("Katana", 15, "Sword");

        // Weapon List
        List<Weapon> weapons = new List<Weapon> { firstWeapon, secondWeapon, thirdWeapon, fourthWeapon };

        // Show All Weapons.
        foreach (Weapon weaponName in weapons)
        {
            weaponName.ShowStats();
            weaponName.UpgradeItem(5);
        }

        Console.WriteLine("\n--- Upgrading Weapons ---\n");

        // Show all weapons again after upgrades
        foreach (Weapon weaponName in weapons)
        {
            weaponName.ShowStats();
        }
    }
}
