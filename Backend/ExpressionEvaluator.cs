using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Globalization; //To read decimal numbers with a point

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    private static string ToPostfix(string infix)
    {
        var postfix = string.Empty; //1. var posfix = string.Empty change varible name
        var stack = new Stack<char>();
        var number = string.Empty; //3. new line to accumulate each caracter for the same number
        foreach (var item in infix)
        {
            if (IsOperator(item))
            {
                if (number != string.Empty) // 4. Add the complete number to postfix
                {
                    postfix += number + " ";
                    number = string.Empty;
                }

                if (item == ')')
                {
                    var ope = stack.Pop();
                    while(ope != '(')
                    {
                        postfix += ope + " "; //6. operator will be separate from each operands
                        ope = stack.Pop();
                    }
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(item); 
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            postfix += stack.Pop() + " "; //7. change postfix += stack.Pop(); 
                            stack.Push(item);
                        }
                    }
                }
            }
            else
            {
                number += item; //3. number is a string so is necessary the change, for example: read "1"- 1, read "14" - 14, read "144"- 144 
            }
        }
        
        if (number != string.Empty) // 5. Add the last number. In case 12 + 35, 35 is the last number and will be in postfix too
        {
            postfix += number + " "; 
        }
        while (stack.Count != 0) // change do. Now Check the stack before Pop
        {
            postfix += stack.Pop() + " "; // 8. change postfix += stack.Pop(); 
        } 
        return postfix;
    }  
    

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();
        foreach (var item in postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries)) // 1. change  foreach (var item in postfix) to split postfix when find always an empty space
        {
            if (item.Length == 1 && IsOperator(item[0])) //2. change  if (IsOperator(item)) because now is a strind no a character
            {
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, item[0])); // 3. change  if (IsOperator(item)) because now is a strind no a character
            }
            else
            {
                stack.Push(double.Parse(item, CultureInfo.InvariantCulture));; // 4. change again double.parse convert the build text to number. InvarianCulture reads the point as a decimal separator
            }
        }
        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}
