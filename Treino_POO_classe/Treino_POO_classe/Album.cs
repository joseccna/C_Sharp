using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino_POO_classe
{
    internal class Album
    {
        public string Artista { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
        public string Gereno { get; set; } = string.Empty;  


        public void ExibirDetalhes()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
            Console.WriteLine($"Gênero: {Gereno}");
        }
        public void ExibirDetalhes(string prefixo)
        {
            Console.WriteLine($"{prefixo} Artista: {Artista}");
            Console.WriteLine($"{prefixo} Ano de Lançamento: {AnoLancamento}");
            Console.WriteLine($"{prefixo} Gênero: {Gereno}");
        }


    }
}
