namespace ProcessoSeletivoDevJr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para uma melhor exibição de informações, foram utilizados vários Console.WriteLine() nas funções


            //ImprimirSoma();
            //ChecarPresencaNaFibonacci();
            //VerificarPercentualNoFaturamento();
            InverterString();


            /*
             3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, 
                    faça um programa, na linguagem que desejar, que calcule e retorne:

                • O menor valor de faturamento ocorrido em um dia do mês;
                • O maior valor de faturamento ocorrido em um dia do mês;
                • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

                IMPORTANTE:
                a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
                b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
            
             */





        }
    
        static void ImprimirSoma()
        {
            Console.WriteLine("1) Imprimir soma após iterações:");
            Console.WriteLine();
            Console.WriteLine("   Observe o trecho de código abaixo:");
            Console.WriteLine();
            Console.WriteLine("     int INDICE = 13, SOMA = 0, K = 0;");
            Console.WriteLine("     enquanto K < INDICE faça");
            Console.WriteLine("     {");
            Console.WriteLine("         K = K + 1;");
            Console.WriteLine("         SOMA = SOMA + K;");
            Console.WriteLine("     }");
            Console.WriteLine("     imprimir(SOMA);");
            Console.WriteLine();
            Console.WriteLine("   Ao final do processamento, qual será o valor da variável SOMA?");

            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }
            Console.WriteLine();
            Console.WriteLine($"   A resposta deste exercício é: {soma}");

            Console.ReadKey();
        }
    
    
        static void ChecarPresencaNaFibonacci()
        {

            Console.WriteLine("2) Verificar presença na de um número na sequência Fibonacci: ");
            Console.WriteLine();
            Console.WriteLine("   Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores");
            Console.WriteLine("  anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,");
            Console.WriteLine("  informado um número, ele calcule a sequência de Fibonacci");
            Console.WriteLine("  e retorne uma mensagem avisando se o número informado pertence ou não a sequência.");
            Console.WriteLine();
            Console.WriteLine("   IMPORTANTE:");
            Console.WriteLine();
            Console.WriteLine("   Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;");
            Console.WriteLine();
            Console.Write("   Digite o número a ser verificado: ");


            int num1 = 0, num2 = 1, input = 0, aux;
            bool pertence = false;

            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i​​​​​​​ <= input; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;



                if (aux == input)
                {
                    pertence = true;
                }
            }


            if (pertence)
            {
                Console.WriteLine($"   Resposta: o número {input} pertence a fibonacci!");
            }
            else
            {
                Console.WriteLine($"   Resposta: o número {input} não pertence a fibonacci!");
            }

            Console.ReadKey();
        }
    
    
        static void VerificarPercentualNoFaturamento()
        {
            Console.WriteLine("4) Verificar percentual de participação no faturamento:");
            Console.WriteLine();
            Console.WriteLine("   Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:");

            Console.WriteLine();
            Console.WriteLine("   Estado   -   Participação em reais no faturamento");
            Console.WriteLine();
            Console.WriteLine("     SP     –                R$ 67.836,43");
            Console.WriteLine("     RJ     –                R$ 36.678,66");
            Console.WriteLine("     MG     –                R$ 29.229,88");
            Console.WriteLine("     ES     –                R$ 27.165,48");
            Console.WriteLine("     Outros –                R$ 19.849,53");
            Console.WriteLine();
            Console.WriteLine("   Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve");
            Console.WriteLine("  dentro do valor total mensal da distribuidora.");


            decimal SP = 67836.43M;
            decimal RJ = 36678.66M;
            decimal MG = 29229.88M;
            decimal ES = 27165.48M;
            decimal Outros = 19849.53M;

            decimal Total = SP + RJ + MG + ES + Outros;

            decimal PercentualSP = SP / Total * 100;
            decimal PercentualRJ = RJ / Total * 100;
            decimal PercentualMG = MG / Total * 100;
            decimal PercentualES = ES / Total * 100;
            decimal PercentualOutros = Outros / Total * 100;

            Console.WriteLine();
            Console.WriteLine("   Estado    -   Participação percentual no faturamento");
            Console.WriteLine();
            Console.WriteLine($"     SP      –                  {PercentualSP.ToString("F2")}%");
            Console.WriteLine($"     RJ      –                  {PercentualRJ.ToString("F2")}%");
            Console.WriteLine($"     MG      –                  {PercentualMG.ToString("F2")}%");
            Console.WriteLine($"     ES      –                  {PercentualES.ToString("F2")}%");
            Console.WriteLine($"     Outros  –                  {PercentualOutros.ToString("F2")}%");

            Console.ReadKey();
        }

        static void InverterString()
        {

            Console.WriteLine("5) Inverter uma string");
            Console.WriteLine();
            Console.WriteLine("   Escreva um programa que inverta os caracteres de um string.");
            Console.WriteLine();
            Console.WriteLine("   IMPORTANTE:");
            Console.WriteLine();
            Console.WriteLine("  a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;");
            Console.WriteLine();
            Console.WriteLine("  b) Evite usar funções prontas, como, por exemplo, reverse;");
            Console.WriteLine();


            
            

            Console.Write("    Escreva a palavra a ser invertida: ");
            string input = Console.ReadLine();

            char[] auxiliarDeOutput;
            string outputDefinitivo = "";
            if(input != null)
            {
                auxiliarDeOutput = new char[input.Length];
                for(int i = 0; i < input.Length; i++)
                {
                    auxiliarDeOutput[i] = input[i];
                }
                input = "";

                for(int i = auxiliarDeOutput.Length; i > 0; i --)
                {
                    outputDefinitivo += auxiliarDeOutput[i - 1];
                }
            }

            Console.WriteLine($"    Resposta: {outputDefinitivo}");
            Console.ReadKey();

        }

    }
}