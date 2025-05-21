using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2.Pages.Exercicios.Exercicio08
{
    public class CityDetailsModel : PageModel
    {
        public string? CityName { get; set; }

        public void OnGet(string cityName)
        {
            CityName = cityName ?? "Cidade não informada";
        }
    }
}