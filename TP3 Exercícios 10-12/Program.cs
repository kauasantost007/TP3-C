using System;
using TP3_Exercícios_10a12.Models;

namespace TP3_Exercícios_10a12
{
    internal class TestaFiguras
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            circulo.Raio = 3.0;

            Esfera esfera = new Esfera();
            esfera.Raio = 5.0;

            double areaCirculo = circulo.CalcularArea();
            double volumeEsfera = esfera.CalcularVolume();

            Console.WriteLine("--- Círculo ---");
            Console.WriteLine("Raio: " + circulo.Raio);
            Console.WriteLine("Área: " + areaCirculo);

            Console.WriteLine("\n--- Esfera ---");
            Console.WriteLine("Raio: " + esfera.Raio);
            Console.WriteLine("Volume: " + volumeEsfera);
        }
    }
}