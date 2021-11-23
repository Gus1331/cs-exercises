using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;// criando variável
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();// recenbendo valor da variável (nome do usuário)
            Console.WriteLine(">----Bem-vindo "+ nome+"----<");

            Console.WriteLine(" ");
            Console.WriteLine("...");
            Console.WriteLine(" ");

            int mat = 7;//criando variáveis para nota
            int cie = 3;
            int ing = 5;
            int tec = 10;

            Console.WriteLine("Sua nota em Matemática foi: "+ mat);//informando a nota do usuário
            Console.WriteLine("Sua nota em Ciências foi: "+ cie);
            Console.WriteLine("Sua nota em Inglês foi: "+ ing);
            Console.WriteLine("Sua nota em Tecnologia foi: "+ tec);

            Console.WriteLine(" ");
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadLine();
            Console.WriteLine(" ");  

                //sistema para mensagens de aprovado;reprovado;nota máxima
                if (mat == 10){ //matemática
                    Console.WriteLine("Parabéns "+ nome +", Nota MÁXIMA em Matemática :D");
                }
                else if (mat >= 5){
                    Console.WriteLine("Aluno aprovado em Matemática :)");
                }
                else if (mat <= 5){
                    Console.WriteLine("Aluno reprovado em Matemática :(");
                }
                if (cie == 10){//ciências
                    Console.WriteLine("Parabéns "+ nome +", Nota MÁXIMA em Ciências :D");
                }
                else if (cie >= 5){
                    Console.WriteLine("Aluno aprovado em Ciências :)");
                }
                else if (cie < 5){
                    Console.WriteLine("Aluno reprovado em Ciências :(");
                }
                if (ing == 10){//inglês
                    Console.WriteLine("Parabéns "+ nome +", Nota MÁXIMA em Inglês :D");
                }
                else if (ing <= 5){
                    Console.WriteLine("Aluno reprovado em Inglês :(");
                }
                else if (ing >= 5){
                    Console.WriteLine("Aluno aprovado em Inglês :)");
                }
                if (tec == 10){//tecnologia
                    Console.WriteLine("Parabéns "+ nome +", Nota MÁXIMA em Tecnologia :D");
                }
                else if (tec <= 5){
                    Console.WriteLine("Aluno reprovado em Tecnologia :(");
                }
                else if (tec >= 5){
                    Console.WriteLine("Aluno aprovado em Tecnologia :)");
                }


            Console.WriteLine(" ");
            Console.WriteLine(" ");            
            Console.WriteLine("Fim!"); //fim do exercicio
            Console.WriteLine(" ");
        }
    }
}
