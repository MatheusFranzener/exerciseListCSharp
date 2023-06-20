using System;
using System.Collections.Generic;
using System.Text;

namespace firstappwithCSharp.atividades
{
    class Nivel4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nível 4 --> \nEscolha uma questão de 1-18");
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
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
            }
        }

        public static void questao01()
        {
            for (int i = 100; i > 0; i--) {
                Console.WriteLine(i);
            }
        }

        public static void questao02()
        {
            Console.WriteLine("Insira a quantidade de números que deseja calcular a fatorial: ");
            int qtdNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdNum; i++) {
                Console.WriteLine("Informe um número: (" + i + ")");
                int numero = Convert.ToInt32(Console.ReadLine());

                long resultadoFatorial = fatorialNum(num);

                Console.WriteLine("O resultado do fatorial foi: " +  resultadoFatorial);
            }
        }

        public static long fatorialNum(int num) {
            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }

        public static void questao03()
        {
           for(int i= 100; i<=200; i++)
            {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

        public static void questao04() {
            for (int i = 1; i <= 2000; i++) { 
                Console.Write(i);
            }
        }

        public static void questao05() {
            Console.WriteLine("Selecione uma tabuada: (1-10)");
            int numTabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(i + " X " + numTabuada +  " = " + i * numTabuada);
            }
        }

        public static void questao06()
        {
            int numero = 0, pares = 0, impares = 0;

            while (numero >= 0) {
                Console.WriteLine("Informe um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par!");
                    pares += numero;
                }
                else {
                    Console.WriteLine("O número é ímpar!");
                    impares += numero;
                }
            }

            Console.WriteLine("Soma dos números pares: " + pares + "\nSoma dos números ímpares: " + impares);
        }

        public static void questao07()
        {

        }
    }
}
