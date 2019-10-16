using System;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    class Aluno : Pessoa // Classe onde guarda as caracteriscas de Aluno e herdado de pessoa
    {
        public int Matricula;
        public string Bolsista;

        public void ColoqueAsInformacaosAlunos()
        {
            Random random = new Random();
            Matricula = random.Next(10000000);

            Console.WriteLine("\nDigite o nome do(a) Aluno(a)");
            Nome = Console.ReadLine();

            while (!SoLetras(Nome))
            {
                Console.WriteLine("\nPor favor digite o nome sem caracteres, numeros ou pontuções (Lembrando que não pode ser nulo) e maior que 3 caracteres\n");
                Nome = Console.ReadLine();

            }

            Console.WriteLine($"\nDigite o sexo do(a) Aluno(a) {Nome}");
            Sexo = Console.ReadLine().ToUpper();

            while (Sexo != "M" && Sexo != "F")
            {
                Console.WriteLine("Sexo invalido, por favor digite novamente com: M ou F\n");
                Sexo = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($"\nDigite a idade do(a) Aluno(a) {Nome} ");

            byte.TryParse(Console.ReadLine(), out Idade);
            while (Idade <= 2)
            {
                Console.WriteLine("Um aluno deve ter no mínimo 3 anos");
                Console.WriteLine("\nIdade invalida por favor digitar novamente com um número inteiro\n");
                byte.TryParse(Console.ReadLine(), out Idade);

            }
            Console.WriteLine("\nO Aluno é bolsista? <S> para Sim e <N> para Não");
            Bolsista = Console.ReadLine().ToUpper();

            while (Bolsista != "S" && Bolsista != "N")
            {

                Console.WriteLine("Opção invalida porfavor digitar (S) para sim e (N) para não");
                Bolsista = Console.ReadLine().ToUpper();
            }

        }


    }
}