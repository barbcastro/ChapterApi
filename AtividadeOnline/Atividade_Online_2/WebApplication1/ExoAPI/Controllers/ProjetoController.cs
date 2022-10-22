using ExoApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExoApi.Models;

namespace ExoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : Controller
    {
        private readonly ProjetoRepository _projetoRepository;
        
        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository; 
        }

        [HttpGet]
        public IActionResult listar()
        {
            try
            {
                return Ok(_projetoRepository.listar());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Projeto projeto = _projetoRepository.BuscarPorId(id);
                
                if(projeto == null)
                {
                    return NotFound;
                }
                return ok(projeto);
            }
            catch(Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                _projetoRepository.Cadastrar(projeto);
                return StatusCode(201);
            }
            catch(Exception)
            {
                throw;
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            try
            {
                Projeto projetoBuscado = _projetoRepository.BucarPorId(id);
                if(projetoBuscado == null)
                {
                    return NotFound();
                }
                _projetoRepository.Atualizar(id, projeto);
                return StatusCode(204);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                Projeto projeto = _projetoRepository.BucarPorId(id);
                if(projeto == null)
                {
                    return NotFound;
                }

                _projetoRepository.Deletar(id)
                return StatusCode(204);
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
