using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
    public class Aula1
    {
        int valor1, valor2;
        int resultado1, resultado2, resultado3, resultado4;

        public void Soma()
        {
            Console.WriteLine("________SOMA________");
            Console.Write("Informe o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            resultado1 = valor1+valor2;
            
            Console.WriteLine($"O resultado da soma é: {resultado1}");
        }
        public void Subtração()
        {
            Console.WriteLine("________SUBTRAÇÃO________");
            Console.Write("\nInforme o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            resultado2 = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é: {resultado2}");
        }
        public void Multiplicação()
        {
            Console.WriteLine("________MULTIPLICAÇÃO________");
            Console.Write("\nInforme o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            resultado3 = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado3}");
        }
        public void Divisão()
        {
            Console.WriteLine("________DIVISÃO________");
            Console.Write("\nInforme o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            resultado4 = valor1 / valor2;

            Console.WriteLine($"O resultado da Divisão é: {resultado4}");
        }
        public void AreadoCirculo()
        {
            const double pi = 3.14;

            Console.WriteLine("_________Calculo da Area do Circulo_________)");
            Console.Write("\nInforme o Valor do raio em metros: ");
            double raio = double.Parse(Console.ReadLine());

            double elevado = raio * raio;
            double resultado = pi * elevado;

            Console.WriteLine($"O resultado da area do circulo é: {resultado} m²");
        }
    }
}
