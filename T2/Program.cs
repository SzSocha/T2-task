using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            //t1
            {
                int a, b;
                Console.WriteLine("give me two numbers");
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("this numbers are the same");
                }
                else
                {
                    Console.WriteLine("this numbers are not the same");
                }
            }
            //t2
            {
                Console.WriteLine("number");
                int a = Int32.Parse(Console.ReadLine());
                if ((a > 0 || a < 0) && (a % 2 == 0))
                {
                    Console.WriteLine("even number");
                }
                else
                {
                    Console.WriteLine("odd number");
                }
            }
            //t3
            {
                Console.WriteLine("Number");
                double a = Double.Parse(Console.ReadLine());
                bool score = a > 0;
                if (score)
                {
                    Console.WriteLine("dodatnia");
                }
                else if (a == 0)
                {
                    Console.WriteLine("zero");
                }
                else
                {
                    Console.WriteLine("ujenmna");
                }
            }
            //t4
            {
                Console.WriteLine("enter the year");
                short year = short.Parse(Console.ReadLine());

                bool check = year % 4 == 0 && year % 100 != 0 || year % 400 == 0 && year > 0;
                if (check)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else if (year <= 0)
                {
                    Console.WriteLine("please enter the correct year");
                }
                else if (!check)
                {
                    Console.WriteLine($"{year} is NOT a leap year");
                }
            }
            //t5[
            {
                Console.WriteLine("enter your age");
                int age = Int32.Parse(Console.ReadLine());
                if (age < 21)
                {
                    Console.WriteLine("you cannot run for government");
                }
                if (age >= 21)
                {
                    Console.WriteLine("You can become a deputy");
                }
                if (age >= 30)
                {
                    Console.WriteLine("You can become a senator or prime minister");
                }
                if (age >= 35)
                {
                    Console.WriteLine("You can become a president");
                }
            }
            //t6
            {
                Console.WriteLine("enter your height in cm");
                byte height = byte.Parse(Console.ReadLine());
                if (height <= 140 && height > 0)
                {
                    Console.WriteLine("You are a dwarf");
                }
                else if (height > 140 && height < 160)
                {
                    Console.WriteLine("you are taller than the dwarf");
                }
                else if (height >= 160 && height < 180)
                {
                    Console.WriteLine("you are of average height");
                }
                else if (height >= 180)
                {
                    Console.WriteLine("You are tall");
                }
                else
                {
                    Console.WriteLine("please enter a correct height");
                }
            }
            //t7
            {
                Console.WriteLine("please enter three numbers");
                double a = Double.Parse(Console.ReadLine());
                double b = Double.Parse(Console.ReadLine());
                double c = Double.Parse(Console.ReadLine());
                bool check = (a == b && a == c);
                if (a > b && a > c)
                {
                    Console.WriteLine(a);
                }
                if (b > a && b > c)
                {
                    Console.WriteLine(b);
                }
                if (c > a && c > b)
                {
                    Console.WriteLine(c);
                }
                if (a == b && a < c)
                {
                    Console.WriteLine($"a and b are the same, c is bigger");
                }
                if (a == b & a > c)
                {
                    Console.WriteLine($"a and b are the same, c is smaller");
                }
                if ((a == c) && (a > b))
                {
                    Console.WriteLine("a and c are the same but b is smaller");
                }
                if (a == c & a < b)
                {
                    Console.WriteLine($"a and c are the same, b is bigger");
                }
                if (check)
                {
                    Console.WriteLine("all numbers are the same");
                }
            }
            //t8
            {

                Console.WriteLine("enter your score form math exam");
                ushort math = ushort.Parse(Console.ReadLine());
                Console.WriteLine("enter your score from physics exam");
                ushort physics = ushort.Parse(Console.ReadLine());
                Console.WriteLine("enter your score from chemistry exam ");
                ushort chemistry = ushort.Parse(Console.ReadLine());
                bool check = ((math >= 70 && physics >= 55 && chemistry >= 45) || (math + physics + chemistry >= 180) || (math + physics >= 150 || math + chemistry > 150));
                if (check)
                {
                    Console.WriteLine("Candidate admitted to recruitment");
                }
                else
                {
                    Console.WriteLine("Candidate not admitted to recruitment");
                }

            }
            //t9
            {
                Console.WriteLine("Jaka temperatura wariacie? Pamiętaj, ze na słońcu panuje 5 505 °C, więc nie przesadzaj");
                short temp = short.Parse(Console.ReadLine());
                if (temp < 0)
                {
                    Console.WriteLine($"cholernie pizdzi wkoncu to{temp}");
                }
                else if (temp >= 0 && temp < 10)
                {
                    Console.WriteLine($"jest zimno mamy {temp} stopni");
                }
                else if (temp >= 10 && temp < 20)
                {
                    Console.WriteLine($"jest w sam raz, temperatura wynosi: {temp}");
                }
                else if (temp >= 20 && temp < 30)
                {
                    Console.WriteLine($"zaczyna byc goraco, jest {temp} stopni");
                }
                else
                {
                    Console.WriteLine($"mamy {temp} stopni\r\n - a wez, wyprowadzam sie na Alaske");
                }
            }
            //t10
            {
                Console.WriteLine("enter length a ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter length b ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter length c ");
                double c = Double.Parse(Console.ReadLine());

                bool check = ((c > a && c > b && a + b > c) || (a > b && a > c && b + c > a) || (b > a && b > c && a + c > b));
                if (check)
                {
                    Console.WriteLine("you can construct a triangle");
                }
                else
                {
                    Console.WriteLine("you can NOT construct a triangle");
                }
            }
            //t11
            {
                Console.WriteLine("enter your mark");
                short mark = short.Parse(Console.ReadLine());


                switch (mark)
                {
                    case 6:
                Console.WriteLine("celujacy");
                        break;
                    case 5:
                Console.WriteLine("bardzo dobry");
                        break;
                    case 4:
                Console.WriteLine("dobry");
                        break;
                    case 3:
                Console.WriteLine("dostateczny");
                        break;
                    case 2:
                Console.WriteLine("dopuszczajacy");
                        break;
                    case 1:
                Console.WriteLine("niedostateczny");
                        break;
                    default:
                Console.WriteLine("podaj prawidlowa ocene");
                        break;
            }
            }
            //t12
            {
                Console.WriteLine("podaj numer dnia tygodnia od 1 do 7 ");
                byte day = byte.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("poniedzialek");
                        break;
                    case 2:
                        Console.WriteLine("wtorek");
                        break;
                    case 3:
                        Console.WriteLine("sroda");
                        break;
                    case 4:
                        Console.WriteLine("czwartek");
                        break;
                    case 5:
                        Console.WriteLine("Piatek");
                        break;
                    case 6:
                        Console.WriteLine("sobota");
                        break;
                    case 7:
                        Console.WriteLine("niedziela");
                        break;
                    default:
                        Console.WriteLine("podaj prawidlowy dzien tygodnia");
                        break;
                }
               
            }
            //t13
            {
                start:
                Console.WriteLine("Enter first number");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("what do you want to do? enter the menu number");
                double c;
                Console.WriteLine("1.addition\r\n2.substraction\r\n3.multiplication\r\n4.division");
                byte option = byte.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(a+b);
                        break;
                    case 2:
                        Console.WriteLine(a-b);
                        break;
                    case 3:
                        Console.WriteLine(a*b);
                        break;
                    case 4:
                        Console.WriteLine(a/b);
                        break;
                    default:
                        Console.WriteLine("enter the correct number in menu from 1 to 4");
                        goto start;
                        
                }
            }

        }
    }
}
