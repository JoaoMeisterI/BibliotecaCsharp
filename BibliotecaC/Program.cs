using Livraria.Model;

//Lista aonde ficaram as bibliotecas
Dictionary<string, Biblioteca> ListaBibliotecas = new Dictionary<string, Biblioteca>();

//Criando Bibliotecas

Biblioteca Saraiva = new Biblioteca("Saraiva");
//-------------------------------------------------------------------------
Biblioteca NuvemLivros = new Biblioteca("Nuvem Livros");
//-------------------------------------------------------------------------
Biblioteca LivrariaEnciclopedia = new Biblioteca("Livraria Enciclopedia");
//-------------------------------------------------------------------------

// Criando Livros 

Livro livro1 = new Livro("Abelha nas flores", "Celso russomano", 150);
Livro livro2 = new Livro("Aventuras na Ilha Misteriosa", "Laura Lima", 200);
Livro livro3 = new Livro("Caminhos do Destino", "Carlos Costa", 250);
Livro livro4 = new Livro("Estrelas da Noite", "Mariana Mendes", 300);
Livro livro5 = new Livro("O Jardim Secreto", "Rafael Rocha", 180);
Livro livro6 = new Livro("O Mistério do Lago", "Isabela Inácio", 400);
Livro livro7 = new Livro("Cidade das Sombras", "Fernando Fernandes", 150);
Livro livro8 = new Livro("A Última Fronteira", "Gabriela Gomes", 280);
Livro livro9 = new Livro("O Pássaro Dourado", "Eduardo Esteves", 350);
//----------------------------------------------------------------------------

//Adicionando os livros na biblioteca
Saraiva.CadastraLivro(livro1);
Saraiva.CadastraLivro(livro2);
Saraiva.CadastraLivro(livro3);
NuvemLivros.CadastraLivro(livro4);
NuvemLivros.CadastraLivro(livro5);
NuvemLivros.CadastraLivro(livro6);
LivrariaEnciclopedia.CadastraLivro(livro7);
LivrariaEnciclopedia.CadastraLivro(livro8);
LivrariaEnciclopedia.CadastraLivro(livro9);
//-----------------------------------------------------------------

//Adicionando as bibliotecas ao dicionário de bibliotecas

ListaBibliotecas.Add("Saraiva", Saraiva);
ListaBibliotecas.Add("Nuvem Livros", NuvemLivros);
ListaBibliotecas.Add("Livraria Enciclopedia", LivrariaEnciclopedia);

//------------------------------------------------------------------
Console.Clear();
// 1 - Verificando em qual biblioteca o usuário quer entrar
Console.WriteLine("!!Bem vindo a Web Bibliotecas!!\n");

Console.WriteLine("Em qual biblioteca deseja entrar ?\n");
Console.WriteLine("Biblioteca: \n");

string resUser = Console.ReadLine();
Usuario usuario1 = new Usuario("joao", "123");
Saraiva.CadastraUsuario(usuario1);


// 2 - Entrando na biblioteca que o usuário digitou 

// Se a biblioteca existir na listaBibliotecas
if (ListaBibliotecas.ContainsKey(resUser))
{
    Biblioteca biblioteca = ListaBibliotecas[resUser];
    Console.WriteLine($"Bem vindo a {biblioteca.Nome}\n");
    Console.WriteLine();

    //Solicitando para o usuário colocar seu user e senha
    Console.WriteLine("Digite seu usuário e sua Senha");
    Console.WriteLine("Usuário: \n");
    string nome = Console.ReadLine();
    Console.WriteLine("Senha: \n");
    string senha = Console.ReadLine();
    Usuario usuario = new Usuario(nome, senha);
    bool res = biblioteca.ValidaUsuario(usuario);
    if (res == true)
    {
        Console.WriteLine($"Bem vindo {usuario.Nome}");
    }
    else
    {
        
    }

}
else
{
    Console.WriteLine("Biblioteca não existe");
}









