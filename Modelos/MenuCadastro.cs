namespace ProjetoWalker.Modelos
{

    internal class MenuCadastro : Menu
    {
        public void Executar(DadosLogin dadosLogin)
        {
            Console.Clear();
            ExibirTítulos("Cadastro de Usuários");

            Console.WriteLine("Digite o seu login: ");
            string usuario = Console.ReadLine();
            dadosLogin.Logins.Add(usuario);

            Console.WriteLine("Digite a sua senha: ");
            string senha = Console.ReadLine();
            dadosLogin.Senhas.Add(senha);

            Console.WriteLine("Login e senha cadastrados com sucesso!");
            Thread.Sleep(3000);
            Console.Clear();
            
            MenuOpcoes menuOpcoes = new MenuOpcoes();
            menuOpcoes.Executar(dadosLogin);

        }
    }
}
