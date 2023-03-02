using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using chamaAi.Context;
using chamaAi.Entities;


namespace chamaAi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ChamaAiContext _context;

        public UsuarioController(ChamaAiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> PegarTodosAsync() { 
            return await _context.Usuarios.ToListAsync();
        }


        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = usuario.Id}, usuario);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var usuarios = _context.Usuarios.Where(x => x.Nome.Contains(nome));

            if (usuarios == null)
                return NotFound();

            return Ok(usuarios);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(string id, Usuario usuario)
        {
            var usuarioBanco = _context.Usuarios.Find(id);

            if(usuarioBanco == null)
                return NotFound();

            usuarioBanco.Nome = usuario.Nome;
            usuarioBanco.Sobrenome = usuario.Sobrenome;
            usuarioBanco.Telefone = usuario.Telefone;
            usuarioBanco.Email =  usuario.Email;
            usuarioBanco.DataDNascimento =  usuario.DataDNascimento;

            _context.Usuarios.Update(usuarioBanco);
            _context.SaveChanges();

            return Ok (usuarioBanco);
        }

        // [HttpPut("AtualizarPorNome")]
        // public IActionResult AtualizarPorNome(string nome, Usuario usuario)
        // {
        //     var usuarios = _context.Usuarios.Where(x => x.Nome.Contains(nome));

        //     if(usuarios == null)
        //         return NotFound();

        //     usuarios.Nome = usuario.Nome;
        //     usuarios.Sobrenome = usuario.Sobrenome;
        //     usuarios.Telefone = usuario.Telefone;
        //     usuarios.Email =  usuario.Email;
        //     usuarios.DataDNascimento =  usuario.DataDNascimento;

        //     _context.Usuarios.Update(usuarios);
        //     _context.SaveChanges();

        //     return Ok (usuarios);
        // }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            var usuarioBanco = _context.Usuarios.Find(id);

            if (usuarioBanco == null)
                return NotFound();

            _context.Usuarios.Remove(usuarioBanco);
            _context.SaveChanges();
            return NoContent();
        }

    }
}