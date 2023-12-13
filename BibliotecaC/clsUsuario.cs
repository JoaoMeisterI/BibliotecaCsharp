//Usuário:

//Propriedades: Nome, ID do Usuário, Livros Emprestados.
//Métodos: Um método para verificar os livros atualmente emprestados, um método para emprestar um livro, um método para devolver um livro.

class Usuario
{
    public Usuario(string nome, int idUsuario, Biblioteca biblioteca)
    {
        try
        {
            Nome = nome;
            IdUsuario = idUsuario;
            Biblioteca1 = biblioteca;
        }
        catch
        {
            Console.WriteLine("Favor Revise os valores adicionados");
        }


    }

    Biblioteca Biblioteca1 { get; }
    public string Nome { get; }
    public int IdUsuario { get;}
 
    List<Livro> listaLivros = new List<Livro>();


    public void emprestaLivro(Livro livro,Usuario user)
    {

        if (!Biblioteca1.ListaUsuarios.Contains(user))
        {
            Console.WriteLine("Usuário não pode emprestar livro por que não está cadastrado na biblioteca");
        }
        else if (listaLivros.Count >= 3)
        {
            
            Console.WriteLine("O máximo de livros que pode emprestar é 3 livros, emprestimo negado\n");
            
        }
        else if(listaLivros.Contains(livro))
        {
            Console.WriteLine("Está livro já foi emprestado por você\n");
        }
        else if(livro.emprestado == true)
        {
            Console.WriteLine("Esse livro já foi emprestado por outra pessoa\n");
        }
        else
        {
            try
            {
                listaLivros.Add(livro);
                livro.emprestado = true;
                Console.WriteLine(listaLivros.Count);

            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possivel emprestar o livro da lista de livros");
                throw;
            }
        }

        
       
    }


    public void DevolveLivro(Livro livro)
    {

        if (!listaLivros.Contains((livro)))
        {
            Console.WriteLine("Livro não encontrado, ou ele não existe ou já foi devolvido");
        }
        else
        {
            try
            {
                listaLivros.Remove(livro);
                livro.emprestado = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Livro já foi devolvido");
                throw;
            }
        }
      

        



    }

    public void MostraLivrosEmprestados()
    {


        try
        {
            Console.WriteLine("Segue os livros que estão emprestados: \n");
            foreach(var livro in listaLivros )
            {
                Console.WriteLine($"Livro: {livro.Titulo}\n");
                
                
               
            }
        }
        catch (Exception)
        {

        }
    }

    //Criar uma lista para livros emprestados e uma para livros devolvidos 


}

