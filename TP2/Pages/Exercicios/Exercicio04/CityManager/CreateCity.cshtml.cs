using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TP2.Pages.Exercicios.Exercicio04.CityManager
{
    public class CreateCityModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O nome da cidade � obrigat�rio.")]
            [MinLength(3, ErrorMessage = "O nome da cidade deve ter pelo menos 3 caracteres.")]
            public string? CityName { get; set; }
        }

        [BindProperty]
        public InputModel? City { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return; // Mant�m a p�gina se houver erros
            }

            ViewData["Message"] = $"Voc� cadastrou: {City.CityName}";
        }
    }
}