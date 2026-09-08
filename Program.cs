using TP3Exercicio1.models;

namespace TP3Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa maria = new Pessoa(); /// Criação de um objeto a partir da classe Pessoa.
            maria.nome = "Maria";
            maria.idade = 28;
            maria.apresentar();
            maria.fazerAniversario();

            Pessoa joao = new Pessoa(); /// Criação de um segundo objeto, independente do primeiro.
            joao.nome = "João";
            joao.idade = 35;
            joao.apresentar();
        }
    }
}
