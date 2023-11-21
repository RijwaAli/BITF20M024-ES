using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//task 4 example 1
namespace assignment_6
{
    // Product
    public class Product
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine(" Parts of product:");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }

    // Builder
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    // Concrete Builder
    public class Builder : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.AddPart("Part A");
        }

        public void BuildPartB()
        {
            product.AddPart("Part B");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    // Director
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    //example 2
    // Product
    public class HtmlDocument
    {
        private string content;

        public void AddContent(string text)
        {
            content += text;
        }

        public void Show()
        {
            Console.WriteLine("HTML Document:");
            Console.WriteLine(content);
        }
    }

    // Builder
    public interface IHtmlBuilder1
    {
        void BuildHeader(string headerText);
        void BuildParagraph(string paragraphText);
        HtmlDocument GetResult();
    }

    // Concrete Builder
    public class BasicHtmlBuilder : IHtmlBuilder1
    {
        private HtmlDocument htmlDocument = new HtmlDocument();

        public void BuildHeader(string headerText)
        {
            htmlDocument.AddContent($"<h1>{headerText}</h1>");
        }

        public void BuildParagraph(string paragraphText)
        {
            htmlDocument.AddContent($"<p>{paragraphText}</p>");
        }

        public HtmlDocument GetResult()
        {
            return htmlDocument;
        }
    }

    // Director
    public class HtmlDirector
    {
        public void Construct(IHtmlBuilder1 builder1)
        {
            builder1.BuildHeader("Builder Pattern Example");
            builder1.BuildParagraph("This is a simple example of the Builder pattern in C#.");
        }
    }

    

}
