using System;

/// <summary>mod used with delegates</summary>
public enum Modifier
{
    /// <summary>weak default should be 0.5</summary>
    Weak,
    /// <summary>base default should be 1</summary>
    Base,
    /// <summary>strong default should be 1.5</summary>
    Strong
}
/// <summary>health calc</summary>
/// <param name="amount">amt </param>
public delegate void CalculateHealth(float amount);
/// <summary>calc mod delegate</summary>
/// <param name="baseValue">base val</param>
/// <param name="modifier">mod</param>
/// <returns>returns delegate</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
        if (newHp < 0){
            this.hp = 0;
        } else if (newHp >= maxHp){
            this.hp = maxHp;
        } else{
            this.hp = newHp;
        }
    }
    /// <summary>apply baseval based on mod</summary>
    /// <param name="baseValue">base value</param>
    /// <param name="modifier">mod</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float modifiedVal = baseValue;
        switch (modifier)
        {
            case Modifier.Weak:
                modifiedVal = baseValue * 0.5f;
                break;
            case Modifier.Base:
                modifiedVal = baseValue * 1f;
                break;
            case Modifier.Strong:
                modifiedVal = baseValue * 1.5f;
                break;
        }
        return modifiedVal;
    }
}
