namespace Livraria.Model;
class Biblioteca
{

    public Biblioteca(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public List<Livro> LivrosCadastrados { get; set; }
    public List<Usuario> UsuariosCadastrados { get; set; }

    //Função para cadastrar usuário
    public void CadastraUsuario(Usuario usuario)
    {
        UsuariosCadastrados.Add(usuario);
    }

    //Função para adicionar Livro
    public void CadastraLivro(Livro livro)
    {
        LivrosCadastrados.Add(livro);
    }

}