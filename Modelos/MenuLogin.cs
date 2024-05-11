namespace ProjetoWalker.Modelos
{
    internal class MenuLogin : Menu
    {
        
        public void Executar(DadosLogin dadosLogin)
        {
            

            Console.Clear();
            ExibirTítulos("Acesso ao sistema!");
            Console.WriteLine("Digite o seu login: ");
            string usuario = Console.ReadLine();

            if (dadosLogin.Logins.Contains(usuario))
            {
                Console.WriteLine("");
                Console.WriteLine("Digite a sua senha: ");
                string senhas = Console.ReadLine();
                if (dadosLogin.Senhas.Contains(senhas))
                {
                    Console.WriteLine("");
                    Console.Clear();
                    MenuJogos menu = new MenuJogos();
                    menu.Executar(dadosLogin);
                }
                else
                {
                    Console.WriteLine("Desculpe, é preciso que faça o seu cadastro antes de entrar!");
                    Console.ReadKey();
                    Console.Clear();
                    MenuOpcoes menuOpcoes = new MenuOpcoes();
                    menuOpcoes.Executar(dadosLogin);

                }
            }
            else
            {
                Console.WriteLine("Desculpe, é preciso que faça o seu cadastro antes de entrar!");
                Thread.Sleep(3000);
                Console.Clear();
                MenuOpcoes menuOpcoes = new MenuOpcoes();
                menuOpcoes.Executar(dadosLogin);
            }
            
            Console.WriteLine("Certo! Acesso liberado, o que deseja fazer hoje? ");
            
            Console.Clear();
            
        }

    }
}
