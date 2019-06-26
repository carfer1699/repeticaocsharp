using System;

namespace estrutura_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            string rep = "s", qu = "para a";
            
            while (rep == "s")
            {
                Console.WriteLine("Tecle 1 para verificar a primeira questão, 2 {0} segunda, 3 {0} terceira, 4 {0} quarta, 5 {0} quinta, 6 {0} sexta e 7 {0} sétima.", qu);
                int con = int.Parse(Console.ReadLine());

                //Primeira questão
                if (con == 1)
                {
                    Console.WriteLine("Informe um valor inteiro: ");
                    int valor = int.Parse(Console.ReadLine());

                    if (valor >= 1 && valor <= 1000)
                    {
                        for (int n = 1; n <= valor; n++)
                        {
                            bool impar = n % 2 != 0;

                            if (impar)
                            {
                                Console.WriteLine("{0} é ímpar", n);
                            }
                        }
                    }
                }

                //Segunda questão
                if (con == 2)
                {
                    Console.WriteLine("Infome a quantidade de casos a ser testado: ");
                    int nc = int.Parse(Console.ReadLine());

                    for (; nc != 0; nc--)
                    {
                        Console.WriteLine("Informe o primeiro valor: ");
                        double valor01 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o segundo valor: ");
                        double valor02 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o terceiro valor: ");
                        double valor03 = double.Parse(Console.ReadLine());

                        double mp = ((valor01 * 2) + (valor02 * 3) + (valor03 * 5)) / (2 + 3 + 5);

                        Console.WriteLine("Média Ponderada = {0}", mp.ToString("F1"));
                    }
                }

                //Terceira questão
                if (con == 3)
                {
                    Console.WriteLine("Informe um valor: ");
                    int fat = int.Parse(Console.ReadLine());

                    int bfat = fat;

                    for (int cont = fat - 1; cont > 1; cont--)
                    {
                        if (cont != 0)
                        {
                            bfat *= cont;                            
                        }                        
                    }
                    Console.WriteLine("fatorial = {0}", bfat);

                    if (fat == 0)
                    {
                        Console.WriteLine("fatorial = {0}", fat);
                    }
                }

                //Quarta questão
                if (con == 4)
                {
                    Console.WriteLine("Informe um número: ");
                    int num = int.Parse(Console.ReadLine());

                    int bnum = num;

                    for (; num > 1; num--)
                    {
                        if (bnum % num == 0)
                        {
                            Console.WriteLine(num);
                        }
                    }
                }

                //Quinta questão
                if (con == 5)
                {
                    Console.WriteLine("Informe um valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    for (int cont = 1; cont <= valor; cont++)
                    {
                        int quad = cont * cont;
                        int cub = cont * cont * cont;
                        Console.WriteLine("{0} {1} {2}", cont, quad, cub);
                    }
                }

                //Sexta questão
                if (con == 6)
                {
                    Console.WriteLine("Digite a senha: ");
                    int senha = int.Parse(Console.ReadLine());

                    while (senha != 2002)
                    {
                        Console.WriteLine("Senha Inválida.");
                        senha = int.Parse(Console.ReadLine());
                    }
                    while (senha == 2002 || senha == 2002)
                    {
                        Console.WriteLine("Acesso Permitido.");

                        senha++;
                    }
                }

                //Sétima questão
                if (con == 7)
                {
                    int alcool = 0, gasolina = 0, diesel = 0;
                    Console.WriteLine(
                        "informe o tipo de combustível abastecido: tecle 1 para Álcool, 2 para Gasolina, 3 para Diesel e 4 para finalizar");
                    int escolha = int.Parse(Console.ReadLine());


                    while (escolha >= 1 && escolha <= 3)
                    {
                        while (escolha == 4)
                        {
                            Console.WriteLine("MUITO OBRIGADOR");

                            Console.WriteLine("Gostaria de analisar outra questão, 's' para sim e 'n' para não");
                            rep = Console.ReadLine();
                        }

                        while (escolha == 1)
                        {
                            alcool += 1;

                            Console.WriteLine("Álcool: {0}", alcool);
                            Console.WriteLine("Gasolina: {0}", gasolina);
                            Console.WriteLine("Diesel: {0}", diesel);

                            Console.WriteLine("informe o tipo de combustível abastecido: tecle 1 para Álcool, 2 para Gasolina, 3 para Diesel e 4 para finalizar");
                            escolha = int.Parse(Console.ReadLine());
                        }

                        while (escolha == 2)
                        {
                            gasolina += 1;

                            Console.WriteLine("Álcool: {0}", alcool);
                            Console.WriteLine("Gasolina: {0}", gasolina);
                            Console.WriteLine("Diesel: {0}", diesel);

                            Console.WriteLine("informe o tipo de combustível abastecido: tecle 1 para Álcool, 2 para Gasolina, 3 para Diesel e 4 para finalizar");
                            escolha = int.Parse(Console.ReadLine());
                        }

                        while (escolha == 3)
                        {
                            diesel += 1;

                            Console.WriteLine("Álcool: {0}", alcool);
                            Console.WriteLine("Gasolina: {0}", gasolina);
                            Console.WriteLine("Diesel: {0}", diesel);

                            Console.WriteLine("informe o tipo de combustível abastecido: tecle 1 para Álcool, 2 para Gasolina, 3 para Diesel e 4 para finalizar");
                            escolha = int.Parse(Console.ReadLine());
                        }
                    }
                }

                Console.WriteLine("Gostaria de analisar outra questão, 's' para sim e 'n' para não");
                rep = Console.ReadLine();
            }
        }
    }
}