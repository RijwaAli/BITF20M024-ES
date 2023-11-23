using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//task  2
namespace Assignment_7
{
    // Example 1
    abstract class Component
    {
        public abstract string Operation();
    }

    class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }
    }

    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public void Add(Component component)
        {
            children.Add(component);
        }

        public override string Operation()
        {
            List<string> results = new List<string>();
            foreach (var child in children)
            {
                results.Add(child.Operation());
            }
            return $"Composite: {string.Join(", ", results)}";
        }
    }

    // Example 2
    abstract class Graphic
    {
        public abstract string Draw();
    }

    class Circle : Graphic
    {
        public override string Draw()
        {
            return "Circle";
        }
    }

    class Square : Graphic
    {
        public override string Draw()
        {
            return "Square";
        }
    }

    class Picture : Graphic
    {
        private List<Graphic> graphics = new List<Graphic>();

        public void Add(Graphic graphic)
        {
            graphics.Add(graphic);
        }

        public override string Draw()
        {
            List<string> results = new List<string>();
            foreach (var graphic in graphics)
            {
                results.Add(graphic.Draw());
            }
            return $"Picture: {string.Join(", ", results)}";
        }
    }

       
   

}
