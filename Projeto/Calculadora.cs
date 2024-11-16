using System;
using System.Collections.Generic;

namespace Projeto
{
    public class Calculadora
    {
        // Stores operation history
        private List<string> _historico = new List<string>();

        // Somar (Addition)
        public int somar(int val1, int val2) 
        {
            int res = val1 + val2;
            _historico.Add($"Soma: {val1} + {val2} = {res}");
            return res;
        }

        // Subtrair (Subtraction)
        public int subtrair(int val1, int val2) 
        {
            int res = val1 - val2;
            _historico.Add($"Subtração: {val1} - {val2} = {res}");
            return res;
        }

        // Multiplicar (Multiplication)
        public int multiplicar(int val1, int val2) 
        {
            int res = val1 * val2;
            _historico.Add($"Multiplicação: {val1} * {val2} = {res}");
            return res;
        }

        // Dividir (Division)
        public int dividir(int val1, int val2) 
        {
            if (val2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            
            int res = val1 / val2;
            _historico.Add($"Divisão: {val1} / {val2} = {res}");
            return res;
        }

        // Historico (History)
        public List<string> historico()
        {
            return new List<string>(_historico);
        }
    }
}
