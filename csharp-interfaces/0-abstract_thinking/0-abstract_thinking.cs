using System;

/// <summary> base class </summary>
abstract class Base{
    /// <summary> name prop </summary>
    public string name {get; set;}
    /// <summary> overrides tostring method </summary>
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }
}
