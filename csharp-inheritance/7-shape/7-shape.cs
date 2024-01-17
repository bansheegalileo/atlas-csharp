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
    /// <summary>
    /// get: width
    /// set: if negative, throw arumentexception with msg width
    /// must be >= 0. set width to value otherwise
    /// </summary>
    /// <value>width type(int)</value>
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
    /// <summary>
    /// get: height
    /// set: if negative, throw arumentexception with msg height
    /// must be >= 0. set height to value otherwise
    /// </summary>
    /// <value>height type(int)</value>
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
    /// <summary> overrides area method in base shape</summary>
    /// <returns>area of rectangle</returns>
    public override int Area(){
        return this.height * this.width;
    }
    /// <summary> provides representation </summary>
    public override string ToString(){
        return String.Format("[Rectangle] {0} / {1}", this.width, this.height);
    }
}
