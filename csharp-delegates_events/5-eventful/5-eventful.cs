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

/// <summary>evargs class for current hp</summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>current hp prop</summary>
    public float currentHp { get; }

    /// <summary>construct</summary>
    /// <param name="newHp">new hp</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
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

    /// <summary>ev handler for current hp check</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    // player status prop
    private string status { get; set; } = "Player is ready to go!";

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

        HPCheck += CheckStatus;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
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
    public void HealDamage(float heal)
    {
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
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp >= maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }

        OnCheckStatus(new CurrentHPArgs(hp));
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

    /// <summary>check/set status based on hp</summary>
    /// <param name="sender">event sender</param>
    /// <param name="e">current hp evargs</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float currentHp = e.currentHp;

        if (currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (currentHp >= maxHp / 2 && currentHp < maxHp)
        {
            status = $"{name} is doing well!";
        }
        else if (currentHp >= maxHp / 4 && currentHp < maxHp / 2)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (currentHp > 0 && currentHp < maxHp / 4)
        {
            status = $"{name} needs help!";
        }
        else if (currentHp == 0)
        {
            status = $"{name} is knocked out!";
        }

        Console.WriteLine(status);
    }

    /// <summary>check status and assign warning based on hp</summary>
    /// <param name="e">hp ev args</param>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else if (e.currentHp < maxHp / 4)
        {
            Console.WriteLine("Health is low!");
            HPCheck += HPValueWarning;
        }

        HPCheck?.Invoke(this, e);
    }

    /// <summary>handle hpvaluewarning</summary>
    /// <param name="sender">event send</param>
    /// <param name="e">current hpev args</param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }
}
