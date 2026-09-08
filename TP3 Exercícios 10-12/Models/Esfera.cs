using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Exercícios_10a12.Models
/// Exercício 11
{
    public class Esfera
    {
        public double Raio;    /// Define o tamanho da esfera, base para calcular seu volume.

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }
}
