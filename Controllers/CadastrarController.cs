using Microsoft.AspNetCore.Mvc;

namespace Peak.Controllers
{
    [ApiController]
    [Route("Cadastrar")]
    public class CadastroCalculo : Controller
    {
        public Decimal Calculo(int parcelas, decimal valor)
        {
            var resultado = valor * parcelas;
            var juros = Decimal.Multiply(resultado, (decimal)0.05);
            var total = resultado + juros;

            return total;
        }
    }
}
