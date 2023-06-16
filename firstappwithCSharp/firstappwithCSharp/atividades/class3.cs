using System;
using System.Collections.Generic;
using System.Text;

namespace firstappwithCSharp.atividades
{
    class Nivel3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nível 3 --> \nEscolha uma questão de 1-3");
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
            }
        }

        public static void questao01() {
            Console.WriteLine("Informe um numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe um numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma opção \n1- Soma \n2- Adicao \n3- Multiplicacao \n4- Divisao \n>: ");
            int opcao= Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcao) {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    break;
            }

            Console.WriteLine("Resultado: " + resultado);
        }

        public static void questao02() {
            Console.WriteLine("Informe um numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe um numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma opção \n1- Verificar multiplos \n2- Verificar pares \n3- Verificar media \n4- Sair \n>: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

          
            switch (opcao)
            {
                case 1:
                    if (numero1 % numero2 == 0)
                    {
                        Console.WriteLine("Numero 1 é múltiplo do segundo número");
                    }
                    else if (numero2 % numero1 == 0)
                    {
                        Console.WriteLine("Numero 2 é múltiplo do primeiro número");
                    }
                    else {
                        Console.WriteLine("Não são múltiplos");
                    }

                    break;
                case 2:
                    if (numero1 % 2 == 0 && numero2 % 2 == 0)
                    {
                        Console.WriteLine("Os números são pares");
                    }
                    else {
                        Console.WriteLine("Os números não são pares");
                    }
                    break;
                case 3:
                    double media = (numero1 + numero2) / 2;

                    if (media >= 7)
                    {
                        Console.WriteLine("Média maior ou igual a 7");
                    }
                    else {
                        Console.WriteLine("Média menor que 7");
                    }

                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }

        public static void questao03()
        {

        }
    }
}
