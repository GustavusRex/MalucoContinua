using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    class Menu
    {
       Escola escola = new Escola();

        public void Menyu()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Para Cadastro Escolar\n");
                Console.WriteLine("Digite 1 para cadastrar as turmas");
                Console.WriteLine("Digite 2 para cadastrar os alunos");
                Console.WriteLine("Digite 3 para cadastrar os professores");
                Console.WriteLine("Digite 4 para mostrar as turmas");
                Console.WriteLine("Digite 5 para mostrar os alunos");
                Console.WriteLine("Digite 6 para mostrar os professores");
                Console.WriteLine("Digite 7 para inserir alunos a turma");
                Console.WriteLine("Digite 8 para inserir professor a turma");
                Console.WriteLine("Digite 0 para sair do cadastro\n");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Cadastrar turmas escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            escola.ListaDeTurmas();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\nCadastrar alunos escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            Console.WriteLine("Digite 0 para voltar ao menu");
                            escola.ListaDeAlunos();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\nCadastrar professor escolhido!\n");
                            escola.ListaDeProfessores();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar turma escolhido!\n");

                            foreach (Turma turma in escola.Listaturma)

                                Console.WriteLine($"O codigo da turma é {turma.Codigo}");
                            break;
                        }

                    case 5:

                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar alunos escolhido!...ESPERO QUE VC NÃO TENHA ERRADO A OPCAO KURWA\n");
                            foreach (Aluno aluno in escola.ListaAlunos)

                                Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                                                  $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Bolsista}");
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar professor escolhido!\n");
                            foreach (Professor prof in escola.ListaProfessor)

                                Console.WriteLine($"Professores {prof.Nome} do sexo {prof.Sexo} com a idade {prof.Idade}, " +
                                                  $" com o número de registro {prof.Registro}\n");
                            break;

                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Os alunos cadastrados são: ");
                            foreach (Aluno aluno in escola.ListaAlunos)

                                Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                                                  $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Bolsista}");

                            foreach (Turma turma in escola.Listaturma)

                                Console.WriteLine($"O codigo da turma é {turma.Codigo}");

                            Console.WriteLine("\nInserir Alunos dentro a uma turma!\n");
                            escola.AddAlunosTurma();
                            Console.WriteLine();

                            escola.MostrarFinalAluno();

                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("Os professores cadastrados são: ");
                            foreach (Professor prof in escola.ListaProfessor)

                                Console.WriteLine($"Professores {prof.Nome} do sexo {prof.Sexo} com a idade {prof.Idade}, " +
                                                  $" com o número de registro {prof.Registro}\n");

                            foreach (Turma turma in escola.Listaturma)

                                Console.WriteLine($"O codigo da turma é {turma.Codigo}");

                            Console.WriteLine("\nInserir Professor dentro a uma turma!\n");
                            escola.AddProfessorTurma();
                            Console.WriteLine();

                            escola.MostrarFinalProfessor();

                            break;
                        }



                }
                Console.WriteLine("Deseja volta ao menu? Digite 9 se sim");
                opcao = int.Parse(Console.ReadLine());

            } while (opcao == 9);
        }
    }
}



