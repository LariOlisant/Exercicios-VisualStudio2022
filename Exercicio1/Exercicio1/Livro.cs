namespace Exercicio1
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int AnoDeLancamento { get; set; }

        public Livro(string titulo, string autor, string editora, int anodelancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AnoDeLancamento = anodelancamento;
        }
        public void Recomenda1()
        {
            Console.WriteLine($"\nEsse livro é muito bom!Experimente Sombra e Ossos, você vai amar");
        }
        public void Recomenda2()
        {
            Console.WriteLine($"\nEsse livro é muito bom!Experimente Guerra dos Furacões, você vai amar");
        }
        public void Recomenda3()
        {
            Console.WriteLine($"\nEsse livro é muito bom!Experimente Promessas cruéis, você vai amar");
        }
    }
    }

