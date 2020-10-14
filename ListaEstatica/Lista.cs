using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEstatica
{
    class Lista
    {
        public int[] Vetor_Elementos { get; set; }
        public int Numero_Elementos { get; set; }


        public Lista(int t)
        {
            Vetor_Elementos = new int[t];
            Numero_Elementos = 0;
        }

        public bool ListaVazia()
        {
            if (Numero_Elementos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ListaCheia()
        {
            if (Numero_Elementos > Vetor_Elementos.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AdicionarFinal(int e)
        {
            if (ListaCheia())
            {
                throw new Exception("Erro! Lista cheia");
            }
            else
            {
                int indice = Numero_Elementos;
                Vetor_Elementos[indice] = e;
                Numero_Elementos += 1;
            }
        }

        public int RemoverFinal()
        {
            if (ListaVazia())
            {
                throw new Exception("Erro! Lista vazia");
            }
            else
            {
                int indice = Numero_Elementos - 1;
                int elemento_removido = Vetor_Elementos[indice];
                Numero_Elementos = indice;
                return elemento_removido;
            }
        }

        public void AdicionarInicio(int e)
        {
            if (ListaCheia())
            {
                throw new Exception("Erro! Lista cheia");
            }
            else
            {
                for (int indice = Numero_Elementos; indice > 0; indice--)
                {
                    Vetor_Elementos[indice] = Vetor_Elementos[indice - 1];
                }
                Vetor_Elementos[0] = e;
                Numero_Elementos += 1;
            }
        }

        public int RemoverInicio()
        {
            if (ListaVazia())
            {
                throw new Exception("Erro! Lista vazia");
            }
            else
            {
                int elemento_removido = Vetor_Elementos[0];
                for (int indice = 1; indice <= Numero_Elementos; indice++)
                {
                    Vetor_Elementos[indice - 1] = Vetor_Elementos[indice];
                }
                Numero_Elementos -= 1;
                return elemento_removido;
            }
        }

        public void AdicionarPosicao(int e, int i)
        {
            if (ListaCheia())
            {
                throw new Exception("Erro! Lista cheia");
            }
            else
            {
                if (i <= 0)
                {
                    AdicionarInicio(e);
                }
                else if (i >= Numero_Elementos)
                {
                    AdicionarFinal(e);
                }
                else
                {
                    for (int indice = Numero_Elementos; indice > 0; indice--)
                    {
                        Vetor_Elementos[indice] = Vetor_Elementos[indice - 1];
                    }
                    Vetor_Elementos[i] = e;
                    Numero_Elementos += 1;
                }
            }
        }
        public int RemoverPosicao(int i)
        {
            if (ListaVazia())
            {
                throw new Exception("Erro! Lista vazia");
            }
            else
            {
                if (i <= 0)
                {
                    return RemoverInicio();
                }
                else if (i >= Numero_Elementos)
                {
                    return RemoverFinal();
                }
                else
                {
                    int elemento_removido = Vetor_Elementos[i];
                    for (int indice = i; indice <= Numero_Elementos - 1; indice++)
                    {
                        Vetor_Elementos[indice] = Vetor_Elementos[indice + 1];
                    }
                    Numero_Elementos -= 1;
                    return elemento_removido;
                }
            }
        }
    }
}
