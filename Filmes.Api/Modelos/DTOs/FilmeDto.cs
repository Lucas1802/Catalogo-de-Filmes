using System.ComponentModel.DataAnnotations;

namespace Filmes.Api.Modelos.DTOs;

public class FilmeDto
{
    [Required(ErrorMessage = "O campo Título é obrigatório")]
    public string Titulo { get; set; }
    
    // Outras propriedades...
}