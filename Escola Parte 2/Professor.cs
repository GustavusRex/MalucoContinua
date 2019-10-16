using System;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    class Professor:Pessoa
    {

        public int Registro;




        public void ColoqueAsInformacaosProfessor()
        {
            Random random = new Random();
            Registro = random.Next(10000000);

            Nome = Console.ReadLine();

            while (!SoLetras(Nome))
            {
                Console.WriteLine("\nPor favor digite o nome sem caracteres, numeros ou pontuções (Lembrando que não pode ser nulo) e maior que 3 caracteres\n");
                Nome = Console.ReadLine();

            }

            Console.WriteLine($"\nDigite o sexo do(a) Professor(a) {Nome}");
            Sexo = Console.ReadLine().ToUpper();

            while ((Sexo != "M" && Sexo != "F"))
            {
                Console.WriteLine("Sexo invalido, por favor digite novamente com: M ou F\n");
                Sexo = Console.ReadLine().ToUpper();
            }


            Console.WriteLine($"\nDigite a idade do(a) Professor(a) {Nome}");

            byte.TryParse(Console.ReadLine(), out Idade);
            while (Idade <= 21 || Idade >= 80)
            {

                Console.WriteLine("Um professor deve ter no mínimo 22 anos e no máximo 79");
                Console.WriteLine("Idade invalida por favor digitar novamente com um número inteiro\n");
                byte.TryParse(Console.ReadLine(), out Idade);

            }   

        }

    }
}