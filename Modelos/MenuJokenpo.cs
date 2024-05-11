using System;

namespace ProjetoWalker.Modelos
{
    internal class MenuJokenpo : Menu
    {
        public void Executar(DadosLogin dadosLogin)
        { 

            while (true)
            {
                Console.Clear();
                ExibirTítulos("JOKENPO");
                Console.WriteLine("Bem-vindo ao Jokenpô!");
                int escolhaOpcao = ObterEscolhaDoJogador();

                if (escolhaOpcao == 0)
                {
                    Console.WriteLine("Obrigado por jogar. Até a próxima!");
                    Console.Clear();
                    MenuJogos menuJogos = new MenuJogos();
                    menuJogos.Executar(dadosLogin);
                    break;
                }

                if (escolhaOpcao < 1 || escolhaOpcao > 3)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                int escolhaMaquina = ObterEscolhaMaquina();

                Console.WriteLine($"\nJogador escolheu: {ObterOpcaoJokenpo(escolhaOpcao)}");
                Console.WriteLine($"Computador escolheu: {ObterOpcaoJokenpo(escolhaMaquina)}");

                int resultado = CompararEscolhas(escolhaOpcao, escolhaMaquina);

                if (resultado == 0)
                {
                    Console.WriteLine("Empate!");
                }
                else if (resultado == 1)
                {
                    Console.WriteLine("Você venceu!");
                }
                else
                {
                    Console.WriteLine("Computador venceu!");
                }

                if (!DesejaContinuar())
                {
                    Console.Clear();
                    MenuJogos menuJogos = new MenuJogos();
                    menuJogos.Executar(dadosLogin);
                    break;
                }
            }
        }

        static int ObterEscolhaDoJogador()
        {
            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("1 - \u001b[32mPedra\u001b[m");
            Console.WriteLine("2 - \u001b[33mPapel\u001b[m");
            Console.WriteLine("3 - \u001b[31mTesoura\u001b[m");
            Console.WriteLine("0 - Sair");
            string escolha = Console.ReadLine();
            return int.Parse(escolha);
        }

        static int ObterEscolhaMaquina()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        static string ObterOpcaoJokenpo(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    return "Pedra";
                case 2:
                    return "Papel";
                case 3:
                    return "Tesoura";
                default:
                    return "Opção inválida";
            }
        }

        static int CompararEscolhas(int escolhaJogador, int escolhaComputador)
        {
            Thread.Sleep(500);
            if (escolhaJogador == escolhaComputador)
            {
                return 0; // Empate
            }
            else if ((escolhaJogador == 1 && escolhaComputador == 3) ||
                     (escolhaJogador == 2 && escolhaComputador == 1) ||
                     (escolhaJogador == 3 && escolhaComputador == 2))
            {
                return 1; // Jogador vence
            }
            else
            {
                return -1; // Computador vence
            }
        }

        static bool DesejaContinuar()
        {
            Console.WriteLine("Aperte 1 para voltar ao menu de jogos ou aperte 2 para jogar novamente");
            string voltar = Console.ReadLine();
            int voltarNumber = int.Parse(voltar);
            Console.Clear();
            return voltarNumber == 2;
        }

    }
}
