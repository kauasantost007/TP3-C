using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Exercícios_7a9.Models
{
    public class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;        /// Indica o status atual da matrícula (Ativa, Trancada e Concluída)
        public string DataInicial;     /// Registra a data em que a matrícula foi iniciada. (DD/MM/YYYY)

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Aluno: " + NomeDoAluno);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("Situação: " + Situacao);
            Console.WriteLine("Data inicial: " + DataInicial);
        }
    }
}