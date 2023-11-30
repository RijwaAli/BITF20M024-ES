using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }
    }

    // AbstractExpression
    interface IExpression
    {
        void Interpret(Context context);
    }


    class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Output = int.Parse(context.Input);
        }
    }


    class NonterminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Output = context.Output * context.Output;
        }
    }

    class Client
    {
        private List<IExpression> expressions = new List<IExpression>();

        public void Interpret(Context context)
        {
            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }
        }

        public void AddExpression(IExpression expression)
        {
            expressions.Add(expression);
        }
    }
}
