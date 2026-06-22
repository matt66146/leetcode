Solution solution = new();

Console.WriteLine(solution.MaxNumberOfBalloons("ballon"));

public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        int num = Int32.MaxValue;
        var letters = new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (letters.ContainsKey(c))
            {
                letters[c]++;
            }
            else
            {
                letters.Add(c, 1);
            }

        }
        string search = "balon";
        if (letters.ContainsKey('l'))
        {
            letters['l'] /= 2;
        }
        if (letters.ContainsKey('o'))
        {
            letters['o'] /= 2;

        }


        foreach (char c in search)
        {
            if (!letters.ContainsKey(c))
            {
                num = 0;
                continue;
            }
            num = Math.Min(num, letters[c]);
        }

        if (num == Int32.MaxValue) return 0;
        return num;
    }
    public int MaxNumberOfBalloonsV1(string text)
    {
        int num = 0;
        int b = 0;
        int a = 0;
        int l = 0;
        int o = 0;
        int n = 0;


        foreach (char c in text)
        {
            switch (c)
            {
                case 'b':
                    b++;
                    break;
                case 'a':
                    a++;
                    break;
                case 'l':
                    l++;
                    break;
                case 'o':
                    o++;
                    break;
                case 'n':
                    n++;
                    break;
            }
        }
        while (true)
        {
            if (b >= 1)
            {
                if (a >= 1)
                {
                    if (l >= 2)
                    {
                        if (o >= 2)
                        {
                            if (n >= 1)
                            {
                                num++;
                                b--;
                                a--;
                                l -= 2;
                                o -= 2;
                                n--;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }


        return num;
    }
}