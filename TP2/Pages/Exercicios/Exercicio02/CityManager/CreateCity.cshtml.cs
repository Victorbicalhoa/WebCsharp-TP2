using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace TP2.Pages.Exercicios.Exercicio02.CityManager
{
    public class CreateCityModel : PageModel
    {
        public void OnPost(string cityName)
        {
            // Exibe a mensagem com o nome recebido
            ViewData["Message"] = $"Você cadastrou: {cityName}";
        }
    }
}