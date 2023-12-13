//Livro:

//Propriedades: Título, Autor, Ano de Publicação, Número de Páginas, ISBN.
//Métodos: Um método para exibir as informações do livro.


// Quando tem uma variável da seguinte forma _variavel (Isso significa que ela não deve ser acessado de outra classe-)
//value (no set) é uma palavra chave que diz respeito ao valor atribuito a propriedade
class Livro
{
    public Livro(string titulo, string autor, int anoPubli, int numeroPag, string isbn)
    {
        try
        {
            Titulo = titulo;
            Autor = autor;
            AnoPubli = anoPubli;
            NumeroPag = numeroPag;
            Isbn = isbn;
        }
        catch
        {
            Console.WriteLine("Favor Revise os valores adicionados");
        }


    }

    public string Titulo { get;  }
    public string Autor { get;  }
    public int AnoPubli { get;  }
    public int NumeroPag { get; }
    public string Isbn { get; }
    public bool emprestado { get; set; }

    public void ExibeInfoLivro()
    {
        try
        {
            Console.WriteLine("----------------------\n");
            Console.WriteLine($"Título: {Titulo}\n");
            Console.WriteLine($"Autor: {Autor}\n");
            Console.WriteLine($"Ano de Publicação: {AnoPubli}\n");
            Console.WriteLine($"Número de Páginas: {NumeroPag}\n");
            Console.WriteLine($"ISBN: {Isbn}\n");
            Console.WriteLine("----------------------\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Algo ocorreu errado, verifique as informações disponibilizadas");
        }
       

    }

}

