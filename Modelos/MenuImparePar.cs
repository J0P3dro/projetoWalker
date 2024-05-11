using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWalker.Modelos
{
    internal class MenuImparePar: Menu
    {

        public void Executar(DadosLogin dadosLogin)
        {
            Console.Clear();
            ExibirTítulos("Jogo do impar ou par!");
            Console.WriteLine("Bem-vindos ao jogo do ímpar ou par");
            Random random = new Random();
            Console.Write("Escolha ímpar (I) ou par (P): ");
            string escolha = Console.ReadLine().ToUpper();
            Console.WriteLine("Escolha um número: ");
            string number = Console.ReadLine();
            int numberjogador = int.Parse(number);
            if (escolha != "I" && escolha != "P")
                if (!int.TryParse(Console.ReadLine(), out numberjogador) || numberjogador < 1 || numberjogador > 10)
                {
                    Console.WriteLine("Número inválido! Digite um número válido entre 1 e 10.");
                }

            int numeroComputador = random.Next(1, 11);

            Console.WriteLine($"Número do computador: {numeroComputador}");

            int soma = numberjogador + numeroComputador;
            bool resultado = soma % 2 == 0;
            Console.Write($"Você escolheu {numberjogador} e o computador escolheu {numeroComputador} a soma disso dá {soma}.\n");

            if ((escolha == "P" && resultado) || (escolha == "I" && !resultado))
            {
                Console.WriteLine("Parabéns! Você venceu!");
            }
            else
            {
                Console.WriteLine("Você perdeu! Tente novamente.");
            }
            Console.WriteLine("Aperta 1  para voltar ao menu de jogos ou aperte 2 para jogar novamente");
            string voltar = Console.ReadLine();
            int voltarnumber = int.Parse(voltar);
            if (voltarnumber == 1)
            {
                Console.Clear();
                MenuJogos menujg = new MenuJogos();
                menujg.Executar(dadosLogin);
            }
            if (voltarnumber == 2)
            {
                Console.Clear();
                MenuImparePar menu = new MenuImparePar();
                menu.Executar(dadosLogin);
            }

        }

    }
}
