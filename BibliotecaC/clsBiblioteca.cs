class Biblioteca
{

    public Biblioteca(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    List<Livro> LivrosBiblioteca = new List<Livro>();

    public List<Usuario> ListaUsuarios = new List<Usuario>();

    public void AdicionaLivroBiblioteca(Livro livro)
    {
       
        if (LivrosBiblioteca.Contains(livro))
        {
            Console.WriteLine("Está livro já foi cadastrado\n");
        }
        else
        {
            try
            {
                LivrosBiblioteca.Add(livro);

            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possivel cadastrar o livro na biblioteca");
                throw;
            }
        }



    }

    public void AdicionaUsuario(Usuario usuario)
    {

        if (ListaUsuarios.Contains(usuario))
        {
            Console.WriteLine("Este usuário já foi cadastrado\n");
        }
        else
        {
            try
            {
                ListaUsuarios.Add(usuario);

            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possivel cadastrar o livro na biblioteca");
                throw;
            }
        }



    }


    public void MostraLivrosDisponiveis()
    {

       
        try
        {
            Console.WriteLine("Segue os livros que estão disponíveis: \n");
            foreach (var livro in LivrosBiblioteca)
            {
                if(livro.emprestado == false)
                {
                    Console.WriteLine($"Livro: {livro.Titulo}");
                }



            }
        }
        catch (Exception)
        {
            Console.WriteLine("Erro ao mostrar os livros");
        }
    }

    public void MostraUsuarios()
    {


        try
        {
            Console.WriteLine("Segue os usuários cadastrados: \n");
            foreach (var user in ListaUsuarios)
            {
              
                 Console.WriteLine($"ID: {user.IdUsuario} / {user.Nome}\n ");
               



            }
        }
        catch (Exception)
        {
            Console.WriteLine("Erro ao mostrar os livros");
        }
    }



}