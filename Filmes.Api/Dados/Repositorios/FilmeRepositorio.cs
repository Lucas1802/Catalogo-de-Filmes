using Filmes.Api.Dados.Contexto;
using Filmes.Api.Modelos.Entidades;

namespace Filmes.Api.Dados.Repositorios;

public class FilmeRepositorio : IFilmeRepositorio
{
    private readonly FilmesContexto _contexto;

    public FilmeRepositorio(FilmesContexto contexto)
    {
        _contexto = contexto;
    }

    public IEnumerable<Filme> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public Filme ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Adicionar(Filme filme)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Filme filme)
    {
        throw new NotImplementedException();
    }
}
