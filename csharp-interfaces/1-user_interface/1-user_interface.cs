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
/// <summary> for test </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable{

    /// <summary>
    /// Used for item durability
    /// </summary>
    /// <value>Getter and setter</value>
    public int durability {get; set;}
    /// <summary> used to collect </summary>
    /// <value></value>
    public bool isCollected {get; set;}
    /// <summary> interaction </summary>
    public void Interact(){
        // mth imp
    }
    /// <summary> break </summary>
    public void Break(){
        // mth imp
    }

    /// <summary> collect </summary>
    public void Collect(){
        // mth imp
    }
}
