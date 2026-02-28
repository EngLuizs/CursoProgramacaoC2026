using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
    public class Aula3
    {
        //Switch
        public void AvaliacaoSwitch()
        {
            Console.Write("Informe a nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case >= 7:
                    Console.WriteLine("Aluno Aprovado");
                    break;

                case >= 5:
                    Console.WriteLine("Recuperação");
                    break;

                default:
                    Console.WriteLine("Reprovado");
                    break;

            }
        }
        public void CategoriaIdade()
        {
            Console.Write("Informe a sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case >= 60:
                    Console.WriteLine("Você é um Idoso!");
                    break;

                case >= 30:
                    Console.WriteLine("Você é um Adulto!");
                    break;

                case >= 20:
                    Console.WriteLine("Você é um Jovem!");
                    break;

                case >= 10:
                    Console.WriteLine("Você é uma adolescente!");
                    break;

                default:
                    Console.WriteLine("Criança");
                    break;
            }
        }
    }
}
