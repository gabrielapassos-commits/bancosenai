using Microsoft.AspNetCore.Mvc;

namespace BancoSENAIAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DocumentoController : Controller
    {
        private readonly string _caminhoRaiz = Path.Combine(Directory.GetCurrentDirectory(), "clienteArquivo");
        private static List<Models.DocumentoMetadados> _documentosMetadados = new List<Models.DocumentoMetadados>();
        private static int _nextId = 1;

        [HttpPost("upload/{codigoCliene}")]
        public async Task<IActionResult> AnexarArquivo(int codigoCliente, IFormFile arquivo) 
        {
        
        }
    }
}
