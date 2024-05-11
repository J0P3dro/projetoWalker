namespace ProjetoWalker.Modelos
{
    internal class MenuOpcoes : Menu
    {
        public void Executar(DadosLogin dadosLogin)
        {
            Menu menu = new Menu();
            menu.Executar();
            Console.WriteLine("\n 1 - Cadastro.");
            Console.WriteLine("\n 2 - Login.");
            Console.WriteLine("\n 3 - Sair.");
            Console.Write("Digite a opção: ");

            string opcao = Console.ReadLine();
            int opcaonumber = int.Parse(opcao);
            switch (opcaonumber)
            {
                case 1:
                    MenuCadastro menucd = new MenuCadastro();
                    menucd.Executar(dadosLogin);  // Passa a instância de DadosLogin
                    break;
                case 2:
                    MenuLogin menulg = new MenuLogin();
                    menulg.Executar(dadosLogin);  // Passa a instância de DadosLogin
                    break;
                case 3:
                    Console.WriteLine("Tudo bem, volte quando quiser!");
                    break;
            }
            Console.Clear();
            DadosLogin dadosLogin1 = new DadosLogin();
            

        }
    }
}
