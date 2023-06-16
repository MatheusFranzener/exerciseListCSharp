using System;
using System.Collections.Generic;
using System.Text;

namespace firstappwithCSharp
{
    class class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nível 2 --> \nEscolha uma questão de 1-12");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    questao01();
                    break;
                case 2:
                    questao02();
                    break;
                case 3:
                    questao03();
                    break;
                case 4:
                    questao04();
                    break;
                case 5:
                    questao05();
                    break;
                case 6:
                    questao06();
                    break;
                case 7:
                    questao07();
                    break;
                case 8:
                    questao08();
                    break;
                case 9:
                    questao09();
                    break;
                case 10:
                    questao10();
                    break;
                case 11:
                    questao11();
                    break;
                case 12:
                    questao12();
                    break;
            }
        }

        public static void questao01() {
            Console.WriteLine("Informe o valor A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme o valor B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            
            a = b;
            b = c;

            Console.Write("\nO novo valor de A é: " + a + "\nO novo valor de B é: " + b);
        }

        public static void questao02()
        {
            Console.WriteLine("Informe um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int modulo;

            if (numero >= 0)
            {
                modulo = numero;
            }
            else {
                modulo = numero * -1;
            }

            Console.Write("\nO módulo desse número é: " + modulo);
        }

        public static void questao03()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int primeiro = 0, segundo = 0, terceiro = 0;

            if (numero > numero2 && numero > numero3)
            {
                primeiro = numero;
                if (numero2 > numero3)
                {
                    segundo = numero2;
                    terceiro = numero3;
                }
                else
                {
                    segundo = numero3;
                    terceiro = numero2;
                }
            }
            else if (numero2 > numero && numero2 > numero3)
            {
                primeiro = numero2;

                if (numero > numero3)
                {
                    segundo = numero;
                    terceiro = numero3;
                }
                else
                {
                    segundo = numero3;
                    terceiro = numero2;
                }
            }
            else {
                primeiro = numero3;

                if (numero > numero2) {
                    segundo = numero;
                    terceiro = numero2;
                }
            }

            Console.WriteLine("\nPrimeiro: " + primeiro + " - Segundo: " + segundo + " - Terceiro: " + terceiro);
            
        }

        public static void questao04()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int diferenca;

            if (numero2 >= numero)
            {
                diferenca = numero2 - numero;
            }
            else {
                diferenca = numero - numero2;
            }

            Console.WriteLine("Diferença: " + diferenca);
        }

        public static void questao05()
        {
            Console.WriteLine("Informe a primeira nota: ");
            double nota1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado - Média: " + media);
            }
            else {
                Console.WriteLine("Informe a nota da recuperação: ");
                double recuperacao = Convert.ToDouble(Console.ReadLine());

                double novaMedia = media + recuperacao;

                if (novaMedia >= 7)
                {
                    Console.WriteLine("Aprovado na Recuperação - Média: " + novaMedia);
                }
                else {
                    Console.WriteLine("Reprovado - Média: " + novaMedia);
                }
            }
        }

        public static void questao06()
        {
            Console.WriteLine("Informe um numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe outro numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero > numero2)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else if (numero2 > numero)
            {
                Console.WriteLine("O segundo número é maior");
            }
            else {
                Console.WriteLine("Os números são iguais");
            }
        }

        public static void questao07()
        {
            Console.WriteLine("Informe um numero (0-9): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Válido");
            }
            else {
                Console.WriteLine("Inválido");
            }

        }

        public static void questao08()
        {
            Console.WriteLine("Informe o codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo) {
                case 1:
                    Console.WriteLine("um");
                    break;
                case 2:
                    Console.WriteLine("dois");
                    break;
                case 3:
                    Console.WriteLine("três");
                    break;
                default:
                    Console.WriteLine("Código inválido!");
                    break;
            }

        }

        public static void questao09()
        {
            Console.WriteLine("Informe o valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isóceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else {
                Console.WriteLine("Não é um triângulo");
            }

        }

        public static void questao10()
        {

            int a = -0, b = 0, c = 0;
            int maiorValor = 0, menorValor = 0;
            bool negativo = true;

            do {
                Console.WriteLine("Insira o valor a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o valor b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o valor c: ");
                c = Convert.ToInt32(Console.ReadLine());

                if (a < 0 || b < 0 || c < 0)
                {
                    Console.WriteLine("Insira apenas valores positivos!");
                    negativo = true;
                }
                else {
                    negativo = false;
                }

            } while (negativo);

            if (a > b && a > c)
            {
                maiorValor = a;

                if (b > c)
                {
                    menorValor = c;
                }
                else
                {
                    menorValor = b;
                }
            }
            else if (b > a && b > c)
            {
                maiorValor = b;

                if (a > c)
                {
                    menorValor = c;
                }
                else
                {
                    menorValor = a;
                }
            }
            else if (c > a && c > b) {
                maiorValor = c;

                if (b > a)
                {
                    menorValor = a;
                }
                else {
                    menorValor = b;
                }
            }

            Console.WriteLine("Menor * Maior: " + (menorValor * maiorValor) + "\nMaior / Menor: " + (maiorValor / menorValor));

        }


        public static void questao11()
        {
            int a = 0;
            bool parar = false;

            do
            {
                Console.WriteLine("Insira um número: ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a >= 0)
                {
                    Console.WriteLine("O número é positivo");
                }
                else {
                    Console.WriteLine("O número é negativo");
                }

                Console.WriteLine("Deseja continuar ou encerrar programa? \n1- Continuar \n2- Encerrar \n>: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 2) {
                    parar = true;
                }

            } while (!parar);
        }

        public static void questao12()
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("Informe um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                a = numero;
                Console.WriteLine("Armazenado no A: " + a);
            }
            else {
                b = numero;
                Console.WriteLine("Armazenado no B: " + b);
            }

        }
    }
}
