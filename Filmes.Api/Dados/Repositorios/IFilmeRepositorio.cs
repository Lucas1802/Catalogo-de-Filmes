using Filmes.Api.Modelos.Entidades;

namespace Filmes.Api.Dados.Repositorios;

public interface IFilmeRepositorio
{
    IEnumerable<Filme> ObterTodos();
    Filme ObterPorId(int id);
    void Adicionar(Filme filme);
    void Atualizar(Filme filme);
}