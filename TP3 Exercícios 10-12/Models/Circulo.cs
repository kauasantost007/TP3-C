using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Exercícios_10a12.Models
/// Exercício 11
{
    public class Circulo
    {
        public double Raio;    /// Define o tamanho do círculo, base para calcular sua área.

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
