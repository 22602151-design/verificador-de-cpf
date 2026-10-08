namespace verificador_de_cpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf, regiao;
            int nonoDigito = 0;
            int tentativas = 0;

            while (true)
            {
                Console.WriteLine("--------------------------");
                Console.Write("Digite o CPF: ");
                cpf = Console.ReadLine();

                int i = 0;
                int soma = 0;
                int resto;

                while (i < 9)
                {
                    soma += (cpf[i] - '0') * (10 - i);
                    i++;
                }

                resto = (soma * 10) % 11;
                if (resto == 10) resto = 0;

                if (resto != (cpf[9] - '0'))
                {
                    Console.WriteLine("CPF inválido");
                    tentativas++;
                    continue;
                }


                i = 0;
                soma = 0;

                while (i < 10)
                {
                    soma += (cpf[i] - '0') * (11 - i);
                    i++;
                }

                resto = (soma * 10) % 11;
                if (resto == 10) resto = 0;

                if (resto != (cpf[10] - '0'))
                {
                    Console.WriteLine("CPF inválido");
                    tentativas++;
                    continue;
                }
                else
                {
                    Console.WriteLine("CPF válido");
                }

                int regiaoFiscal = cpf[8] - '0';

                Console.Write($"Região Fiscal {regiaoFiscal}: ");

                switch (regiaoFiscal)
                {
                    case 1: Console.WriteLine("DF, GO, MS, MT e TO"); break;
                    case 2: Console.WriteLine("AC, AM, AP, PA, RO e RR"); break;
                    case 3: Console.WriteLine("CE, MA e PI"); break;
                    case 4: Console.WriteLine("AL, PB, PE e RN"); break;
                    case 5: Console.WriteLine("BA e SE"); break;
                    case 6: Console.WriteLine("MG"); break;
                    case 7: Console.WriteLine("ES e RJ"); break;
                    case 8: Console.WriteLine("SP"); break;
                    case 9: Console.WriteLine("PR e SC"); break;
                    case 0: Console.WriteLine("RS"); break;
                    default: Console.WriteLine("CPF INVÁLIDO"); break;
                }
            }
            tentativas++;

            Console.ReadKey();
        }
    }
}
