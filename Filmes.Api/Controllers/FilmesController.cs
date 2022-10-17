using Filmes.Api.Modelos.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Filmes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : ControllerBase
{

    public FilmesController()
    {
        //_nomeInterfaceRepositorio = nomeInterfaceRepositorio;
    }

    [HttpGet]
    public IActionResult Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult Post(FilmeDto filmeDto)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    public IActionResult Put(FilmeDto filmeDto)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        throw new NotImplementedException();
    }
}
