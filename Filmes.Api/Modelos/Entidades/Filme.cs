namespace Filmes.Api.Modelos.Entidades;

public class Filme
{
    public int Id { get; }
    public string Titulo { get; private set; }

    public List<string> Erros { get; set; } = new List<string>();

    public Filme(string titulo)
    {
        Titulo = titulo;

        Validar();
    }

    public void Editar(string titulo)
    {
        Titulo = titulo;

        Validar();
    }

    public bool EhValido()
    {
        return Erros.Count > 0;
    }

    public void Excluir()
    {
        // Definir como inativo...
    }

    public void Validar()
    {
        AdicionarErroSeExistir(Validacoes.ValidarSeVazio(Titulo, "O campo Titulo não pode estar vazio"));
    }

    public void AdicionarErroSeExistir(string erro)
    {
        if (!string.IsNullOrWhiteSpace(erro))
        {
            Erros.Add(erro);
        }
    }
}