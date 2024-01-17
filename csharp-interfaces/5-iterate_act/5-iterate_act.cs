﻿using System;
using System.Collections.Generic;

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
/// <summary> decor class </summary>
public class Decoration : Base, IInteractive, IBreakable{
    /// <summary> item durability </summary>
    /// <value>getset</value>
    public int durability { get; set; }
    /// <summary> is qi boolean</summary>
    public bool isQuestItem;
    /// <summary> decoration cstr. </summary>
    /// <param name="name">dec name</param>
    /// <param name="durability">dec durab.</param>
    /// <param name="isQuestItem">qi or not</param>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false){
        if (durability <= 0){
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    /// <summary> interactions </summary>
    public void Interact(){
        if (durability <= 0){
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem){
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        } else{
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
    /// <summary> for broken iem</summary>
    public void Break(){
        durability -= 1;
        if (durability > 0){
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability == 0){
            Console.WriteLine($"You smash the {name}. What a mess.");
        } else{
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary> key class</summary>
public class Key : Base, ICollectable{
    /// <summary>collecyed or nah</summary>
    /// <value>getset radio</value>
    public bool isCollected { get; set; }
    /// <summary>default constructor</summary>
    /// <param name="name">key name</param>
    /// <param name="isCollected">collect check</param>
    public Key(string name="Key", bool isCollected=false){
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary> collect key </summary>
    public void Collect(){
        if (!isCollected){
            Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
        } else{
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
/// <summary> roomobjs class </summary>
public class RoomObjects{
    /// <summary> iterate based on implementation</summary>
    /// <param name="roomObjects">all room objs</param>
    /// <param name="type">obj type</param>
    public static void IterateAction(List<Base> roomObjects, Type type){
        foreach(var elem in roomObjects){
            switch(type.ToString()){
                case "IInteractive":
                    if (elem is IInteractive){
                        IInteractive instance = (IInteractive)elem;
                        instance.Interact();
                    }
                    break;
                case "IBreakable":
                    if (elem is IBreakable){
                        IBreakable instance = (IBreakable)elem;
                        instance.Break();
                    }
                    break;
                case "ICollectable":
                    if (elem is ICollectable){
                        ICollectable instance = (ICollectable)elem;
                        instance.Collect();
                    }
                    break;
                default:
                    break;
            }
        }
    
    }
}
