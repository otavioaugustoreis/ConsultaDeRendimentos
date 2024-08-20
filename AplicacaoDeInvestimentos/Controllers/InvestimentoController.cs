using Microsoft.AspNetCore.Mvc;

namespace AplicacaoDeInvestimentos.Controllers
{
    public class InvestimentoController : ControllerBase
    {

        private readonly HttpClient _httpClient;

        public InvestimentoController(HttpClient httpClient) {
            _httpClient = httpClient;
        }
    }
}
