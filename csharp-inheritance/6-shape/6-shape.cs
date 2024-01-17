using System;

/// <summary>base calss for shapes</summary>
class Shape
{
    /// <summary> not yet implemented</summary>
    /// <returns>int</returns>
    public virtual int Area(){
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary> rectangle derived from shape class </summary>
class Rectangle:Shape{
    private int width;
    private int height;
    public int Width{
        get{
            return width;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    public int Height{
        get{
            return height;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
}
