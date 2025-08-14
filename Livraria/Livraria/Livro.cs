using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int Ano;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}");
        }
    

    public void Atualizacao(int novoAno)
        {
            Ano = novoAno;

            //if (ano < 0)
            //{
            //    throw new ArgumentException("O ano não pode ser negativo.");
            //}
            //Ano = ano;
        }

        public int CalcularIdade()
        {

            //ano atual - ano do livro
            return DateTime.Now.Year - Ano;// Retorna a idade do livro
            
        }
    }
    
}

