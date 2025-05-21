using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TP2.Pages.Exercicios.Exercicio04.CityManager
{
    public class CreateCityModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
            [MinLength(3, ErrorMessage = "O nome da cidade deve ter pelo menos 3 caracteres.")]
            public string? CityName { get; set; }
        }

        [BindProperty]
        public InputModel? City { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return; // Mantém a página se houver erros
            }

            ViewData["Message"] = $"Você cadastrou: {City.CityName}";
        }
    }
}