namespace Livraria.Model;
class Usuario
{
    public Usuario(string nome,  string senha)
    {
        Nome = nome;
        Senha = senha;

    }

    public string Nome { get; }
    public string Senha { get; }

    public List<Livro> ListaLivrosEmprestados { get; set;}

    public bool userCadastrado = false;

    //Função para emprestar um livro
    public void EmprestaLivro(Livro livro)
    {
        //Se o usuário não estiver cadastrado em alguma biblioteca ele não consegue emprestar livro (use ! no lugar de == false)
        if (!userCadastrado)
        {
            Console.WriteLine($"Você não pode realizar emprestimo de livro enquanto não se cadastrar em alguma biblioteca");
        }
        //Se o livro não estiver cadastrado na biblioteca não consegue emprestar
        else if (!livro.livroCadastrado)
        {
            Console.WriteLine("Você não pode emprestar esse livro por que ele não está cadastrado em uma biblioteca");
        }
        //Se o livro já estiver na lista de emprestado não tem como emprestar novamente
        else if (ListaLivrosEmprestados.Contains(livro))
        {
            Console.WriteLine("Esse livro já está na sua lista de livro emprestados");
        }
        //Se o livro já está emprestado não consegue emprestar
        else if (livro.emprestado)
        {
            Console.WriteLine("Esse Livro já está emprestado");
        }
        //Se a listaLivroEmprestados for mais que 3 não consegue emprestar mais
        else if (ListaLivrosEmprestados.Count >= 3) 
        {
            Console.WriteLine("Você atingiu o limite de livro emprestados (3). Para conseguir emprestar outro livro devolva algum dos livros emprestados");
        }
        //Se passar das condições acima, permite o emprestimo do livro
        else
        {
            ListaLivrosEmprestados.Add(livro);
        }
    }

    public void DevolveLivro(Livro livro)
    {
        //Se o usuário não estiver cadastrado em alguma biblioteca ele não consegue emprestar livro (use ! no lugar de == false)
        if (!userCadastrado)
        {
            Console.WriteLine($"Você não pode realizar devolução de livro enquanto não se cadastrar em alguma biblioteca");
        }
        //Se o livro não estiver cadastrado na biblioteca não consegue emprestar
        
        //Se passar das condições acima, permite o emprestimo do livro
        else
        {
            livro.emprestado = false;
            ListaLivrosEmprestados.Remove(livro);
        }
    }

    //Exibindo os livros emprestados
    void ExibeLivrosEmprestado()
    {
        Console.WriteLine("Segue os livros emprestados");
        foreach(var livro in ListaLivrosEmprestados)
        {
            Console.WriteLine($"Livro : {livro.Titulo}\n");
        }
    }




}