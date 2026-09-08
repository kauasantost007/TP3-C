using System;
using TP3_Exercícios_7a9.Models;

namespace TP3_Exercícios_7a9
{
    internal class TestaMatricula
    {
        static void Main(string[] args)
        {
            Matricula matriculaJoao = new Matricula();
            matriculaJoao.NomeDoAluno = "João Pedro";
            matriculaJoao.Curso = "Engenharia de Software";
            matriculaJoao.NumeroMatricula = 20;
            matriculaJoao.Situacao = "Ativa";
            matriculaJoao.DataInicial = "10/03/2024";

            Console.WriteLine("--- Informações iniciais ---");
            matriculaJoao.ExibirInformacoes();

            matriculaJoao.Trancar();
            Console.WriteLine("\n--- Após trancar a matrícula ---");
            matriculaJoao.ExibirInformacoes();

            matriculaJoao.Reativar();
            Console.WriteLine("\n--- Após reativar a matrícula ---");
            matriculaJoao.ExibirInformacoes();
        }
    }
}
