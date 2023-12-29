namespace Livraria.Model;
class Livro
{
    public Livro(string titulo, string autor, int codigo)
    {
        try
        {
            Titulo = titulo;
            Autor = autor;
            Codigo = codigo;
       
        }
        catch
        {
            Console.WriteLine("Favor Revise os valores adicionados");
        }


    }

    public string Titulo { get;  }
    public string Autor { get;  }
    public int Codigo { get;  }

    public bool emprestado = false;

    public bool livroCadastrado = false;


    public void ExibeInfoLivro()
    {
        try
        {
            Console.WriteLine("----------------------\n");
            Console.WriteLine($"Título: {Titulo}\n");
            Console.WriteLine($"Autor: {Autor}\n");
            Console.WriteLine($"Ano de Publicação: {Codigo}\n");
            Console.WriteLine("----------------------\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Algo ocorreu errado, verifique as informações disponibilizadas");
        }
       

    }

}

