using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExploringExpressions
{
    class Program
    {
        public static IEnumerable<int> Values = new[] { 1, 2, 3 };

        static void Main(string[] args)
        {
            var expression0 = Expression.Power(Expression.Constant(2.0), Expression.Constant(3.0));
            var expression = Expression.Add(expression0, Expression.Constant(2.0));
            var le = Expression.Lambda<Func<double>>(expression);

            Console.WriteLine(le.Compile()());
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static Expression GetExpression(int code, Expression left, Expression right)
        {
            switch (code)
            {
                case 0: return Expression.Add(left, right);
                case 1: return Expression.Subtract(left, right);
                case 2: return Expression.Multiply(left, right);
                case 3: return Expression.Divide(left, right);
                case 4: return Expression.Power(left, right);
            }
        }
    }
}
