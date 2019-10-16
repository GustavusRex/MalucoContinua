using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola_Parte_2._1
{
    class Turma
    {
       
        public Professor professor = new Professor();
        public List<Aluno> ListaAlunosAtribuidos = new List<Aluno>();

        public int Codigo;

        public void CodigoTurma()
        {
            Random random = new Random();
            Codigo = random.Next(1000);
        }

        public void ExibirProfessor()
        {
            Console.WriteLine($"A Turma {Codigo} tem o professor:");

            if (professor.Idade == 0)
            {
                Console.WriteLine("Não há professor nessa turma");
            }
            else
            {
                Console.WriteLine($"O professor {professor.Nome}, com o sexo {professor.Sexo}, de idade {professor.Idade}, com o registro {professor.Registro}");
            }
        }

        public void ExibirAluno()
        {
            foreach(Aluno aluno in ListaAlunosAtribuidos)
            {
                Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Bolsista}");
            }
        }

    }

}