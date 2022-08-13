using System;

namespace W2_L8_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //t1
            {
                int a = 0;
                bool dev;
                for (int i = 2; i <= 100; i++)
                {
                    dev = false;
                    for (int j = i / 2; j > 1; j--)
                    {
                        if (i % j == 0)
                        {
                            dev = true;
                            break;
                        }
                    }
                    if (!dev)
                    {
                        a++;
                    }
                }
                Console.WriteLine(a);
            }
            //t2
            {
                int a = 0, b = 0;

                do
                {

                    if (a % 2 == 0)
                    {
                        b++;
                    }
                    a++;
                } while (a <= 999);
                Console.WriteLine(b);
            }
            //t3
            {

                int a = 0, b = 0, c = 0, n;
                Console.WriteLine("podaj ilosc wyrazow");
                n = Int32.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    if (b == 0)
                    {
                        Console.WriteLine($" wyraz nr:{i}. Wartosc: {c}, gdyz  a=b {a}={b}, a c=b {c}={b}, wiec ({a}+{b} = {c})");
                        b++;
                    }
                    if (b == 1)
                    {
                        c = 1;
                    }

                    Console.WriteLine($" wyraz nr:{i+1}. Wartosc: {c},  gdyz a=b {a}={b}, a c=b {c}={b}, wiec ({a}+{b} = {c})");
                }
            }
            //t4
            {
                int a, b = 0;
                Console.WriteLine("podaj ilosc liczb");
                a = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= a + 1; i++)
                {
                    for (int j = 1; j <= a + 1; j++)
                        if (i > j)
                        {
                            b++;
                            Console.Write($"{b} ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    Console.Write("\n");
                }


            }
            //t5
            {
                double a = 0;
                for (int i = 0; i <= 20; i++)
                {
                    a = Math.Pow(i, 3);
                    Console.WriteLine($"{i} to power 3 is {a}");
                }
            }
            //t6
            {
                double a=0;
                for (double i = 1; i <= 20; i++)
                {
                    a = (1 / i) + a;
                    Console.WriteLine(a);
                }
            }
            //t7
            {
                int a = 0, b = 0, c = 0;
                Console.WriteLine("number of sides");
                int d = int.Parse(Console.ReadLine());

                while (a < d)
                {
                    for (b = 0; b < d - c; b++)
                    {
                        Console.Write(' ');
                    }
                    for (b = 0; b <= a + c; b++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                    a++;
                    c++;
                }
                a--;
                c--;
                while (a >= 0)
                {
                    for (b = 0; b <= d - c; b++)
                    {
                        Console.Write(' ');
                    }
                    for (b = 0; b < (a + c) - 1; b++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                    a--;
                    c--;
                }
            }
            //t8
            {
                Console.WriteLine("Podaj zdanie");
                string z, p = "";
                z = Console.ReadLine();
                int dl = z.Length - 1;// gdyż od 0
                while (dl>=0)
                {
                    p += z[dl];
                    dl--;
                }
                Console.WriteLine(p);
            }
            //t9
            {
                Console.WriteLine("task 9");
                int In, Div, DivR, BinLenght;
                string Bin = null, Bin2, Out = null;

                Console.WriteLine("enter a number");
                In = int.Parse(Console.ReadLine());
                Div = In;

                while (Div > 0)
                {
                    DivR = Div % 2;
                    Bin2 = Convert.ToString(DivR);
                    Bin += Bin2;
                    Div = Div / 2;
                }

                BinLenght = Bin.Length - 1;
                while (BinLenght >= 0)
                {
                    Out = Out + Bin[BinLenght];
                    BinLenght--;
                }
                Console.WriteLine($"{In} in binary is {Out}");
                
            }
            //t10
            {
                int a, b,w;
                Console.WriteLine("Podaj pierwsza ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("podaj druga");
                b = Int32.Parse(Console.ReadLine());
                bool tak = (a > b || b < a || a > 0 && b > 0);
                while (a!=b)
                {
                    if (a>b)
                    {
                        a -= b;
                    }
                    if(a<b)
                    {
                        b -= a;
                    }
                    if(a==0 || b==0)
                    {

                        Console.WriteLine("podana liczba musi byc dodatnia i większa od zera");
                        break;
                    }
                  
                }
                if (tak)
                {
                    w = a * b / a;
                    Console.WriteLine(w);
                }
            }
        }

    }

}

        

    



      
