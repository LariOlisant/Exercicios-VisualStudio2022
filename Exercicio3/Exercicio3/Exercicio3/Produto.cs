namespace Exercicio3
{
    internal class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Estoque { get; set; }


        public Produto(int codigo, string nome, double preco, string estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        public void estoque1()
        {
            Console.WriteLine($"\nTemos 69 unidades de banana prata em nosso estoque, corra para levar a sua!");
        }
        public void estoque2()
        {
            Console.WriteLine($"\nOh não! O Mamão Papaya se encontra indisponível em nosso estoque, volte novamente daqui uma semana até nós repormos para você, confira outros produtos!");
        }
        public void estoque3()
        {
            Console.WriteLine($"\nTemos 93 unidades de chuchu em nosso estoque, corra para levar a sua!");
        }
    }
}