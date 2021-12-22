using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
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
                        questao3(); // referencia a questao 3
                        break;
                    case 4: // caso se o numero informado for 4
                        questao4(); // referencia a questao 4
                        break;
                    case 5: // caso se o numero informado for 5
                        questao5(); // referencia a questao 5
                        break;
                    case 6: // caso se o numero informado for 6
                        questao6(); // referencia a questao 6
                        break;
                    case 7: // caso se o numero informado for 7
                        questao7(); // referencia a questao 7
                        break;
                    case 8: // caso se o numero informado for 8
                        questao8(); // referencia a questao 8
                        break;
                    case 9: // caso se o numero informado for 9
                        questao9(); // referencia a questao 9
                        break;
                    case 10: // caso se o numero informado for 10
                        questao10(); // referencia a questao 10
                        break;
                    case 11: // caso se o numero informado for 11
                        questao11(); // referencia a questao 11
                        break;
                    case 12: // caso se o numero informado for 12
                        questao12(); // referencia a questao 12
                        break;
                    case 13: // caso se o numero informado for 13
                        questao13(); // referencia a questao 13
                        break;
                    case 14: // caso se o numero informado for 14
                        questao14(); // referencia a questao 14
                        break;
                    case 15: // caso se o numero informado for 15
                        questao15(); // referencia a questao 15
                        break;
                    case 16: // caso se o numero informado for 16
                        questao16(); // referencia a questao 16
                        break;
                    case 17: // caso se o numero informado for 17
                        questao17(); // referencia a questao 17
                        break;
                    case 18: // caso se o numero informado for 18
                        questao18(); // referencia a questao 18
                        break;
                    case 19: // caso se o numero informado for 19
                        questao19(); // referencia a questao 19
                        break;
                    case 20: // caso se o numero informado for 20
                        questao20(); // referencia a questao 20
                        break;
                    case 21: // caso se o numero informado for 21
                        questao21(); // referencia a questao 21
                        break;
                    case 22:
                        Console.WriteLine("Questão 22: Escreva um procedimento que receba um número inteiro e imprima o mês correspondente ao número.Por exemplo, 2 corresponde à “fevereiro”. O procedimento deve mostrar uma mensagem de erro caso o número recebido não faça sentido.Gere também um programa que leia um valor e chame o procedimento criado.\n"); // output
                        Console.WriteLine("Informe o numero de um mes: "); // output
                        int mesDoAno = Convert.ToInt32(Console.ReadLine()); // input
                        questao22(mesDoAno); // chamar o procedimento criado como mes
                        break;
                    case 23:
                        Console.WriteLine("Questão 23: Escreva um procedimento que gere um cabeçalho para um relatório. Esse procedimento deve receber um literal(string, ou cadeia de caracteres) como parâmetro.\n"); // output
                        Console.WriteLine("Informe o nome do Aluno: "); // output
                        string nome = Console.ReadLine(); // input
                        questao23(nome); // chama o procedimento que gera o cabeçalho para o relatorio
                        break;
                    case 24:
                        Console.WriteLine("Questão 24: Criar uma função que determine se um caractere, recebido como parâmetro, é ou não uma letra do alfabeto.A função deve retornar 1 caso positivo e 0 em caso contrário.Escreva também um programa para testar tal função.\n"); // output
                        Console.WriteLine("Informe um caracter: ");
                        char caracter = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine(questao24(caracter));
                        break;
                    case 25:
                        Console.WriteLine("Questão 25: Criar uma função que calcule e retorne o MENOR entre dois valores recebidos como parâmetro.Um programa para testar tal função deve ser criado.\n"); // output
                        Console.WriteLine("Digite o primeiro número: "); // output
                        int valor1 = Convert.ToInt32(Console.ReadLine()); // input
                        Console.WriteLine("Por favor, digite o segundo número: "); // output
                        int valor2 = Convert.ToInt32(Console.ReadLine()); // input
                        questao25(valor1, valor2);
                        break;
                }

                Console.WriteLine("\nDeseja sair? S/N"); // output
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
            int numero; // a variavel numero foi declarada

            Console.WriteLine("Questão 1: Codifique um programa que leia um número inteiro qualquer e imprima o seu sucessor e seu antecessor.\n"); // output

            Console.WriteLine("Olá, por favor informe um número: "); // output
            numero = Convert.ToInt32(Console.ReadLine()); // input

            Console.WriteLine("O antecessor do numero é: " + (numero - 1) + " e O seu sucessor é: " + (numero + 1)); // output
        } // codigo questao 1
        static void questao2()
        {
            Console.WriteLine("Questão 2: Codifique um programa que leia três números reais quaisquer. A seguir o programa calcula e imprime a média aritmética desses três números.\n"); // output

            double num1, num2, num3, media; // as variaveis numero 1, 2, 3 e media foram declaradas

            Console.WriteLine("Olá, por favor informe o numero 1: "); // output
            num1 = Convert.ToDouble(Console.ReadLine()); // input

            Console.WriteLine("Olá, por favor informe o numero 2: "); // output
            num2 = Convert.ToDouble(Console.ReadLine()); // input

            Console.WriteLine("Olá, por favor informe o numero 3: "); // output
            num3 = Convert.ToDouble(Console.ReadLine()); // input

            media = (num1 + num2 + num3) / 3; // calculo da média dos 3 numeros
            Console.WriteLine("A média dos 3 numeros é: " + media); // output
        } // codigo questao 2
        static void questao3()
        {
            Console.WriteLine("Questão 3: Codifique um programa para realizar a conversão de uma temperatura em graus Celsius para graus Fahrenheit.O programa recebe com entrada a temperatura em Celsius e exibe o resultado da conversão para o usuário.\n"); // output
            double celci, fahr; // as variaveis celcius e fahrenheit foram declaradas

            Console.WriteLine("Olá, por favor informe a temperatura: "); // output
            celci = Convert.ToDouble(Console.ReadLine()); // input

            fahr = (celci * 1.8) + 32; // conversão de celcius para fahrenheit
            Console.WriteLine("A temperatura em Fahrenheit é de: " + fahr + "°F");
        } // codigo questao 3
        static void questao4()
        {
            Console.WriteLine("Questão 4: Certa importância em dólares será dividida entre três pessoas. A primeira receberá 30% da quantia total; a segunda 38 % e a terceira 32 %.Codifique um programa que leia o valor total da importância em dólares e calcule a parcela destinada a cada pessoa.\n"); // output
            double imp, pes1, pes2, pes3; // a variavel importancia, pessoa1, pessoa2 e pessoa3 foram declaradas

            Console.WriteLine("Olá, por favor informe o valor da importancia em dólares: "); // output
            imp = Convert.ToDouble(Console.ReadLine()); // input

            pes1 = 0.3 * imp; // calculo do valor da parcela da pessoa 1
            pes2 = 0.38 * imp; // calculo do valor da parcela da pessoa 2
            pes3 = 0.32 * imp; // calculo do valor da parcela da pessoa 3

            Console.WriteLine("A parcela destinada a pessoa 1 é de: $" + pes1 + "\nA parcela da pessoa 2 é de: $" + pes2 + "\nE a parcela final da pessoa 3 é de: $" + pes3); // output
        } // codigo questao 4
        static void questao5()
        {
            Console.WriteLine("Questão 5: Sabendo que o latão é obtido fundindo-se sete partes de cobre com três partes de zinco, escreva um programa que solicite quantos quilos de latão um usuário quer produzir.A seguir o programa informa ao usuário as quantidades de cobre e zinco necessárias.\n"); // output
            double latao, cobre, zinco; // as variaveis latao, cobre e zinco foram declaradas

            Console.WriteLine("Por favor informe a quantidade de latão desejada: "); // output
            latao = Convert.ToDouble(Console.ReadLine()); // input

            cobre = 0.7 * latao; // calculo da quantidade de cobre necessaria
            zinco = 0.3 * latao; // calculo da quantidade de zinco necessaria

            Console.WriteLine("A quantidade de cobre necessário é de: " + cobre + "Kg"); // output
            Console.WriteLine("A quantidade de zinco necessário é de: " + zinco + "Kg"); // output
        } // codigo questao 5
        static void questao6()
        {
            Console.WriteLine("Questão 6: Codifique um programa que faça a entrada de um número qualquer pelo teclado. A seguir o programa imprime uma mensagem textual somente se ele for maior que 20.\n"); // output
            int numero; // a variavel numero foi declarada

            Console.WriteLine("Por favor insira um numero: "); // output
            numero = Convert.ToInt32(Console.ReadLine()); // input

            if (numero > 20) // condiçao "se o numero for maior do que 20"
            {
                Console.WriteLine("O seu número é maior que 20! "); // output
            }
        } // codigo questao 6
        static void questao7()
        {
            Console.WriteLine("Questão 7: Codifique um programa que leia dois números inteiros e calcule a soma desses dois números.O programa somente imprimirá o resultado da soma quando a soma for maior que 10.Se a soma for menor ou igual a 10, o programa imprime uma mensagem de aviso ao usuário.\n"); // output
            int num1, num2, soma; // as variaveis numero 1, numero 2 e soma foram declaradas

            Console.WriteLine("Por favor insira o primeiro número: "); // output
            num1 = Convert.ToInt32(Console.ReadLine()); // input

            Console.WriteLine("Por favor insira o segundo número: "); // output
            num2 = Convert.ToInt32(Console.ReadLine()); // input

            soma = num1 + num2; // soma dos dois numeros

            if (soma > 10) // condição "se o resultado da soma for maior do que 10"
            {
                Console.WriteLine("O resultado da soma é: " + soma); // output
            }
            else // se a condição acima nao for atendida, isso ocorre
            {
                Console.WriteLine("Atenção! A soma inserida foi menor ou igual a 10. Por favor, reinicie o programa e insira outros números!"); // output
            }
        } // codigo questao 7
        static void questao8()
        {
            Console.WriteLine("Questão 8: Codifique um programa que faça a leitura de um número inteiro pelo teclado. A seguir, o programa determina se o número é par ou impar, imprimindo uma mensagem para o usuário.\n"); // output
            int numero; // a variavel numero foi declarada

            Console.WriteLine("Por favor insira um número: "); // output
            numero = Convert.ToInt32(Console.ReadLine()); // input

            if (numero % 2 == 0) // condição "se o resto da divisao por 2 for igual a 0" o número é par
            {
                Console.WriteLine("O número informado é par!"); // output
            }
            else // caso o numero nao atenda a condiçao acima, isso ocorre
            {
                Console.WriteLine("O número informado é ímpar!"); // output
            }
        } // codigo questao 8
        static void questao9()
        {
            Console.WriteLine("Questão 9: Codifique um programa que faça a leitura de um número inteiro pelo teclado. O programa deve exibir uma mensagem de texto identificando o número como “POSITIVO”,“NEGATIVO” ou “NULO” no caso do valor 0.\n"); // output
            int numero; // a variavel numero foi declarada

            Console.WriteLine("Por favor insira um número: "); // output
            numero = Convert.ToInt32(Console.ReadLine()); // input

            if (numero > 0) // condição "se o numero for maior que 0" ele é positivo
            {
                Console.WriteLine("O número inserido é POSITIVO!"); // output
            }
            else if (numero < 0) // condição "se o numero for menor que 0" ele é negativo
            {
                Console.WriteLine("O número inserido é NEGATIVO!"); // output
            }
            else // se o numero for igual a 0 ele é nulo
            {
                Console.WriteLine("O número inserido é NULO!"); // output
            }
        } // codigo questao 9
        static void questao10()
        {
            Console.WriteLine("Questão 10: Codifique um programa que faça a leitura de um número inteiro pelo teclado. Se o número for positivo, ou nulo(0), o programa calcula a raiz quadrada do número.Caso contrário, o programa calcula o quadrado desse número.\n"); // output
            double numero, raiz, numQuadrado; // a variavel numero foi declarada

            Console.WriteLine("Por favor insira um número: "); // output
            numero = Convert.ToDouble(Console.ReadLine()); // input

            if (numero >= 0) // condição "se o numero for maior ou igual a 0" isso ocorre
            {
                raiz = Math.Sqrt(numero);
                Console.WriteLine("O número inserido é maior ou igual a 0, portanto, a raiz quadrada do numero inserido é: " + raiz); // output
            }
            else
            {
                numQuadrado = Math.Pow(numero, 2);
                Console.WriteLine("O número inserido é menor que 0, portanto, o mesmo elevado ao quadrado é: " + numQuadrado); // output
            }
        } // codigo questao 10
        static void questao11()
        {
            Console.WriteLine("Questão 11: Codifique um programa que solicite ao usuário três valores, a saber: A, B e C. O programa deve imprimir os valores em ordem crescente(do menor para o maior).\n"); // output

            int num1, num2, num3; // as variaveis numero 1, 2 e 3 foram declaradas

            Console.WriteLine("Por favor, digite o primeiro numero: "); // output
            num1 = Convert.ToInt32(Console.ReadLine()); // input
            Console.WriteLine("Por favor, digite o segundo numero: "); // output
            num2 = Convert.ToInt32(Console.ReadLine()); // input
            Console.WriteLine("Por favor, digite o terceiro numero: "); // output
            num3 = Convert.ToInt32(Console.ReadLine()); // input

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("A ordem crescente é: " + num1 + ", " + num2 + ", " + num3);
            }
            else if (num1 < num3 && num3 < num2)
            {
                Console.WriteLine("A ordem crescente é: " + num1 + ", " + num3 + ", " + num2);
            }
            else if (num2 < num3 && num3 < num1)
            {
                Console.WriteLine("A ordem crescente é: " + num2 + ", " + num3 + ", " + num1);
            }
            else if (num2 < num1 && num1 < num3)
            {
                Console.WriteLine("A ordem crescente é: " + num2 + ", " + num1 + ", " + num3);
            }
            else if (num3 < num2 && num2 < num1)
            {
                Console.WriteLine("A ordem crescente é: " + num3 + ", " + num2 + ", " + num1);
            }
            else if (num3 < num1 && num1 < num2)
            {
                Console.WriteLine("A ordem crescente é: " + num3 + ", " + num1 + ", " + num2);
            }
        } // codigo questao 11
        static void questao12()
        {
            Console.WriteLine("Questão 12: Codifique um programa que solicite ao usuário três valores, a saber: A, B e C. O programa deve imprimir os valores em ordem decrescente(do menor para o maior).\n"); // output

            int num1, num2, num3; // as variaveis numero 1, 2 e 3 foram declaradas

            Console.WriteLine("Por favor, digite o primeiro numero: "); // output
            num1 = Convert.ToInt32(Console.ReadLine()); // input
            Console.WriteLine("Por favor, digite o segundo numero: "); // output
            num2 = Convert.ToInt32(Console.ReadLine()); // input
            Console.WriteLine("Por favor, digite o terceiro numero: "); // output
            num3 = Convert.ToInt32(Console.ReadLine()); // input

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("A ordem decrescente é: " + num1 + ", " + num2 + ", " + num3);
            }
            else if (num1 > num3 && num3 > num2)
            {
                Console.WriteLine("A ordem decrescente é: " + num1 + ", " + num3 + ", " + num2);
            }
            else if (num2 > num3 && num3 > num1)
            {
                Console.WriteLine("A ordem decrescente é: " + num2 + ", " + num3 + ", " + num1);
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine("A ordem decrescente é: " + num2 + ", " + num1 + ", " + num3);
            }
            else if (num3 > num2 && num2 > num1)
            {
                Console.WriteLine("A ordem decrescente é: " + num3 + ", " + num2 + ", " + num1);
            }
            else if (num3 > num1 && num1 > num2)
            {
                Console.WriteLine("A ordem decrescente é: " + num3 + ", " + num1 + ", " + num2);
            }
        } // codigo questao 12
        static void questao13()
        {
            Console.WriteLine("Questão 13: Codifique um programa que leia um número inteiro qualquer e determine se esse número é igual a 5, ou se é igual a 200, ou se é igual a 400, ou se está no intervalo aberto entre 500 e 1000(aberto nos dois extremos).O programa também verifica se o número não atende a nenhum dos critérios anteriores.\n"); // output

            int numero; // a variavel numero foi declarda
            Console.WriteLine("Por favor insira um numero: "); // output
            numero = Convert.ToInt32(Console.ReadLine()); // input

            if (numero == 5) // analisa se o numero é igual a 5
            {
                Console.WriteLine("O numero informado é igual a 5!"); // output se for true a primeira condição
            }
            else if (numero == 200) // analisa se o numero é igual a 200
            {
                Console.WriteLine("O numero informado é igual a 200!"); // output se for true a segunda condição
            }
            else if (numero == 400) // analisa se o numero é igual a 400
            {
                Console.WriteLine("O numero informado é igual a 400!"); // output se for true a terceira condição
            }
            else if (numero > 500 && numero < 1000) // analisa se o numero está no intervalo aberto entre 500 e 1000
            {
                Console.WriteLine("O numero informado está entre 500 e 1000 com intervalo aberto!"); // output se for true a quarta condição
            }
            else // executa se nenhuma das condições acima forem atendidas
            {
                Console.WriteLine("O numero informado não é 5 nem 200 ou 400. E também não está no intervalo aberto entre 500 e 1000!"); // output se todas as condiçoes anteriores forem false
            }
        } // codigo questao 13
        static void questao14()
        {
            Console.WriteLine("Questão 14: Codifique um programa que faça a leitura de dois números reais pelo teclado, (X) e (Y), respectivamente.O programa imprime o quadrado do menor número, e a raiz quadrada do maior número, quando for possível.\n"); // output

            double numx, numy, quad, raiz; // as variaveis numero x, y, quadrado do numero e raiz do numero foram declaradas

            Console.WriteLine("Por favor insira o primeiro número real x: "); // output
            numx = Convert.ToDouble(Console.ReadLine()); // input
            Console.WriteLine("Por favor insira o segundo número real y: "); // output
            numy = Convert.ToDouble(Console.ReadLine()); // input

            if (numx > numy)
            {
                raiz = Math.Sqrt(numx);
                quad = Math.Pow(numy, 2);
                Console.WriteLine("O numero x é maior que o y, portanto, a raiz de x (se for possível) é: " + raiz + ". E y ao quadrado é: " + quad);
            }
            else if (numx < numy)
            {
                raiz = Math.Sqrt(numy);
                quad = Math.Pow(numx, 2);
                Console.WriteLine("O numero y é maior que o x, portanto, a raiz de y (se for possível) é: " + raiz + ". E x ao quadrado é: " + quad);
            }
            else
            {
                Console.WriteLine("Os numeros inseridos sao iguais ou inválidos!");
            }
        } // codigo questao 14
        static void questao15()
        {
            Console.WriteLine("Questão 15: Escreva um programa que imprima todos os números inteiros de 0 a 50.\n"); // output

            for (int i = 0; i <= 50; i++) // laço de repetição
            {
                Console.WriteLine(i); // output
            }
        } // codigo questao 15
        static void questao16()
        {
            Console.WriteLine("Questão 16: Escreva um programa que imprima todos os números inteiros de 100 a 200.\n"); // output

            for (int i = 100; i <= 200; i++) // laço de repetição
            {
                Console.WriteLine(i); // output
            }
        } // codigo questao 16
        static void questao17()
        {
            Console.WriteLine("Questão 17: Escreva um programa que receba dez números do usuário e imprima o quadrado de cada número.\n"); // output

            for (int i = 1; i <= 10; i++) // laço de repetição que irá repetir 10 vezes
            {
                int num; // a variavel numero foi declarada
                Console.WriteLine("Por favor insira um numero: "); // output
                num = Convert.ToInt32(Console.ReadLine()); // input
                Console.WriteLine(Math.Pow(num, 2) + "\n"); // output  -  imprime o numero inserido pelo usuario ao quadrado
            }
        } // codigo questao 17
        static void questao18()
        {
            Console.WriteLine("Questão 18: Criar um programa que imprima todos os números de 1 até 100, inclusive, e a soma de todos eles.\n"); // output
            int soma = 0; // a variavel soma foi declarada
            for (int i = 1; i <= 100; i++) // laço for para repetiçao do numero 1 ao 100
            {
                soma = soma + i; // soma de todos os numeros
                Console.WriteLine(i + ", A soma total é: " + soma); // output
            }
        } // codigo questao 18
        static void questao19()
        {
            Console.WriteLine("Questão 19: Criar um programa que imprima todos os números de 1 até 100, inclusive, e a soma do quadrado desses números.\n"); // output
            int soma = 0; // a variavel soma foi declarada

            for (int i = 1; i <= 100; i++) // laço for para repetição do numero 1 ao 100
            {
                soma = soma + i * i; // soma dos quadrados dos numeros
                Console.WriteLine(i + ", A soma do quadrado dos numeros é: " + soma); // output
            }
        } // codigo questao 19
        static void questao20()
        {
            Console.WriteLine("Questão 20: Seja a seguinte série: 1, 4, 9, 16, 25, 36, ... Escreva um programa que gere esta série até o N - ésimo termo.Este N - ésimo termo é digitado pelo usuário.\n"); // output

            int numeroN; // a variavel numero N foi declarada
            int numeroNQuadrado; // a variavel numeroNQuadrado foi declarada

            Console.WriteLine("Digite o número desejado: "); // output
            numeroN = Convert.ToInt32(Console.ReadLine()); // input
            Console.WriteLine("A sequencia correta é: \n"); // output
            for (int v = 1; v <= numeroN; v++) // laço for para informar os numeros de 1 até o desejado pelo usuario
            {
                numeroNQuadrado = v * v; // calculo do quadrado dos numeros 
                Console.WriteLine(v + "x" + v + "=" + numeroNQuadrado + "\n"); // output
            }
        } // codigo questao 20
        static void questao21()
        {
            Console.WriteLine("Questão 21: Seja a seguinte série: 1, 4, 4, 2, 5, 5, 3, 6, 6, 4, 7, 7, ... Escreva um programa que seja capaz de gerar os N termos dessa série.Esse número N deve ser lido do teclado.\n"); // output
            int numeroN; // a variavel numero N foi declarada
            Console.WriteLine("Escreva o número desejado: "); // output
            numeroN = Convert.ToInt32(Console.ReadLine()); // input

            for (int i = 1; i <= numeroN; i++) // laço for de repetiçao de 1 ate o numero desejado
            {
                Console.Write(i + ", " + (i + 3) + ", " + (i + 3) + ", "); // sequencia de numeros para i, i+3 e i+3
            }
        } // codigo questao 21
        static void questao22(int mes)
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro"); // output caso o numero digitado seja = 1
                    break;
                case 2:
                    Console.WriteLine("Fevereiro"); // output caso o numero digitado seja = 2
                    break;
                case 3:
                    Console.WriteLine("Março"); // output caso o numero digitado seja = 3
                    break;
                case 4:
                    Console.WriteLine("Abril"); // output caso o numero digitado seja = 4
                    break;
                case 5:
                    Console.WriteLine("Maio"); // output caso o numero digitado seja = 5
                    break;
                case 6:
                    Console.WriteLine("Junho"); // output caso o numero digitado seja = 6
                    break;
                case 7:
                    Console.WriteLine("Julho"); // output caso o numero digitado seja = 7
                    break;
                case 8:
                    Console.WriteLine("Agosto"); // output caso o numero digitado seja = 8
                    break;
                case 9:
                    Console.WriteLine("Setembro"); // output caso o numero digitado seja = 9
                    break;
                case 10:
                    Console.WriteLine("Outubro"); // output caso o numero digitado seja = 10
                    break;
                case 11:
                    Console.WriteLine("Novembro"); // output caso o numero digitado seja = 11
                    break;
                case 12:
                    Console.WriteLine("Dezembro"); // output caso o numero digitado seja = 12
                    break;
                default:
                    Console.WriteLine("O mes digitado esta errado!"); // output caso o numero seja inválido ou maior do que 12, uma vez que o ano só vai até 12 meses.
                    break;
            }
        } // codigo questao 22
        static void questao23(string aluno)
        {
            Console.WriteLine("============================================"); // output
            Console.WriteLine("UFMG – Universidade Federal de Minas Gerais"); // output
            Console.WriteLine("ICEx – Instituto de Ciências Exatas"); // output
            Console.WriteLine("Disciplina de Programação de Computadores"); // output
            Console.WriteLine("Nome: " + aluno); // output
            Console.WriteLine("============================================"); // output
        } // codigo questao 23
        static int questao24(char testeDeChar)
        {
            int codigo = Convert.ToInt32(testeDeChar); // convertendo o caracter para numero para avaliar se é letter ou nao
            if ((codigo >= 65 && codigo <= 90) || (codigo >= 97 && codigo <= 122)) // intervalo da tabela ASCII que corresponde as letras minusculas e maiusculas
            {
                return 1; // output
            }
            else // se falso
            {
                return 0; // output 
            }
        } // codigo questao 24
        static void questao25(int v1, int v2)
        {
            if (v1 < v2)
            {
                Console.WriteLine(v1);
            }
            else
            {
                Console.WriteLine(v2);
            }
        } // codigo questao 25
    }
}

