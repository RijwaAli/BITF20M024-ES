using System;

// Prototype interface
public interface ICloneable
{
    ICloneable Clone();
}

// Concrete prototype class
public class ConcretePrototype : ICloneable
{
    public int Id { get; set; }

    public ConcretePrototype(int id)
    {
        Id = id;
    }

    public ICloneable Clone()
    {
        // Shallow copy
        return (ICloneable)MemberwiseClone();
    }



    using System;
using System.Collections.Generic;

// Prototype interface
public interface IDeepCloneable<T>
{
    T DeepClone();
}

// Concrete prototype class with complex data structure
public class ComplexObject : IDeepCloneable<ComplexObject>
{
    public int Id { get; set; }
    public List<string> Data { get; set; }

    public ComplexObject(int id, List<string> data)
    {
        Id = id;
        Data = data;
    }

    public ComplexObject DeepClone()
    {
        // Deep copy
        return new ComplexObject(Id, new List<string>(Data));
    }
}

}
