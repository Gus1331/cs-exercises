using System;

namespace ex02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int psoa1 = 13;//pessoas, idade
            int psoa2 = 19;
            int psoa3 = 23;
            int psoa4 = 20;
            int psoa5 = 31;

            int cont = 0;//variável de contagem
            
            if (psoa1>19){//cálculo idade
               cont = (cont+1); 
            }
            if (psoa2>19){
               cont = (cont+1); 
            }
            if (psoa3>19){
               cont = (cont+1); 
            }
            if (psoa4>19){
               cont = (cont+1); 
            }
            if (psoa5>19){
               cont = (cont+1); 
            }
            
            Console.WriteLine( cont +" Pessoas tem mais de 20 anos");//mostrando contagem
          
        }
    }
}
