using Microsoft.EntityFrameworkCore;

namespace Filmes.Api.Dados.Contexto;

public class FilmesContexto : DbContext
{
    public FilmesContexto() { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}