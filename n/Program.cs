using System;

namespace GuiseTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] x = new char[4];
            char[] y = new char[4];
            int e = 0;
            Random w = new Random() ;
            for (e = 0; e < 4; ++e)
            {
                int g = w.Next(10);
                char l = char.Parse(g.ToString());
                bool same = false;
                foreach (char n in x)
                {
                    if (n == 0)
                    {
                        same = false;
                        break;
                    }
                    if (l == n)
                    {
                        same = true;
                        break;
                    }
                }

                if (same == false)
                {
                    x[e] = l;
                }
                else
                    --e;

            }
            int c = 0;
            int d = 0;
            int i = 0;
            int k = 0;
            Console.WriteLine("猜一個四位的數\n提示：必須為四個不同數值所組成");
            do
            {
                y = Console.ReadLine().ToCharArray();
                ++i;
                int a = 0;
                int b = 0;
                for (c = 0; c < 4; ++c)
                {
                    for (d = 0; d < 4; ++d)
                    {
                        if (y[c] != x[d]) continue;
                        ++b;
                        if (c == d)
                        {
                            ++a;
                            --b;
                        }

                    }

                }

                k = 10 - i;
                if (a == 4 & b == 0)
                {
                    Console.WriteLine("    Congratulations,you are right.");
                    break;
                }
                else if (k == 0)
                {
                    Console.WriteLine("    答案是{0}{1}{2}{3}\n    別灰心下次要一樣努力喔！", x[0], x[1], x[2], x[3]);

                }
                else
                {
                    Console.Write("    {0}A{1}B", a, b);
                    Console.WriteLine("   加油，還有{0}次機會", k);
                }



            } while (i < 10);


        }
    }
}
