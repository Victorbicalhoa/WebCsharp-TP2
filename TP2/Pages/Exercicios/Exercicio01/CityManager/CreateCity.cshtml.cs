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
            // Aqui, os dados são processados após o envio do formulário
        }
    }
}