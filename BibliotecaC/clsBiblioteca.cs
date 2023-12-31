namespace Livraria.Model;
class Biblioteca
{

    public Biblioteca(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public List<Livro> LivrosCadastrados = new List<Livro>();
    public List<Usuario> UsuariosCadastrados = new List<Usuario>();

    //Função para cadastrar usuário
    public void CadastraUsuario(Usuario usuario)
    {
        if(UsuariosCadastrados.Contains(usuario))
        {
            Console.WriteLine("Usuário já cadastrado\n");
            
        }
        else
        {
            UsuariosCadastrados.Add(usuario);
            Console.WriteLine("Usuário cadastrado com sucesso\n");
            usuario.userCadastrado = true;
        }

      
    }

    //Função para validar se o usuário está cadastrado, caso não esteja pergunta se ele quer se cadastrar

    public bool ValidaUsuario(Usuario usuario)
    {
        
        
        if (UsuariosCadastrados.Contains(usuario))
        {
            Console.WriteLine("Usuário existente\n");
            return true;
        }
        else
        {
            Console.WriteLine("Usuário não cadastrado\n");
            Console.WriteLine();
            Console.WriteLine("Deseja se cadastrar ? (S/N) ");
            Console.WriteLine("Resposta: ");
            string resCadastro = Console.ReadLine().ToUpper();
            if (resCadastro[0] == 'S')
            {
                Console.WriteLine("Diga um nome de usuário: \n");
                Console.WriteLine("Usuário: \n");
                string nomeUser = Console.ReadLine();
                Console.WriteLine("Diga uma senha para seu usuário: \n");
                Console.WriteLine("Senha: \n");
                string SenhaUser = Console.ReadLine();

                try
                {
                    Usuario user = new Usuario(nomeUser, SenhaUser);
                    Console.WriteLine("Novo usuário cadastrado");
                    CadastraUsuario(user);
                    return true;

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocorreu o seguinte erro {e}");
                    return false;
                }
            }
            else if (resCadastro[0] == 'N')
            {
                Console.WriteLine("Saindo do site");
                return false;
            }
        }
        return false;
    }
     


    //Função para adicionar Livro
    public void CadastraLivro(Livro livro)
    {
        if (LivrosCadastrados.Contains(livro))
        {
            Console.WriteLine("Livro já cadastrado");
        }
        else
        {
            LivrosCadastrados.Add(livro);
            Console.WriteLine("Livro cadastrado com sucesso");
            livro.livroCadastrado = true;
        }
    }


    public void RemoveUsuario(Usuario usuario)
    {
        if(!UsuariosCadastrados.Contains(usuario))
        {
            Console.WriteLine("Usuário já removido");
        }
        else
        {
            UsuariosCadastrados.Remove(usuario);
            Console.WriteLine("Usuário removido com sucesso");
            usuario.userCadastrado = false;
        }

      
    }

    //Função para adicionar Livro
    public void RemoveLivro(Livro livro)
    {
        if (!LivrosCadastrados.Contains(livro))
        {
            Console.WriteLine("Livro já removido");
        }
        else
        {
            LivrosCadastrados.Add(livro);
            Console.WriteLine("Livro removido com sucesso");
            livro.livroCadastrado = false;
        }
    }




}