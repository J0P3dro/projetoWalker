using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWalker.Modelos
{
    internal class MenuJogoAdivinhar: Menu
    {
        public void Executar(DadosLogin dadosLogin)
        {
            Console.Clear();
            ExibirTítulos("Jogo de Adivinhação!");
            Console.WriteLine("Bem-vindo ao jogo da adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 0 e 10.");
            Random random = new Random();
            int number = random.Next(0, 10);
            int palpites;
            int tentativas = 0;
            while (true)
            {
                Console.Write("Digite o seu palpite: ");
                palpites = int.Parse(Console.ReadLine());
                tentativas++;
                if (palpites == number)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                    Console.WriteLine($"Com um número de {tentativas}");
                    Console.WriteLine("Aperta 1  para voltar ao menu de jogos ou aperte 2 para jogar novamente");
                    string voltar = Console.ReadLine();
                    int voltarnumber = int.Parse(voltar);
                    if (voltarnumber == 1)
                    {
                        Console.Clear();
                        MenuJogos menu = new MenuJogos();
                        menu.Executar(dadosLogin);
                    }
                    if (voltarnumber == 2)
                    {
                        Console.Clear();
                        MenuJogoAdivinhar menuja = new MenuJogoAdivinhar();
                        menuja.Executar(dadosLogin);
                    }

                }
                else
                {
                    if (palpites < number)
                    {
                        Console.WriteLine("Um pouco \u001b[31m maior\u001b[m.");
                    }
                    else
                    {
                        Console.WriteLine("Um pouco \u001b[32m menor\u001b[m.");
                    }
                    Console.WriteLine("Palpite incorreto, tente novamente ...");
                }
            }
        }
    }
}
