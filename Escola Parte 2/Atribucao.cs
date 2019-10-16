using System;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    class Atribucao
    {
        public List<Turma> Listaturma = new List<Turma>();
        public void AddAlunosTurma()
        {

            Console.WriteLine("Digite o Codigo da turma para inserir o aluno");
            int ProcurarCodigo = int.Parse(Console.ReadLine());

            Turma turma = Listaturma.Find(x => x.Codigo == ProcurarCodigo);
            if (turma != null)
            {
                Console.WriteLine("Digite o aluno que irá para essa turma");


            }
        }
    }
}
