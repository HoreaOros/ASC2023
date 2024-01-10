using System.Runtime.InteropServices;

string exp = "( 12 + 2 ) * 3 - 4 / ( 5  - 6 / 2 )";

Console.WriteLine($"{eval(exp)}");

int eval(string exp)
{
    string rpn = ReversePolishNotation("( " + exp + " )");
    Console.WriteLine(rpn);
    return EvalRPN(rpn);
}

//12 2 + 3 * 4 5 6 2 / - / -
int EvalRPN(string rpn)
{
    Stack<int> stack = new Stack<int>();
    string[] tokens = rpn.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach(string token in tokens)
    {
        if(IsOperator(token))
        {
            int opR = stack.Pop();
            int opL = stack.Pop();
            stack.Push(ApplyOperator(token, opL, opR));
        }
        else
            stack.Push(int.Parse(token));
    }
    return stack.Pop();
}

int ApplyOperator(string token, int opL, int opR)
{
    int result = 0;
    switch(token)
    {
        case "+":
            result = opL + opR;
            break;
        case "-":
            result = opL - opR;
            break;
        case "*":
            result = opL * opR;
            break;
        case "/":
            result = opL / opR;
            break;
        case "%":
            result = opL % opR;
            break;
    }
    return result;
}

int Priority(string op)
{
    Dictionary<string, int> priorities = new Dictionary<string, int>() { 
        ["+"] = 1,  
        ["-"] = 1,  
        ["*"] = 2,  
        ["/"] = 2,  
        ["%"] = 2,  
        };
    return priorities[op];
}
bool IsOperator(string token)
{
    string[] operators = { "+", "-", "*", "/", "%" };
    return operators.Contains(token);
}

string ReversePolishNotation(string exp)
{
    string[] tokens = exp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Stack<string> stack = new Stack<string>();
    List<string> output = new List<string>();
    foreach (string token in tokens)
    {
        if (token == "(")
        {
            stack.Push(token);
        }
        else if (token == ")")
        {
            while (stack.Peek() != "(")
                output.Add(stack.Pop());
            stack.Pop();
        }
        else if (IsOperator(token))
        {
            while (IsOperator(stack.Peek()))
            {
                if (Priority(stack.Peek()) >= Priority(token))
                    output.Add(stack.Pop());
                else
                    break;
            }
            stack.Push(token);
        }
        else
            output.Add(token);
    }
    return string.Join(' ', output);
}