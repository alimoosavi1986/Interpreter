using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public interface IExpression
    {
        string Interpret(Context context);
    }



    public class YearExpression : IExpression
    {
        public string Interpret(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
            return context.Expression;
        }
    }

    public class MonthExpression : IExpression
    {
        public string Interpret(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
            return context.Expression;
        }
    }

    public class DayExpression : IExpression
    {
        public string Interpret(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Year.ToString());
            return context.Expression;
        }
    }

    public class YearShortExpression : IExpression
    {
        public string Interpret(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YY", context.Date.Year.ToString().Substring(2, 2));
            return context.Expression;
        }
    }

    class SeparatorExpression : IExpression
    {
        public string Interpret(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
            return context.Expression;
        }

    }

}
