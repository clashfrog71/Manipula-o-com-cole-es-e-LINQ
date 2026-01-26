using System.Collections;
class Program
{
    public static void Main(string[] Args)
    {
        Musica musica1 = new Musica { Titulo = "Imagine", Artista = "John Lemon", DuracaoEmSegundos = 183 };
        Musica musica2 = new Musica { Titulo = "Bohemian Rhapsody", Artista = "Queen", DuracaoEmSegundos = 354 };
        Musica musica3 = new Musica { Titulo = "Hotel California", Artista = "Eagles", DuracaoEmSegundos = 391 };
        Playlist playlist = new Playlist { nome = "só jesus" };
        playlist.AdicionarMusica(musica1);
        playlist.AdicionarMusica(musica2);
        playlist.AdicionarMusica(musica3);
    }
    void exibirMaisTocadas(Playlist playlist1, Playlist playlist2)
    {
        Dictionary<Playlist, int> ranking = [];
        foreach (var musica in playlist1)
        {
            ranking.Add(musica, 1);
        }
        foreach (var musica in playlist2)
        {
                if (ranking.TryGetValue(musica, out int contagem))
            {
                contagem++;
                ranking[musica]=contagem;

            }else
            {
                ranking[musica] = 1;
            }
        }
    }
    public class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int DuracaoEmSegundos { get; set; }
    }
    


    class Playlist : IEnumerable<Musica>

    {
        public string nome { get; set; }
        private List<Musica> musicas = [];

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void RemoverMusica(Musica musica)
        {
            musicas.Remove(musica);
        }
        public IEnumerator<Musica> GetEnumerator()
        {
            return musicas.GetEnumerator();
        }
        public void acharMusicasPeloTitulo(string titulo)
        {
            musicas.Where(m => m.Titulo.Contains(titulo)).ToList().ForEach(m =>
            {
                Console.WriteLine($"Título: {m.Titulo}, Artista: {m.Artista}, Duração: {m.DuracaoEmSegundos} segundos");
            });
        }
        public void acharMusicasPeloArtista(string artista)
        {
            musicas.Where(m => m.Artista.Contains(artista)).ToList().ForEach(m =>
            {
                Console.WriteLine($"Título: {m.Titulo}, Artista: {m.Artista}, Duração: {m.DuracaoEmSegundos} segundos");
            });
        }
        public void ListarMusicasPorDuracao(int duracaoMinima)
        {
            musicas.Where(m => m.DuracaoEmSegundos >= duracaoMinima).ToList().ForEach(m =>
            {
                Console.WriteLine($"Título: {m.Titulo}, Artista: {m.Artista}, Duração: {m.DuracaoEmSegundos} segundos");
            });
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal void exibirMusicas(Playlist playlist)
        {
            foreach (var musica in playlist)
            {
                Console.WriteLine($"Título: {musica.Titulo}, Artista: {musica.Artista}, Duração: {musica.DuracaoEmSegundos} segundos");
            }
        }
    }
}