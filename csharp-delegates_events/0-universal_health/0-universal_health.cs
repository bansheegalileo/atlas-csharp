using System;

/// <summary>player vclass</summary>
public class Player
{
    // name
    private string name {get; set;}
    // max hp
    private float maxHp {get; set;}
    // current hp
    private float hp {get; set;}
    /// <summary>
    /// player constructor
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="maxHp">max hp</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    /// <summary>prints current health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}