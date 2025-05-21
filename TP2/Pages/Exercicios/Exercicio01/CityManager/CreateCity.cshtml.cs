using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace TP2.Pages.Exercicios.Exercicio01.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public string? CityName { get; set; }

        public void OnPost()
        {
            // Aqui, os dados s�o processados ap�s o envio do formul�rio
        }
    }
}