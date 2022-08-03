using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IExpression> expressions = new List<IExpression>();
            Context context = new Context(DateTime.Now);

            while(true)
            {
                Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY  or DD MM YY ");
                context.Expression = Console.ReadLine().ToUpper();
                string[] formats = context.Expression.Split(' ');

                foreach (var item in formats)
                {

                    switch (item)
                    {
                        case "YYYY":
                            expressions.Add(new YearExpression());
                            break;
                        case "MM":
                            expressions.Add(new MonthExpression());
                            break;
                        case "DD":
                            expressions.Add(new DayExpression());
                            break;
                        case "YY":
                            expressions.Add(new YearShortExpression());
                            break;
                    }

                }

                foreach (var item in expressions)
                {
                    item.Interpret(context);
                }

                Console.WriteLine(context.Expression);


            }

        }
    }
}
