using System.Collections;
class Program
{
    public class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int DuracaoEmSegundos { get; set; }
    }
    void exibirMusicas(Playlist playlist)
    {
        foreach (var musica in playlist)
        {
            Console.WriteLine($"Título: {musica.Titulo}, Artista: {musica.Artista}, Duração: {musica.DuracaoEmSegundos} segundos");
        }
    }
    class Playlist : IEnumerable<Musica>

    {
        public string nome { get; set; }
        private List<Musica> musicas = [];

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public IEnumerator<Musica> GetEnumerator()
        {
            return musicas.GetEnumerator();
        }
        public void acharMusicas()
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}