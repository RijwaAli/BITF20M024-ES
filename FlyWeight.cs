using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// task 4
namespace Assignment_7
{
    // Example 1
    interface IFlyweight
    {
        string Operation(string extrinsicState);
    }

    class ConcreteFlyweight : IFlyweight
    {
        public string Operation(string extrinsicState)
        {
            return $"ConcreteFlyweight: {extrinsicState}";
        }
    }

    class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights[key] = new ConcreteFlyweight();
            }
            return flyweights[key];
        }
    }

    // Example 2
    interface ISharedData
    {
        void Display(int x, int y);
    }

    // Concrete Flyweight
    class SharedData : ISharedData
    {
        private string data;

        public SharedData(string data)
        {
            this.data = data;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Displaying data: {data}, Position: ({x}, {y})");
        }
    }
    class FlyweightFactory1
    {
        private Dictionary<string, ISharedData> sharedData = new Dictionary<string, ISharedData>();

        public ISharedData GetSharedData(string key)
        {
            if (!sharedData.ContainsKey(key))
            {
                sharedData[key] = new SharedData(key);
            }
            return sharedData[key];
        }

    }
}