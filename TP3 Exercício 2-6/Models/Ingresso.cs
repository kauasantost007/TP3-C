using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Exercícios_2a6.Models
{
    public class Ingresso
    {
        public string nomeDoShow;           /// Identifica a qual evento o ingresso pertence.
        public double preco;                /// Define o valor cobrado por ingresso.
        public int quantidadeDisponivel;    /// Controla quantos ingressos ainda podem ser vendidos.

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Show: " + nomeDoShow);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Quantidade disponível: " + quantidadeDisponivel);
        }
        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQtd)
        {
            quantidadeDisponivel = novaQtd;
        }
    }
}