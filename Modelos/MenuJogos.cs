using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWalker.Modelos
{
    internal class MenuJogos: Menu
    {
        public void Executar(DadosLogin dadosLogin)
        {
            Console.WriteLine("Digite qual o jogo que você deseja jogar: \n");
            Console.WriteLine("1 - Jogo de Advinhação");
            Console.WriteLine("2 - Jokenpo");
            Console.WriteLine("3 - Impar ou par");
            Console.WriteLine("0 - Sair");
            string escolha = Console.ReadLine();
            int escolhanumber = int.Parse(escolha);
            switch (escolhanumber)
            {
                case 0:
                    Console.WriteLine("Ok! Direcionando para o menu.");
                    Thread.Sleep(3500);
                    Console.Clear();
                    MenuOpcoes menuop = new MenuOpcoes();
                    menuop.Executar(dadosLogin);
                    break;
                case 1:
                    MenuJogoAdivinhar menuja = new MenuJogoAdivinhar();
                    menuja.Executar(dadosLogin);
                    break;
                case 2:
                    MenuJokenpo menujo = new MenuJokenpo();
                    menujo.Executar(dadosLogin);
                    break;
                case 3:
                    MenuImparePar menuip = new MenuImparePar();
                    menuip.Executar(dadosLogin);
                    break;
            }
            



        }
    }
}
