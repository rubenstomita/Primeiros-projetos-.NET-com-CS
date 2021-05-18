using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Consele.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //ToDo: adicionar aluno
                        break;
                    case "2":
                        //ToDo: listar alunos
                        break;
                    case "3":
                        //ToDo: calcular média geral
                        break;                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Informe a opção desejada:");
                Consele.WriteLine("1- Inserir novo aluno");
                Console.WriteLine("2- Listar alunos");
                Console.WriteLine("3- Calcular média geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();  
            }
        }
    }
}
