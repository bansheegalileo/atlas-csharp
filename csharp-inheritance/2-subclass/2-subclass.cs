using System;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary> checks if obj is a derived class</summary>
    /// <param name="derivedType">derived type to check</param>
    /// <param name="baseType">base class</param>
    /// <returns>true if subclass, false otherwise</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType){
        if (derivedType.IsSubclassOf(baseType)){
            return true;
        }
        return false;
    }
}
