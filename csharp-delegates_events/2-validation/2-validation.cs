using System;

/// <summary>calculate damage</summary>
/// <param name="amount">Amount for health,</param>
public delegate void CalculateHealth(float amount);

/// <summary>player class</summary>
public class Player
{
    // name
    private string name { get; set; }
    // max hp
    private float maxHp { get; set; }
    // current hp
    private float hp { get; set; }
    /// <summary>player constructor</summary>
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
    /// <summary>take dmg</summary>
    /// <param name="damage">dmg amt</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }
    /// <summary>heal</summary>
    /// <param name="heal">amt healed</param>
    public void HealDamage(float heal){
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }
    /// <summary>define new hp</summary>
    /// <param name="newHp">sets new hp</param>
    public void ValidateHP(float newHp){
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }
}
