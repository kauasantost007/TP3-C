using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Exercícios_10a12.Models
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
