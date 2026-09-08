using System;
using TP3_Exercícios_2a6.Models;

namespace TP3_Exercícios_2a6
/*
    /// Exercício 4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingresso showTravis = new Ingresso();
            showTravis.nomeDoShow = "Travis Scott - Circus Maximus Tour";
            showTravis.preco = 320.00;
            showTravis.quantidadeDisponivel = 600;

            Console.WriteLine("--- Informações iniciais ---");
            showTravis.ExibirInformacoes();

            showTravis.AlterarPreco(360.00);
            showTravis.AlterarQuantidade(500);

            Console.WriteLine("\n--- Informações após alterações ---");
            showTravis.ExibirInformacoes();
        }
    }
}

*/


/// Exercício 6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingresso showTravis = new Ingresso("Travis Scott - Circus Maximus Tour", 320.00, 600);

            showTravis.ExibirInformacoes();
        }
    }
}

/// O construtor facilita porque cria o objeto já completo, em uma única linha, obrigando que todos os dados essenciais
/// sejam informados no momento da criação. Com vários Set... separados, seriam necessárias várias linhas,existe o risco
/// de esquecer de preencher algum atributo, e o objeto fica temporariamente incompleto entre uma chamada e outra, problemas que o construtor elimina.