using System;

namespace ListaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista x = new Lista(7);

            x.AdicionarFinal(20);
            x.AdicionarFinal(10);
            x.AdicionarFinal(5);
            x.AdicionarInicio(58);
            x.AdicionarInicio(55);
            x.RemoverInicio();
            x.AdicionarPosicao(16, 1);
            x.RemoverPosicao(1);
            x.AdicionarFinal(12);
            x.AdicionarFinal(15);
            x.AdicionarFinal(18);

            Console.WriteLine("A lista está cheia?");
            Console.WriteLine(x.ListaCheia());
            Console.WriteLine();

            Console.WriteLine("Elementos da lista:");
            foreach (int i in x.Vetor_Elementos)
            {
                Console.WriteLine(i);
            }
        }
    }
}
