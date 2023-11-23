using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// task 7
namespace Assignment_7
{
    //example 1
    interface IText
    {
        string Format();
    }
    class PlainText : IText
    {
        private readonly string content;

        public PlainText(string content)
        {
            this.content = content;
        }

        public string Format()
        {
            return content;
        }
    }

    // Decorator
    class BoldTextDecorator : IText
    {
        private readonly IText text;

        public BoldTextDecorator(IText text)
        {
            this.text = text;
        }
        public string Format()
        {
            return $"<b>{text.Format()}</b>";
        }
    }

    // example 2
    interface IText1
    {
        string Format();
    }
    class PlainText1 : IText1
    {
        private readonly string content;

        public PlainText1(string content)
        {
            this.content = content;
        }

        public string Format()
        {
            return content;
        }
    }

    // Decorator
    class BoldTextDecorator1 : IText1
    {
        private readonly IText text1;

        public BoldTextDecorator1(IText1 text_1)
        {
            this.text1 = text_1;
        }
        public string Format()
        {
            return $"<b>{text1.Format()}</b>";
        }
    }
}
