using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola_Parte_2._1
{
    class Escola
    {
        public List<Aluno> ListaAlunos = new List<Aluno>();
        public List<Turma> Listaturma = new List<Turma>();
        public List<Professor> ListaProfessor = new List<Professor>();
        uint NumeroProfessores;
        ushort NumeroTurma;
        uint NumeroAlunos;


        public void ListaDeTurmas()
        {
            Console.WriteLine("Digite a quantidade de turmas");
            ushort.TryParse(Console.ReadLine(), out NumeroTurma);
            while ( NumeroTurma == 0)
            {
                Console.WriteLine("\nNúmero digitado invalido, porfavor digite um número inteiro\n");
                ushort.TryParse(Console.ReadLine(), out NumeroTurma);

            }

            for (int i = 0; i < NumeroTurma; i++)
            {
                Turma turma = new Turma();
                turma.CodigoTurma();

                Listaturma.Add(turma);
            }

        }

        public void ListaDeProfessores()
        {
            Console.WriteLine("Digite o número de professores que serão cadastrados na lista");
            uint.TryParse(Console.ReadLine(), out NumeroProfessores);
            while (NumeroProfessores == 0)
            {
                Console.WriteLine("Número de professor incorreto, por favor digitar novamente");
                Console.WriteLine();
                uint.TryParse(Console.ReadLine(), out NumeroProfessores);
            }

            for (int i = 0; i < NumeroProfessores; i++)
            {
                Professor professor = new Professor();
                Console.WriteLine($"Digite o nome do(a) {i + 1}° Professor(a)");
                professor.ColoqueAsInformacaosProfessor();
                ListaProfessor.Add(professor);
            }

        }

        public void ListaDeAlunos()
        {
            Console.WriteLine("\nDigite a quantidade de alunos para o cadastro");

            uint.TryParse(Console.ReadLine(), out NumeroAlunos);
            while (NumeroAlunos == 0)
            {
                Console.WriteLine("Número de alunos incorreto, por favor digitar novamente");
                Console.WriteLine();
                uint.TryParse(Console.ReadLine(), out NumeroAlunos);
            }

            for (int i = 0; i < NumeroAlunos; i++)
            {
                Aluno aluno = new Aluno();

                aluno.ColoqueAsInformacaosAlunos();
                ListaAlunos.Add(aluno);
            }

        }

        public void AddProfessorTurma()
        {

            //if (Listaturma.count == 0)
            Console.Write("Digite o número de registro: ");
            int n = int.Parse(Console.ReadLine());
            Professor professor = ListaProfessor.Where(a => a.Registro == n).FirstOrDefault();
            Console.Write("Digite o número do código da turma: ");
            n = int.Parse(Console.ReadLine());
            Listaturma.Where(a => a.Codigo == n).FirstOrDefault().professor = professor;

            
        }

        public void AddAlunosTurma()
        {
            Console.Write("Digite o número de matricula: ");
            int n = int.Parse(Console.ReadLine());
            Aluno aluno = ListaAlunos.Where(a => a.Matricula == n).FirstOrDefault();
            Console.Write("Digite o número do código da turma: ");
            n = int.Parse(Console.ReadLine());
            Listaturma.Where(a => a.Codigo == n).FirstOrDefault().ListaAlunosAtribuidos.Add(aluno);                     
        }

        public void MostrarFinalAluno()
        {
            foreach (Turma turm in Listaturma)
            {
                turm.ExibirAluno();
            }
        }
        public void MostrarFinalProfessor()
        {
            foreach (Turma turm in Listaturma)
            {
                turm.ExibirProfessor();


            }
        }


    }
}
