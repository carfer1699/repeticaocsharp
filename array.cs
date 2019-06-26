using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (string rep = "s"; rep == "s";)
            {               

                Console.Clear();
                Console.WriteLine("Qual seção do código gostaria de analisar?\n");
                Console.WriteLine("Digite 1 para a primeira seção, 2 para a segunda, 3 para a terceira e 4 para a quarta");
                int que = int.Parse(Console.ReadLine());

                switch (que)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Informe um nome: ");
                        string nome1 = Console.ReadLine();

                        Console.WriteLine("Informe um nome: ");
                        string nome2 = Console.ReadLine();

                        Console.WriteLine("Informe um nome: ");
                        string nome3 = Console.ReadLine();

                        string[] nomes = new string[3] { nome1, nome2, nome3 };

                        Console.Clear();
                        Console.WriteLine("{0}, {1}, {2}\n", nomes[0], nomes[1], nomes[2]);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();

                        Console.WriteLine("Gostaria de analisar outra seção? 's' para sim e 'n para não'\n");
                        rep = Console.ReadLine();
                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Informe a altura: ");
                        double altura1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double altura2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double altura3 = double.Parse(Console.ReadLine());

                        double[] alturas = new double[3] { altura1, altura2, altura3 };

                        Console.Clear();
                        Console.WriteLine("{0}m, {1}m, {2}m", altura1.ToString("F2"), altura2.ToString("F2"), altura3.ToString("F2"));
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();

                        Console.WriteLine("Gostaria de analisar outra seção? 's' para sim e 'n para não'\n");
                        rep = Console.ReadLine();
                        break;
                    case 3:
                        //início da array de nomes

                        Console.Clear();
                        Console.WriteLine("Informe um nome: ");
                        string nomev1 = Console.ReadLine();

                        Console.WriteLine("Informe um nome: ");
                        string nomev2 = Console.ReadLine();

                        Console.WriteLine("Informe um nome: ");
                        string nomev3 = Console.ReadLine();

                        string[] nomesv = new string[3] { nomev1, nomev2, nomev3 };


                        //fim da array de nomes

                        //início da array de alturas

                        Console.WriteLine("Informe a altura: ");
                        double alturav1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double alturav2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double alturav3 = double.Parse(Console.ReadLine());

                        double[] alturasv = new double[3] { alturav1, alturav2, alturav3 };

                        Console.WriteLine("{0} - {1}m, {2} - {3}m e {4} - {5}m", nomev1, alturav1.ToString("F2"), nomev2, alturav2.ToString("F2"), nomev3, alturav3.ToString("F2"));
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();

                        Console.WriteLine("Gostaria de analisar outra seção? 's' para sim e 'n para não'\n");
                        rep = Console.ReadLine();
                        //fim da mesma
                        break;
                    case 4:

                        Console.Clear();
                        Console.WriteLine("Para ir para subquestão 'a' digite 'a' ou para ir para a 'b' digite 'b' ou  5 digite 5 ou 6 digite 6 ");
                        string sub = Console.ReadLine();

                        if (sub == "a")
                        {
                            int[] valor = new int[10];

                            for (int i = 0; i < valor.Length; i++)
                            {
                                Console.WriteLine("Informe um valor: ");
                                valor[i] = Convert.ToInt32(Console.ReadLine());

                            }
                            for (int i = 0; i < valor.Length; i++)
                            {
                                Console.WriteLine("Posição {0} corresponde a {1}", i, valor[i]);                                
                            }
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            Console.WriteLine("Gostaria de analisar outra seção? 's' para sim e 'n para não'\n");
                            rep = Console.ReadLine();
                            break;

                        }
                        else if (sub == "b")
                        {
                            int[] valor = new int[10];

                            for (int i = 0; i < valor.Length; i++)
                            {
                                Console.WriteLine("Informe um valor: ");
                                valor[i] = Convert.ToInt32(Console.ReadLine());

                            }
                            for (int i = 0; i < valor.Length; i++)
                            {
                                Console.WriteLine("Posição {0} corresponde a {1}", i, valor[i]);                                
                            }

                            Console.WriteLine("Informe um nome: ");
                            int pessoa = int.Parse(Console.ReadLine());

                            for (int loop = 0; loop < valor.Length; loop++)
                            {
                                if (valor[loop] == pessoa)
                                {
                                    Console.WriteLine(alturav2[loop]);
                                }
                            }
                            

                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            Console.WriteLine("Gostaria de analisar outra seção? 's' para sim e 'n para não'\n");
                            rep = Console.ReadLine();

                            break;                        
                        }                       
                        break;               
                  
                }
            }
            Console.Clear();
            Console.WriteLine("Pressione qualquer tecla para encerrar a seção...");
            Console.ReadKey();
        }        
    }
}
