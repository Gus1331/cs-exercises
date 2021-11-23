using System;

namespace ex02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            int n1 = 13;//número base
            Console.WriteLine("Número: "+n1);
            Console.WriteLine((n1-1)+"<<"+n1+">>"+ (n1+1)); // <-sucessor e antecessor

            Console.WriteLine(" ");

            int res;// verificando se é par ou ímpar
            res = n1 % 2;
            if (res == 0){
            Console.WriteLine("Numero Par");
            }
            else {
                Console.WriteLine("Numero ìmpar");
            }

            Console.WriteLine("The End");

        }
    }
}
