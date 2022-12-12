using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Verilmiş ədədin rəqəmləri cəmini tapan proqram***
            // Console.WriteLine("ededi daxil edin");
            // string number = Console.ReadLine();
            // int num = Convert.ToInt32(number);
            // var sum = 0;
            // while (num != 0)
            // {
            //     sum += num % 10;
            //     num = num - (num % 10);
            //     num = num / 10;
            // }
            // Console.WriteLine(sum);
            // Console.ReadLine();
            //Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram
            //Console.WriteLine("ededi daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());
            //while (num != 0)
            //{
            //    if (num == 1 || num == 2 || num == 12)
            //    {
            //        Console.WriteLine("qis");
            //        break;
            //    }
            //    else if (num == 3 || num == 4 || num == 5)
            //    {
            //        Console.WriteLine("yaz");
            //        break;
            //    }
            //    else if (num == 6 || num == 7 || num == 8)
            //    {
            //        Console.WriteLine("yay");
            //        break;
            //    }
            //    else if (num == 9 || num == 10 || num == 11)

            //    {
            //        Console.WriteLine("payiz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("eded duzgun deyil");
            //        Console.ReadLine();

            //Verilmiş yazıda rəqəm olmamasını yoxlayan proqram,
            //əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.
            Console.WriteLine("reqemi daxil edin");
            string word = Console.ReadLine();
            Double reqem = Convert.ToDouble(word);
         
            if (reqem/1==reqem) // reqem hissesi alinir herf  ise yox
            {
                Console.WriteLine("davam ede bilersiz");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("yeniden eded daxil edin");
                Console.ReadLine();
            }
            
            
            Console.WriteLine("ededleri daxil edin");
            int numm =Convert.ToInt32(Console.ReadLine());
            int numn=Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            var count = 0;
            for (int i = 0; numm < numn; i++)
            {
                if (numm % 3 == 0 && numn%7==0)
                {
                    count++;
                    sum += numm;


                }
                else
                {
                    i++;    
                }

                if (count == 0)
                {
                    Console.WriteLine("0 bolmek olmur");
                    Console.ReadLine();

                }

                else
                {
                    Console.WriteLine(sum / count);
                    Console.ReadLine();
                }
            }






























        }










    }
    }
}
