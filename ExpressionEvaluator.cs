
namespace ExpressionEvaluator;

using ExpressionParser;
using MathExpression;
using MathOperation;

static public class App
{
    static public void Run()
    {
        Console.Write("Please Enter expression To Evaluate: ");
        string input = Console.ReadLine().Trim();

        MathExpression exp = ExpressionParser.Parse(input);

        Console.WriteLine($"{input} = {_EvaluateExpression(exp)}");
    }
    static private double EvaluateExpression (MathExpression expression)
    {
        switch (expression.Operation)
        {
            case MathOperation.Addition:
                return expression.LeftSideOperand + expression.RightSideOperand;
            case MathOperation.Subtraction:
                return expression.LeftSideOperand - expression.RightSideOperand;
            case MathOperation.Multiplication:
                return expression.LeftSideOperand * expression.RightSideOperand;
            case MathOperation.Division:
                return expression.LeftSideOperand / expression.RightSideOperand;
            case MathOperation.Modulus:
                return expression.LeftSideOperand % expression.RightSideOperand;
            case MathOperation.Power:
                return Math.Pow(expression.LeftSideOperand ,expression.RightSideOperand);
            case MathOperation.Sin:
                return Math.Sin((expression.RightSideOperand * Math.PI)/ 180);
            case MathOperation.Cos:
                return Math.Cos((expression.RightSideOperand * Math.PI) / 180);
            case MathOperation.Tan:
                return Math.Tan((expression.RightSideOperand * Math.PI) / 180);
            default:
                return 0;
            
        }

    }

}

