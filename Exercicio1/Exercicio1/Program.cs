using Exercicio1;

Livro livro1 = new Livro("A Rainha Vermelha", "Victoria Aveyard", "Grupo Editorial Record", 2015);
Console.WriteLine("O nome do primeiro livro em sua lista é: " + livro1.Titulo);
Console.WriteLine("O nome da autora é: " + livro1.Autor);
Console.WriteLine("o nome da editora é: " + livro1.Editora);
Console.WriteLine("O ano de lançamento é: " + livro1.AnoDeLancamento);
livro1.Recomenda1();

Livro livro2 = new Livro("Uma Janela Sombria", "Rachel Gillig", "ALT", 2024);
Console.WriteLine("\nO nome do segundo livro em sua lista é: " + livro2.Titulo);
Console.WriteLine("O nome da autora é: " + livro2.Autor);
Console.WriteLine("o nome da editora é: " + livro2.Editora);
Console.WriteLine("O ano de lançamento é: " + livro2.AnoDeLancamento);
livro1.Recomenda2();

Livro livro3 = new Livro("Divinos Rivais", "Rebecca Ross", "ALT", 2022);
Console.WriteLine("\nO nome do terceiro livro em sua lista é: " + livro3.Titulo);
Console.WriteLine("O nome da autora é: " + livro3.Autor);
Console.WriteLine("o nome da editora é: " + livro3.Editora);
Console.WriteLine("O ano de lançamento é: " + livro3.AnoDeLancamento);
livro1.Recomenda3();

Console.ReadKey();

