class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; set; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("==================================");
        Console.WriteLine($" Podcast: {Nome}");
        Console.WriteLine($" Host: {Host}");
        Console.WriteLine("==================================\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Episódio {episodio.Ordem}:");
            Console.WriteLine($" Título: {episodio.Titulo}");
            Console.WriteLine($" Duração: {episodio.Duracao} minutos");
            Console.WriteLine($" Convidados: {string.Join(", ", episodio.Resumo)}\n");
            Console.WriteLine("----------------------------------");
        }

        Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódio(s).\n");
    }
}