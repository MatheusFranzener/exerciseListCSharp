using System;
using System.Collections.Generic;
using System.Text;

namespace firstappwithCSharp.atividades
{
    class Nivel4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N�vel 4 --> \nEscolha uma quest�o de 1-19");
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
                case 13:
                    questao13();
                    break;
                case 14:
                    questao14();
                    break;
                case 15:
                    questao15();
                    break;
                case 16:
                    questao16();
                    break;
                case 17:
                    questao17();
                    break;
                case 18:
                    questao18();
                    break;
                case 19:
                    questao19();
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
            Console.WriteLine("Insira a quantidade de n�meros que deseja calcular a fatorial: ");
            int qtdNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdNum; i++) {
                Console.WriteLine("Informe um n�mero: (" + i + ")");
                int numero = Convert.ToInt32(Console.ReadLine());

                long resultadoFatorial = fatorialNum(numero);

                Console.WriteLine("O resultado do fatorial foi: " +  resultadoFatorial);
            }
        }

        public static long fatorialNum(int numero) {
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
                Console.WriteLine("Informe um n�mero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O n�mero � par!");
                    pares += numero;
                }
                else {
                    Console.WriteLine("O n�mero � �mpar!");
                    impares += numero;
                }
            }

            Console.WriteLine("Soma dos n�meros pares: " + pares + "\nSoma dos n�meros �mpares: " + impares);
        }

        public static void questao07()
        {
            Console.WriteLine("Informe um n�mero de (1-10): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int quadrados = 0;

            for (int i = numero; i < numero + 20; i++) {
                if (i % 2 != 0) {
                    quadrados += (i * i);
                }
            }

            Console.WriteLine("Soma dos quadrados dos n�meros �mpares: " + quadrados);
        }

        public static void questao08()
        {
            Console.WriteLine("Informe a quantidade de alunos que realizaram a prova: ");
            int qtdAlunos = Convert.ToInt32(Console.ReadLine());

            double notasAlunos = 0, media;

            for (int i = 0; i < qtdAlunos; i++) {
                Console.WriteLine("Infomre o n�mero da matricula: ");
                string numeroMatricula = Console.ReadLine();
                Console.WriteLine("Informe a nota do aluno: ");
                notasAlunos += Convert.ToDouble(Console.ReadLine());
            }

            media = notasAlunos / qtdAlunos;

            Console.WriteLine("A m�dia de notas da turma foi: " + media);
        }

        public static void questao09()
        {
            int num = 0, maior = 0, menor = 9999;

            while (num >= 0) {
                Console.WriteLine("Informe um n�mero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > maior) {
                    maior = num;
                }

                if (num < menor) {
                    menor = num;
                }

                Console.WriteLine("Maior n�mero: " + maior + "\nMenor n�mero: " + menor);
            }
        }

        public static void questao10()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i + " � m�ltiplo de 10!");
                }
            }
        }

        public static void questao11()
        {
            int num = 0, maior = 0, menor = 9999, soma = 0;
            double media = 0;

            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine("Informe um n�mero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }

                if (num < menor)
                {
                    menor = num;
                }

                soma += num;
                
            }

            media = soma / 10;

            Console.WriteLine("Maior n�mero: " + maior + "\nMenor n�mero: " + menor + "\nM�dia: " + media);
        }

        public static void questao12()
        {
            string resposta = "S";
            int opcao;
            double num1, num2, resultado = 0;

            while (resposta == "S" || resposta == "s") {
                Console.WriteLine("Escolha uma opera��o: \n1- Adi��o \n2- Subtra��o \n3- Multiplica��o \n4- Divis�o \n>: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o primeiro n�mero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o segundo n�mero: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                }

                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("Deseja voltar ao menu principal? ");
                resposta = Console.ReadLine();
            }
        }

        public static void questao13()
        {
            string resposta = "S";
            int codigo;
            double horasTrabalhadas, excesso = 0, salario = 0;

            while (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Informe o c�digo do funcion�rio: ");
                codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

                if (horasTrabalhadas > 50)
                {
                    excesso = (horasTrabalhadas - 50) * 20;
                }
                else {
                    salario = horasTrabalhadas * 10;
                }

                Console.WriteLine("Sal�rio total: " + salario + " -- Sal�rio Excedente: " + excesso);

                Console.WriteLine("Deseja encerrar o programa? ");
                resposta = Console.ReadLine();
            }
        }

        public static void questao14()
        {
            string resposta = "S";
            int numero = 0;

            while (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Informe um n�mero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O n�mero � par!");
                }
                else { 
                    Console.WriteLine("O n�mero � �mpar!");
                }

                if (numero >= 0)
                {
                    Console.WriteLine("O n�mero � positivo!");
                }
                else { 
                    Console.WriteLine("O n�mero � negativo!");
                }

                Console.WriteLine("Deseja encerrar o programa? ");
                resposta = Console.ReadLine();
            }
        }

        public static void questao15()
        {
            string resposta = "S";
            double indice= 0;

            while (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Informe o �ndice de polui��o: ");
                indice += Convert.ToDouble(Console.ReadLine());

                if (indice >= 0.3 && indice < 0.4)
                {
                    Console.WriteLine("Empresas do 1 grupo dever�o parar suas atividades!");
                }
                else if (indice >= 0.4 && indice < 0.5)
                {
                    Console.WriteLine("Empresas do 1 grupo e grupo 2 dever�o parar suas atividades!");
                }
                else {
                    Console.WriteLine("Todas as empresas dever�o parar suas atividades!");
                }

                Console.WriteLine("Deseja encerrar o programa? ");
                resposta = Console.ReadLine();
            }
        }

        public static void questao16()
        {
            Console.WriteLine("Informe a idade do nadador: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Categoria: Infantil A");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Categoria: Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Categoria: Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Categoria: Juvenil B");
            }
            else { 
                Console.WriteLine("Adultos");
            }
        }

        public static void questao17()
        {
            int numero = 0, maior = 0, menor = 9999, opcao = 1;

            while (opcao > 0)
            {
                Console.WriteLine("Informe um n�mero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                Console.WriteLine("Deseja encerrar o programa? (0- Sim) (1- N�o)");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Maior n�mero: " + maior + "\nMenor n�mero: " + menor);
        }

        public static void questao18()
        {

            int numeroQuadros = 64;

            ulong totalGraos = 0;
            ulong graosQuadroAnterior = 0;

            for (int i = 1; i <= numeroQuadros; i++)
            {
                ulong graosQuadroAtual = (ulong)Math.Pow(2, i - 1);
                totalGraos += graosQuadroAtual;

                Console.WriteLine("Quadro {0}: {1} gr�os", i, graosQuadroAtual);

                graosQuadroAnterior = graosQuadroAtual;
            }

            Console.WriteLine("Total de gr�os: " + totalGraos);
        }

        public static void questao19()
        {
            string resposta = "S";
            int opcao;
            double grausF = 0, grausC = 0, altura = 0, pesoIdeal = 0, peso = 0;

            while (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Escolha uma op��o \n1- Convers�o de Graus Celsius em Graus Fahrenheit \n2� Convers�o de Graus Fahrenheit em Graus Celsius \n3� Peso ideal do homem \n4� Peso ideal da mulher ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.WriteLine("Informe os graus celsius: ");
                        grausC = Convert.ToDouble(Console.ReadLine());

                        grausF = (9 * grausC + 160) / 5;
                        Console.WriteLine("Convers�o; " + grausF);
                        break;
                    case 2:
                        Console.WriteLine("Informe os graus fahrenheit: ");
                        grausF = Convert.ToDouble(Console.ReadLine());

                        grausC = (grausF - 32) * 5 / 9;
                        Console.WriteLine("Convers�o; " + grausC);
                        break;
                    case 3:
                        Console.WriteLine("Informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());

                        pesoIdeal = (72.7 * altura) - 58;

                        if (peso > pesoIdeal)
                        {
                            Console.WriteLine("Voc� est� acima do peso ideal");
                        }
                        else if (peso < pesoIdeal) {
                            Console.WriteLine("Voc� est� abaixo do peso ideal");
                        } else
                        {
                            Console.WriteLine("Voc� est� no peso ideal");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());

                        pesoIdeal = (62.1 * altura) - 44.7;

                        if (peso > pesoIdeal)
                        {
                            Console.WriteLine("Voc� est� acima do peso ideal");
                        }
                        else if (peso < pesoIdeal)
                        {
                            Console.WriteLine("Voc� est� abaixo do peso ideal");
                        }
                        else
                        {
                            Console.WriteLine("Voc� est� no peso ideal");
                        }
                        break;
                }

                Console.WriteLine("Deseja encerrar o programa? ");
                resposta = Console.ReadLine();
            }
        }
    }
}
