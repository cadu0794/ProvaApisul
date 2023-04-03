using ProvaApisul.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaApisul
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("1 - Qual é o andar menos utilizado pelos usuários");
                Console.WriteLine("2 - Qual é o elevador mais frequentado e o período que se encontra maior fluxo");
                Console.WriteLine("3 - Qual é o elevador menos frequentado e o período que se encontra menor fluxo");
                Console.WriteLine("4 - Qual o período de maior utilização do conjunto de elevadores");
                Console.WriteLine("5 - Qual o percentual de uso de cada elevador com relação a todos os serviços prestados;");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("");
                Console.WriteLine("Digite a opção do menu que gostaria de acessar:");

                ElevadorService ServicoElevador = new ElevadorService();
                String menu = Console.ReadLine();
                Console.Clear();
                
                switch (menu)
                {
                    case ("0"):
                        return;
                        break;

                    case ("1"):
                        List<int> listAndarMenosUtilizado = ServicoElevador.andarMenosUtilizado();
                        Console.Write("Andar(es) menos utilizado(s): ");
                        foreach (int andares in listAndarMenosUtilizado)
                        {
                            Console.Write(andares + " ");
                        }
                        Console.WriteLine();
                        break;

                    case ("2"):
                        List<char> listElevadorMaisFrequentadoFluxo = ServicoElevador.periodoMaiorFluxoElevadorMaisFrequentado();
                        Console.WriteLine("Lista de elevador(es) mais utilizados com o(s) perídos de maior fluxo:");
                        for (int i = 0; i < listElevadorMaisFrequentadoFluxo.Count(); i++)
                        {
                            if (i == 0)
                            {
                                Console.Write("Elevador: " + listElevadorMaisFrequentadoFluxo[i] + " | Período: ");
                                continue;
                            }
                            else if (listElevadorMaisFrequentadoFluxo[i - 1].Equals(','))
                            {
                                Console.Write("Elevador: " + listElevadorMaisFrequentadoFluxo[i] + " | Período: ");
                                continue;
                            }
                            else if (!(listElevadorMaisFrequentadoFluxo[i].Equals(',')))
                            {
                                Console.Write(listElevadorMaisFrequentadoFluxo[i] + " ");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("");
                                continue;
                            }

                        }

                        break;

                    case ("3"):
                        List<char> listElevadorMenosFrequentadoFluxo = ServicoElevador.periodoMenorFluxoElevadorMenosFrequentado();
                        Console.WriteLine("Lista de elevador(es) menos utilizados com o(s) perídos de menor fluxo:");
                        for (int i = 0; i < listElevadorMenosFrequentadoFluxo.Count(); i++)
                        {
                            if (i == 0)
                            {
                                Console.Write("Elevador: " + listElevadorMenosFrequentadoFluxo[i] + " | Período: ");
                                continue;
                            }
                            else if (listElevadorMenosFrequentadoFluxo[i - 1].Equals(','))
                            {
                                Console.Write("Elevador: " + listElevadorMenosFrequentadoFluxo[i] + " | Período: ");
                                continue;
                            }
                            else if (!(listElevadorMenosFrequentadoFluxo[i].Equals(',')))
                            {
                                Console.Write(listElevadorMenosFrequentadoFluxo[i] + " ");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("");
                                continue;
                            }

                        }

                        break;

                    case ("4"):
                        List<char> listTurnoMaiorUtilizacao = ServicoElevador.periodoMaiorUtilizacaoConjuntoElevadores();
                        Console.Write("Turno(s) de maior utilização do conjunto de elevadores: ");
                        for (int i = 0; i < listTurnoMaiorUtilizacao.Count(); i++)
                        {
                            Console.Write(listTurnoMaiorUtilizacao[i] + " ");

                        }
                        break;

                    case ("5"):
                        float percentual = ServicoElevador.percentualDeUsoElevadorA();
                        Console.WriteLine("O percentual de uso do elevador A foi de " + percentual + "%");
                        percentual = ServicoElevador.percentualDeUsoElevadorB();
                        Console.WriteLine("O percentual de uso do elevador B foi de " + percentual + "%");
                        percentual = ServicoElevador.percentualDeUsoElevadorC();
                        Console.WriteLine("O percentual de uso do elevador C foi de " + percentual + "%");
                        percentual = ServicoElevador.percentualDeUsoElevadorD();
                        Console.WriteLine("O percentual de uso do elevador D foi de " + percentual + "%");
                        percentual = ServicoElevador.percentualDeUsoElevadorE();
                        Console.WriteLine("O percentual de uso do elevador E foi de " + percentual + "%");
                        break;

                    default: Console.WriteLine("Menu inválido, escolha novamente!"); break;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para voltar ao menu principal...");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
