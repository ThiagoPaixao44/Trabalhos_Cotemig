using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int questao; // a variavel questao foi declarada
            bool executa = true; // a variavel executa foi declarada como true
            string valor = ""; // a variavel valor foi declarada como string para decidir se o programa continua ou para

            while (executa) // estrutura de repetição para decidir se mantem o programa rodando ou para
            {
                Console.WriteLine("Olá, por favor informe o numero da questao: "); // output

                questao = Convert.ToInt32(Console.ReadLine()); // input

                switch (questao) // switch para escolher qual a questao irá aparecer dependendo do numero inserido
                {
                    case 1: // caso se o numero informado for 1
                        questao1(); // referencia a questao 1
                        break;
                    case 2: // caso se o numero informado for 2
                        questao2(); // referencia a questao 2
                        break;
                    case 3: // caso se o numero informado for 3
                        questao3();
                        break;
                    case 4: // caso se o numero informado for 4
                        questao4();
                        break;
                }

                Console.WriteLine("\nQuestão finalizada. \nDeseja sair? S/N"); // output
                valor = Console.ReadLine(); // input

                if (valor == "S" || valor == "s") // condição se o valor for Sim
                {
                    executa = false; // transforma o executa em false, parando o while
                }
                Console.Clear(); // limpa o console
            }
        }

        static void questao1()
        {
            Console.WriteLine("Questão 1: Crie um programa que contenha um array de 10 posições. O usuário deverá preencher todas as posições do array com valores numéricos inteiros. Além disso, seu programa deverá conter um novo array que irá receber os valores preenchidos multiplicado pelo próximo número. No entanto, o último número sempre deverá ser multiplicado por 1."); // output 

            int[] array = new int[15];

            for (int i = 0; i <= (array.Length - 6); i++)
            {
                Console.WriteLine("Por favor insira um numero inteiro: "); // output
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("array1 = ");

            for (int j = 0; j <= (array.Length -6); j++)
            {
                Console.Write(array[j]);
            }
            
            for (int k = 0; k <= (array.Length -6); k++)
            {
                if (array[k] <= (array.Length - 7))
                {
                    array[k] = (array[k] * array[k + 1]);
                }
                
                if (array[k] == (array.Length - 6))
                {
                    array[k] = array[k] * 1;
                }

            }

            Console.WriteLine();
            Console.Write("array2 = ");

            for (int l = 0; l <= (array.Length - 6); l++)
            {
                Console.Write(array[l]);
            }


        }

        static void questao2()
        {
            Console.WriteLine("Questão 2: Crie um programa que contenha um array de 5 posições. O usuário deverá preencher todas as posições do array com valores numéricos inteiros. Ao final o programa deverá preencher um outro array com os valores inversos.");

            int[] array = new int[5];

            for (int i = 0; i <= (array.Length - 1); i++)
            {
                Console.WriteLine("Por favor insira um numero inteiro: "); // output
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("array1 = ");

            for (int j = 0; j <= (array.Length - 1); j++)
            {
                Console.Write(array[j]);
            }

            Console.WriteLine();
            Console.Write("array2 = ");

            for (int k = (array.Length -1); k >= 0; k--)
            {
                
                Console.Write(array[k]);

            }


           
        }

        static void questao3()
        {
            Console.WriteLine("Questão 3: Crie um programa que permita entrar com valores inteiros para um matriz A(4x4) e para uma matriz B(4x4). Gerar e imprimir uma outra matriz com a SOMA(A + B).");
            
            int[,] matrizA = new int [4 ,4];
            int[,] matrizB = new int[4, 4];
            int[,] matrizC = new int[4, 4];
            int valorA, valorB = 0;


            for (int i = 0; i < matrizA.GetLength(0); i++) // laço de repetição para percorrer a array posição j

            {
                for (int j = 0; j < matrizA.GetLength(1); j++) // laço de repetição para percorrer a array na posição i
                {
                    Console.WriteLine("Por favor insira os primeiros numeros: ");
                    valorA = Convert.ToInt32(Console.ReadLine());
                    matrizA[i, j] = valorA;
                    
                }
            }

            for (int k = 0; k < matrizB.GetLength(0); k++) // laço de repetição para percorrer a array posição j

            {
                for (int l = 0; l < matrizB.GetLength(1); l++) // laço de repetição para percorrer a array na posição i
                {
                    Console.WriteLine("Por favor insira os primeiros numeros: ");
                    valorB = Convert.ToInt32(Console.ReadLine());
                    matrizB[k, l] = valorB;

                }
            }

            Console.WriteLine("O valor da nova matriz é: ");

            for (int m = 0; m < matrizC.GetLength(0); m++) // laço de repetição para percorrer a array posição j

            {
                for (int n = 0; n < matrizC.GetLength(1); n++) // laço de repetição para percorrer a array na posição i
                {
                    
                    matrizC[m, n] = matrizA[m, n] + matrizB[m, n];

                }
            }

            for (int o = 0; o < matrizC.GetLength(0); o++) // laço de repetição para percorrer a array posição j

            {
                
                Console.WriteLine(" {0} {1} {2} {3} ", matrizC[o, 0], matrizC[o, 1], matrizC[o, 2], matrizC[o, 3]);

                
            }
            

        }

        static void questao4()
        {

        }


    }
}
