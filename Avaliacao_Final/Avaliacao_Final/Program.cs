using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Final
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int questao; // a variavel questao foi declarada
            bool executa = true; // a variavel executa foi declarada como true
            string valor = ""; // a variavel valor foi declarada como string para decidir se o programa continua ou para
            string[,] matriz = new string[10, 10];

            while (executa) // estrutura de repetição para decidir se mantem o programa rodando ou para
            {
                Console.WriteLine("Olá, por favor informe o numero da questao: "); // output

                questao = Convert.ToInt32(Console.ReadLine()); // input

                switch (questao) // switch para escolher qual a questao irá aparecer dependendo do numero inserido
                {
                    case 1: // caso se o numero informado for 1
                        questao1(matriz);
                        estruturaMatriz1(matriz);
                        int numx, numy;
                        Console.WriteLine();
                        Console.WriteLine("Por favor insira um número: ");
                        numx = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor insira o segundo número: ");
                        numy = Convert.ToInt32(Console.ReadLine());
                        substituicao(numx, numy, matriz);
                        estruturaMatriz1(matriz);
                        break;
                    
                    case 2: // caso se o numero informado for 2
                        
                        string aluno = "";

                        char opcao;
                        Console.WriteLine("Deseja Pesquisar ou Cadastrar? P/C");
                        opcao = Convert.ToChar(Console.ReadLine());
                        
                        if (opcao == 'P')
                        {
                           
                            Console.WriteLine("Escreva o nome do aluno: ");
                            aluno = Console.ReadLine();

                        }

                        questao2(opcao, aluno);
                        break;
                    
                    case 3: // caso se o numero informado for 3
                        Console.WriteLine("Questão 3 (4 pontos): Codifique um procedimento em C# que receba uma Lista com 10 números inteiros quaisquer.Já no procedimento, percorra a lista e adicione os 10 números contidos na lista em uma pilha.Posteriormente remova os itens da pilha adicionando - os em uma fila.Ao final, remova os itens da fila adicionando - os na lista recebida como parâmetro, que já possui os valores iniciais.Imprima o resultado final da lista."); // output
                        List<int> numeros = new List<int>();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Por favor, insira um numero: ");
                            numeros.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        questao3(numeros);
                        Console.WriteLine();
                        foreach (int item in numeros)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 4: // caso se o numero informado for 4
                        double celci; // variavel celcius declarada
                        Console.WriteLine("Questão 4 (4 pontos): Codifique uma função em C# para realizar a conversão de uma temperatura em graus Celsius para graus Fahrenheit.O programa recebe com entrada a temperatura em Celsius e exibe o resultado da conversão para o usuário.\n"); // output
                        Console.WriteLine("Olá, por favor informe a temperatura em celcius: "); // output
                        celci = Convert.ToDouble(Console.ReadLine()); // input
                        Console.WriteLine("A temperatura em Fahrenheit é de: " + questao4(celci) + "°F"); // output
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

        static void questao1(string[,] matriz)
        {
            Console.WriteLine("Questão 1 (6 pontos): Faça um programa em C# capaz de preparar uma matriz 10x10 com valores de string e, ao final, imprima os valores da matriz.Posteriormente, seu programa deverá solicitar ao usuário dois números x e y, não repetidos, onde - 1 > x e y < 10.Seu programa deverá trocar todos os valores da linha x por “L” e os valores da coluna y por “C”. No entanto, o ponto onde se interceptam deverá receber o valor de “I”. Ao final, imprima todos os valores da matriz."); // output

            
            int numero = 1;

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = numero.ToString();
                    numero++;
                    
                }
            }


        } // questao 1

        static void estruturaMatriz1(string[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                Console.WriteLine();
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} | ");
                }
            }


        } // matriz questao 1

        static void substituicao(int numx, int numy, string[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    string letra = "";
                    
                    if (numx == linha)
                    {
                        letra = "L";
                    }

                    else if (numy == coluna)
                    {
                        letra = "C";
                    }
                   
                    if (numy == coluna && numx == linha)
                    {
                        letra = "I";
                    }

                    if (letra != "")
                    {
                        matriz[linha, coluna] = letra;
                    }
                }
            }
        } // substituicao matriz questao 1

        static void questao2(char opc, string aln)
        {
            double[] vPeso = new double[10];
            string[] vNome = new string[10];
            double[] vAltura = new double[10];

            double peso, altura;
            string nome;
            
            if (opc == 'C')
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Digite um nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite sua altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite seu peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());

                    vNome[i] = nome;

                    vPeso[i] = peso;

                    vAltura[i] = altura;

                }
            }

            else if (opc == 'P')
            {
                double pMedio = 0;
                double aMedia = 0;
                int index = 0;
                string resultadop = "";
                string resultadoa = "";

                for (int i = 0; i < vNome.Length; i++)
                {
                    pMedio += vPeso[i];
                    aMedia += vAltura[i];
                    
                    
                    if (vNome[i] == aln)
                    {

                        index = i;
                        
                    }

                }

                pMedio = pMedio / vPeso.Length;
                aMedia = aMedia / vAltura.Length;

                resultadop = vPeso[index] > pMedio ? "Peso acima da média. " : "Peso abaixo da média. ";
                resultadoa = vAltura[index] > aMedia ? "Altura acima da média. " : "Peso abaixo da média. ";

                Console.WriteLine("Nome do aluno: {0}\n Altura: {1}\n Peso: {2}\n PesoMédio({3}): {4}\n AlturaMédia({5}): {6}", vNome[index], vAltura[index], vPeso[index], pMedio, resultadop, aMedia, resultadoa);

            }
            
        } // questao 2
        static void questao3(List<int> numeros)
        {
            Stack<int> pilha = new Stack<int>();
            Queue<int> fila = new Queue<int>();
            
            foreach (int select in numeros)
            {
                pilha.Push(select);
            }

            while (pilha.Count != 0)
            {
                fila.Enqueue(pilha.Pop());
            }

            while (fila.Count != 0)
            {
                numeros.Add(fila.Dequeue());
            }


        } // questao 3
        static double questao4(double celci)
        {
            double fahr; // as variaveis celcius e fahrenheit foram declaradas

            fahr = (celci * 1.8) + 32; // conversão de celcius para fahrenheit

            return fahr; // retorno funcao
        } // questao 4
        static void questao5()
        {
            Console.WriteLine("Questão 5 (10 pontos): Marque V para as questões Verdadeiras ou F para as Falsas."); // output

            Console.WriteLine("V\n"); 
            Console.WriteLine("F\n");
            Console.WriteLine("F\n");
            Console.WriteLine("F\n");
            Console.WriteLine("V\n"); 
            Console.WriteLine("V\n");
            Console.WriteLine("V\n");
            Console.WriteLine("F\n"); 
            Console.WriteLine("F\n");
            Console.WriteLine("F\n"); 
            Console.WriteLine("V\n"); 
            Console.WriteLine("F\n"); 
            Console.WriteLine("F\n"); 
            Console.WriteLine("V\n"); 
            Console.WriteLine("F\n"); 
            Console.WriteLine("F\n"); 
            Console.WriteLine("F\n"); 
            Console.WriteLine("V\n"); 
            Console.WriteLine("F\n"); 
            Console.WriteLine("F\n");

        } // questao 5

        
        
    }
}


