namespace ProjetoWalker.Modelos
{
    internal class Menu
    {
        public void Executar()
        {
            
            string mensagem = "Olá, eu sou WALKER, seu assistente digital! Em que posso lhe ajudar hoje? ";
            Console.WriteLine(mensagem);
            Console.WriteLine(@"
░██╗░░░░░░░██╗░█████╗░██╗░░░░░██╗░░██╗███████╗██████╗░
░██║░░██╗░░██║██╔══██╗██║░░░░░██║░██╔╝██╔════╝██╔══██╗
░╚██╗████╗██╔╝███████║██║░░░░░█████═╝░█████╗░░██████╔╝
░░████╔═████║░██╔══██║██║░░░░░██╔═██╗░██╔══╝░░██╔══██╗
░░╚██╔╝░╚██╔╝░██║░░██║███████╗██║░╚██╗███████╗██║░░██║
░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝");
        }
    
    public void ExibirTítulos(string titulos)
        {
            int quantitade_letras = titulos.Length;
            string linha = string.Empty.PadLeft(quantitade_letras, '_');
            Console.WriteLine(linha);
            Console.WriteLine(titulos);
            Console.WriteLine(linha + "\n");
        }
    }

   


    
        internal class DadosLogin
        {
            public List<string> Logins { get; set; }
            public List<string> Senhas { get; set; }

            public DadosLogin()
            {
                Logins = new List<string> { "Jpag2602", /* outros logins */ };
                Senhas = new List<string> { "260205", /* outras senhas */ };
            }
        }
    }


