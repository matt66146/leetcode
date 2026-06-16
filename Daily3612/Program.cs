Solution solution = new();


String result = solution.ProcessStr("a#b%*");

Console.WriteLine(result);





public class Solution
{


    public string ProcessStr(string s)
    {
        string result = "";
        bool reverse = false;
        Console.WriteLine(result.Length);
        foreach (var c in s)
        {
            switch (c)
            {
                case '*':
                    if (result.Length > 0)
                    {
                        if (reverse)
                        {
                            result = result[1..];
                        }
                        else
                        {
                            result = result.Remove(result.Length - 1);
                        }

                    }
                    break;
                case '#':
                    result += result;
                    break;
                case '%':
                    reverse = !reverse;
                    //result = new string(result.Reverse().ToArray());
                    break;
                default:
                    if (reverse)
                    {
                        result = c + result;
                    }
                    else
                    {
                        result += c;
                    }

                    break;

            }
        }

        if (reverse) result = new string(result.Reverse().ToArray());
        return result;
    }

    public string ProcessStrV1(string s)
    {
        string result = "";
        Console.WriteLine(result.Length);
        foreach (var c in s)
        {
            switch (c)
            {
                case '*':
                    if (result.Length > 0)
                    {
                        result = result.Remove(result.Length - 1);
                    }
                    break;
                case '#':
                    result += result;
                    break;
                case '%':
                    result = new string(result.Reverse().ToArray());
                    break;
                default:
                    result += c;
                    break;

            }
        }


        return result;
    }
}