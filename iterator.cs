using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    // Aggregate
    interface IAggregate
    {
        IIterator CreateIterator();
    }

    class ConcreteAggregate : IAggregate
    {
        private ArrayList items = new ArrayList();

        public void AddItem(object item)
        {
            items.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
        }
    }
    interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
    class ConcreteIterator : IIterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object First()
        {
            return aggregate[0];
        }

        public object Next()
        {
            object result = null;
            if (current < aggregate.Count - 1)
            {
                result = aggregate[++current];
            }
            return result;
        }
        public bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
