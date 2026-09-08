using System;
using System.Collections.Generic;
using System.Text;

namespace TP3Exercicio1.models
{
    public class Pessoa /// Classe criada para representar a entidade "Pessoa".
    {
        public String nome; /// Ambos são atributos (campos) relacionados à classe Pessoa.
        public int idade;

        public void apresentar() /// Método que foi criado para exibir as informações da pessoa.
        {
            System.Console.WriteLine("Nome: " + nome);
            System.Console.WriteLine("Idade: " + idade);
        }

        public void fazerAniversario() /// Método que manipula o atributo idade, incrementando seu valor.
        {
            idade++;
            System.Console.WriteLine(nome + " completou " + idade + " anos!");
        }
    }
}