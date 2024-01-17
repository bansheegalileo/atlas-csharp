﻿using System;

/// <summary> base class </summary>
public abstract class Base{
    /// <summary>name prop</summary>
    public string name {get; set;}
    /// <summary> overrides tostring </summary>
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }

     
}

/// <summary>interactive interface</summary>
public interface IInteractive{
    /// <summary> used for interactions</summary>
    void Interact();
}
/// <summary> ibreakable interface </summary>
public interface IBreakable{
    /// <summary> item durability </summary>
    /// <value> getter/setter </value>
    int durability { get; set; }
    /// <summary> break item </summary>
    void Break();
}
/// <summary> icollectable interface </summary>
public interface ICollectable{
    /// <summary> check if collected </summary>
    /// <value> get/set </value>
    bool isCollected { get; set; }
    /// <summary> collects </summary>
    void Collect();  
}

/// <summary> door class </summary>
public class Door : Base, IInteractive{
    /// <summary> default door constructor</summary>
    /// <param name="Name">default name dor, value cstr.</param>
    public Door(string Name="Door"){
        this.name = Name;
    }
     /// <summary> for interactions </summary>
    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
