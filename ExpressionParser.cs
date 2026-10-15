namespace ExpressionParser;


using MathOperation;
using MathExpression;

public class ExpressionParser
{

    static private readonly string _mathSymbol = "+*/%^";

    static public MathExpression Parse (string input)
    {
        var expression = new MathExpression();

        string token = "";

        bool isLeftSideIntialized = false;

        for (int i = 0; i < input.Length; ++i)
        {

            char Current = input[i];

            if (char.IsDigit(Current) || Current == '.' || input[i] == '-' && i == 0)
            {
                token += input[i];

            }
            
            else if (_MathSymbol.Contains(input[i]))
            {
                if (!isLeftSideIntialized)
                {
                    expression.LeftSideOperand = double.Parse(token);
                    isLeftSideIntialized = true;
                }

                expression.Operation = ParseMathOperation(input[i].ToString());
                token = "";

            }

            else if (input[i] == '-' && i > 0)
            {
                if (!isLeftSideIntialized)
                {
                    if (!string.IsNullOrEmpty(token))
                    {
                        expression.LeftSideOperand = double.Parse(token);
                        isLeftSideIntialized = true;
                        token = "";
                    }
                    
                }

                else if (expression.Operation == MathOperation.none)
                {
                    expression.Operation = ParseMathOperation(input[i].ToString());
                    token = "";
                }

                else
                {
                    token += input[i];
                }

            }

            else if (char.IsLetter(input[i]))
            {
                token += input[i]; 
            }

            else if (input[i] == ' ')
            {
                var operation = ParseMathOperation(token);

                if (!isLeftSideIntialized && !string.IsNullOrEmpty(token) && operation == MathOperation.none)
                {
                    expression.LeftSideOperand = double.Parse(token);
                    isLeftSideIntialized = true;
                    token = "";
                }

                
                else if (expression.Operation == MathOperation.none &&!string.IsNullOrEmpty(token) && operation != MathOperation.none)
                {
                    expression.Operation = ParseMathOperation(token);
                    token = "";
                }
               
            }

        }

        if (!string.IsNullOrEmpty(token))
        {
            
           expression.RightSideOperand = double.Parse(token);
 
        }

        return expression;

    }

    static public MathOperation ParseMathOperation(string operation)
    {

       
        switch (operation.ToLower())
        {
            case "+":
                return MathOperation.Addition;
            case "-":
                return MathOperation.Subtraction;
            case "*":
                return MathOperation.Multiplication;
            case "/":
                return MathOperation.Division;
            case "^":
            case "pow":
                return MathOperation.Power;
            case "%":
            case "mod":
                return MathOperation.Modulus;
            case "sin":
                return MathOperation.Sin;
            case "cos":
                return MathOperation.Cos;
            case "tan":
                return MathOperation.Tan;
            default:
                return MathOperation.none;

        }

    }



}
