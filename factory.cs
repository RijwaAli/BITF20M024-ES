using System;

namespace Assignment6
{
    // Example 1
    public interface IProduct
    {
        void Create();
    }

    public class ProductA : IProduct
    {
        public void Create()
        {
            Console.WriteLine("Product A created.");
        }
    }

    public class ProductB : IProduct
    {
        public void Create()
        {
            Console.WriteLine("Product B created.");
        }
    }

    public class Factory
    {
        public IProduct CreateProduct(string productType)
        {
            switch (productType)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }

    // Example 2
    public interface IProduct1
    {
        void Create();
    }

    public class ProductA1 : IProduct1
    {
        public void Create()
        {
            Console.WriteLine("Product A1 created.");
        }
    }

    public class ProductB1 : IProduct1
    {
        public void Create()
        {
            Console.WriteLine("Product B1 created.");
        }
    }

    public abstract class Creator
    {
        public abstract IProduct1 FactoryMethod();
    }

    public class CreatorA : Creator
    {
        public override IProduct1 FactoryMethod()
        {
            return new ProductA1();
        }
    }

    public class CreatorB : Creator
    {
        public override IProduct1 FactoryMethod()
        {
            return new ProductB1();
        }
    }

    
}
