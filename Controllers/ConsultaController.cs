using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Peak.Controllers
{
    [ApiController]
    [Route("Consultar")]
    public class ConsultaController : Controller
    {
        [HttpGet]
        public String Consulta(int indice)
        {
            var lista = new List<KeyValuePair<int, string>>();
            lista.Add(new KeyValuePair<int, string>(1, "João"));
            lista.Add(new KeyValuePair<int, string>(2, "Maria"));
            lista.Add(new KeyValuePair<int, string>(3, "Ana"));

            var nome = lista[indice-1].Value;

            return nome;
        }
    }
}
