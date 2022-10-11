using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [ApiController] //Definindo classe como controlador
    [Route ("[Controller]")] //Explicitando a rota do controller (nome do meu controlador)
    public class ControllerAPI : ControllerBase
    {
        private Context _context;
        public ControllerAPI(Context context)
        {
            _context = context;
        }

        //informando a ação a ser realizada dentro do controlador (modelo arquitetural Rest)
        [HttpPost("Adicionar Clientes")]
        //Função para quando enviar uma requisição para adicionar um usuario
        public async Task<ActionResult<Clientes>> AddCliente(Clientes clientes)
        {
            try
            {
                _context.Clientes.Add(clientes);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetClientes", new { cpf = clientes.CPF }, clientes);
            }
            catch
            {
                return BadRequest("Ja existe um cadastro com o mesmo CPF informado");
            }  
        }
        [HttpDelete ("Excluir cliente")]
        public async Task<ActionResult<Clientes>>EcluirCliente(string cpf)
        {
            Clientes clientes = _context.Clientes.FirstOrDefault(cliente => cliente.CPF == cpf);
            try
            {
                _context.Clientes.Remove(clientes);
                await _context.SaveChangesAsync();
                return Ok("Cliente deletado com sucesso");
            }
            catch
            {
                return NotFound("Não existe cadastro com o CPF informado");
            }
            
        }

        [HttpGet("Listar Clientes")]
        public IActionResult ListarUser()
        {
            return Ok(_context.Clientes);
        }

    }
}
