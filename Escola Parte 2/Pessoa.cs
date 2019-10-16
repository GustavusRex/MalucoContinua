using System;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    abstract class Pessoa
    {
        public string Nome;
        public string Sexo;
        public byte Idade = 0;
        public bool SoLetras(string s) 
        {
            if ((string.IsNullOrEmpty(s)) || (s.StartsWith(" ") || (s.Length < 3))) 
                return false;

            foreach (char c in s) 
            {
                if (!char.IsLetter(c)) 
                    return false;
            }

            return true;
        }

    }
}