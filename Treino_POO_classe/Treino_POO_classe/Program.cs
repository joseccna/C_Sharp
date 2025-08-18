using System;
using Treino_POO_classe;

class Program
{
    static void Main(string[] args)
    {
        Album album = new Album
        {
            Artista = "The Beatles",
            AnoLancamento = 1969,
            Gereno = "Rock"
        };
        // Exibindo detalhes do álbum
        album.ExibirDetalhes();
        // Exibindo detalhes com prefixo
        album.ExibirDetalhes("Prefixo: ");
        

    }
}