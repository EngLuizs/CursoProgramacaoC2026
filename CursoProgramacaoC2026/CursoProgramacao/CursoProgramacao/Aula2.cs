using CursoProgramacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
    public class Aula2
    {
        public void ValorPar()
        {
            Console.WriteLine("Informe um valor");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
        public void MaiordeIdade()
        {
            Console.Write("Qual a Sua Idade? \nR:");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("\nMaior de Idade!");
            }

            else
            {
                Console.WriteLine("\nMenor de Idade");
            }
        }
        public void Nota()
        {
            Console.Write("Informe a nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());
            

            if (nota >= 7)
            {
                Console.WriteLine("\nAprovado!");
            }
             
            else if (nota >= 5)
            {
                Console.WriteLine("\nRecuperação!");
            }

            else
            {
                Console.WriteLine("\nReprovado!");
            }
        }
        public void Escolha()
        {
            Aula1 aula1 = new Aula1();
            Aula2 aula2 = new Aula2();
            int escolha;
            Console.WriteLine("Deseja fazer operação matemática? \n1 - Sim \n2 - Não");
            Console.Write("Opção: ");
            escolha = int.Parse(Console.ReadLine());
            Console.Clear();

            if (escolha == 1)
            {
                while (escolha != 9)
                {
                    Console.WriteLine("Deseja fazer qual operação matemática? \n1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão \n5 - Área do Circulo \n6 - Par ou Impar \n7 - Maior de Idade \n8 - Nota \n9 - Sair");
                    Console.Write("Opção: ");
                    escolha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (escolha == 1)
                    {
                        aula1.Soma();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (escolha == 2)
                    {
                        aula1.Subtração();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (escolha == 3)
                    {
                        aula1.Multiplicação();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (escolha == 4)
                    {
                        aula1.Divisão();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (escolha == 5)
                    {
                        aula1.AreadoCirculo();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if(escolha == 6)
                    {
                        aula2.ValorPar();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if(escolha == 7)
                    {
                        aula2.MaiordeIdade();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (escolha == 8)
                    {
                        aula2.Nota();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (escolha == 9)
                    {
                        Console.WriteLine("Saindo! Obrigado");
                    }

                    else if (escolha > 9)
                    {
                        Console.WriteLine("\nEscolha uma opção valida!");
                    }

                }
            }
            else
            {
                Console.WriteLine("Saindo! Obrigado");
            }
        }
    }
}
