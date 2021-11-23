using System;

namespace ex02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(" ");
            int alu1 = 13;
            int alu2 = 16;
            int alu3 = 22;
            int alu4 = 18;
            int alu5 = 21;

            Console.WriteLine(" Aluno 1: "+alu1+" anos");
            Console.WriteLine(" Aluno 2: "+alu2+" anos");
            Console.WriteLine(" Aluno 3: "+alu3+" anos");
            Console.WriteLine(" Aluno 4: "+alu4+" anos");
            Console.WriteLine(" Aluno 5: "+alu5+" anos");
            Console.WriteLine(" ");
            int med = (alu1+alu2+alu3+alu4+alu5);
            Console.WriteLine("A média de idade dos alunos é: "+med/5);


        }
    }
}
