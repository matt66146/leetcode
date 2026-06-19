using System.Text;

Solution solution = new();


//Console.WriteLine(solution.ProcessStr("a#b%*", 1));
Console.WriteLine(solution.ProcessStr("%#bz%xum##i##vzo#pwc*#dkwbh####%uf%s*%cgppqhqa%h#l##o%ij%%cz%iga##e###u%#e####jfwx##%%*x%m*%#", 6523));







public class Solution
{

    public char ProcessStr(string s, long k)
    {
        StringBuilder result = new();

        bool reverse = false;

        foreach (var c in s)
        {
            switch (c)
            {
                case '*':
                    if (result.Length > 0)
                    {
                        if (reverse)
                        {
                            result.Remove(0, 1);
                        }
                        else
                        {
                            result.Remove(result.Length - 1, 1);
                        }

                    }
                    break;
                case '#':
                    var temp = result.ToString();
                    result.Append(temp);
                    break;
                case '%':
                    reverse = !reverse;
                    //result = new string(result.Reverse().ToArray());
                    break;
                default:
                    if (reverse)
                    {
                        result.Insert(0, c);
                    }
                    else
                    {
                        result.Append(c);
                    }

                    break;

            }
        }
        int index = -1;
        try
        {
            index = Convert.ToInt32(k);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        if (index > result.Length - 1 || index < 0 || result.Length < 1)
        {
            return '.';
        }

        if (reverse)
        {
            return result.ToString().Reverse().ToArray()[k];
        }
        return result[Convert.ToInt32(k)];
    }

    public string ProcessStrV2(string s)
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