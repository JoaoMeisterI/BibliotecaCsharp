Livro livro1 = new Livro("A Máquina do Tempo", "H.G. Wells", 1895, 120, "978-0141439976");
Livro livro2 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 1178, "978-0545010221");
Livro livro3 = new Livro("1984", "George Orwell", 1949, 328, "978-0451524935");
Livro livro4 = new Livro("teste", "George Orwell", 1949, 328, "978-0451524935");



Biblioteca EraDoConhecimento = new Biblioteca("Biblioteca Era do Conhecimento");


EraDoConhecimento.AdicionaLivroBiblioteca(livro1);
EraDoConhecimento.AdicionaLivroBiblioteca(livro2);
EraDoConhecimento.AdicionaLivroBiblioteca(livro3);
EraDoConhecimento.AdicionaLivroBiblioteca(livro4);




Usuario user1 = new("João", 1,EraDoConhecimento);
Usuario user2 = new("Neslon", 2, EraDoConhecimento);

EraDoConhecimento.AdicionaUsuario(user1);


user1.emprestaLivro(livro1,user2);















