Episodio ep1 = new(1, "A importância do C#", 45);
ep1.AdicionarConvidados("João Silva");
ep1.AdicionarConvidados("Maria Pereira");

Episodio ep2 = new(2, "Explorando o ASP.NET Core", 67);
ep2.AdicionarConvidados("Carlos Souza");
ep2.AdicionarConvidados("Ana Oliveira");

Console.WriteLine("Resumo dos episódios:");
Console.WriteLine(ep1.Resumo);
Console.WriteLine(ep2.Resumo);
Console.WriteLine();

Podcast podcast = new Podcast("Podcast CSharp", "Paulo Almeida");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();