using System;

namespace firstappwithCSharp
{
    class Nivel1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nível 1 --> \nEscolha uma questão de 1-10");
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
            }
        }

        public static void questao01()
        {
            Console.WriteLine("Informe a quantidade mínima de peças: ");
            int qtdMinima = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme a quantidade máxima de peças: ");
            int qtdMaxima = Convert.ToInt32(Console.ReadLine());

            double mediaPecas = (qtdMinima + qtdMaxima) / 2.0;

            Console.WriteLine("\nMédia de Peças: " + mediaPecas);
        }

        public static void questao02() {
            Console.WriteLine("Informe a cotação do dólar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nAgora informe um valor em dólar: ");
            double valorDolar = Convert.ToDouble(Console.ReadLine());

            double valorReal = cotacaoDolar * valorDolar;

            Console.WriteLine("\nA conversão para R$ deu: " + valorReal);
        }

        public static void questao03()
        {
            Console.WriteLine("Informe a identificação do vendedor: ");
            string identificacaoVendedor= Console.ReadLine();
            Console.WriteLine("\nInforme o código da peça: ");
            string codigoPeca = Console.ReadLine();
            Console.WriteLine("\nInforme o valor unitário da peça: ");
            double valorPeca = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme a quantidade vendida: ");
            double qtdVendida = Convert.ToInt32(Console.ReadLine());

            double porcentagemComissao = (valorPeca * qtdVendida) * 0.05;

            Console.WriteLine("\nA comissão da venda do produto: " + codigoPeca + " , para o vendedor: " + identificacaoVendedor + " foi de : " + porcentagemComissao + "R$");
        }

        public static void questao04()
        {
            Console.WriteLine("Informe o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme o valor de C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme o valor de D: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operação 01 --> \nSoma: A+B = " + (a + b) + "\nMultiplicação: A*B = " + (a * b));
            Console.WriteLine("Operação 02 --> \nSoma: A+C = " + (a + c) + "\nMultiplicação: A*C = " + (a * c));
            Console.WriteLine("Operação 03 --> \nSoma: A+D = " + (a + d) + "\nMultiplicação: A*D = " + (a * d));
            Console.WriteLine("Operação 04 --> \nSoma: B+C = " + (b + c) + "\nMultiplicação: B*C = " + (b * c));
            Console.WriteLine("Operação 05 --> \nSoma: B+D = " + (b + d) + "\nMultiplicação: B*D = " + (b * d));
            Console.WriteLine("Operação 06 --> \nSoma: C+D = " + (c + d) + "\nMultiplicação: C*D = " + (c * d));
        }

        public static void questao05()
        {
            Console.WriteLine("Informe o tempo gasto na viagem: ");
            double tempoViagem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme a velocidade média: ");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = tempoViagem * velocidadeMedia;

            double litrosUsados = distanciaPercorrida / 12;

            Console.WriteLine("Velocidade média: " + velocidadeMedia + "\nTempo gasto: " + tempoViagem + "\nDistância Percorrida: " + distanciaPercorrida + "\nQuantidade de litros utilizada: " + litrosUsados);
        }

        public static void questao06()
        {
            Console.WriteLine("Informe uma temperatura em graus celsius: ");
            double grausC = Convert.ToDouble(Console.ReadLine());

            double grausF = (9 * grausC + 150) / 5;

            Console.WriteLine("\nO valor convertido para graus fahrenheit é: " + grausF);
         
        }

        public static void questao07()
        {
            Console.WriteLine("Informe uma temperatura em graus fahrenheit: ");
            double grausF = Convert.ToDouble(Console.ReadLine());

            double grausC = (grausF - 32) * 5/9;

            Console.WriteLine("\nO valor convertido para graus celsius é: " + grausC);

        }

        public static void questao08()
        {
            Console.WriteLine("Informe o raio da lata: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme a altura da lata: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double v = 3.14159 * r * r * a;

            Console.WriteLine("\nO volume da lata é: " + v);

        }

        public static void questao09()
        {
            Console.WriteLine("Informe sua idade: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme quantos meses voce tem: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme quantos dias voce tem: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            int diasTotais = (ano * 365) + (mes*30) + dia;

            Console.WriteLine("\nSua idade em dias é: " + diasTotais);

        }

        public static void questao10()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInforme o segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("\nO primeiro número é maior!");
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("\nOs números são iguais!");
            }
            else {
                Console.WriteLine("\nO segundo número é maior!");
            }

        }
    }
}
