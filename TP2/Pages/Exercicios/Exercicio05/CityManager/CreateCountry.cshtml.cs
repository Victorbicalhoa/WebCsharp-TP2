using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TP2.Models;

namespace TP2.Pages.Exercicios.Exercicio05
{
    public class CreateCountryModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O nome do pa�s � obrigat�rio.")]
            public string? CountryName { get; set; }

            [Required(ErrorMessage = "O c�digo do pa�s � obrigat�rio.")]
            [MinLength(2, ErrorMessage = "O c�digo deve ter pelo menos 2 caracteres.")]
            public string? CountryCode { get; set; }
        }

        [BindProperty]
        public InputModel? CountryInput { get; set; }

        public Country? CreatedCountry { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return; // Mant�m a p�gina se houver erros
            }

            CreatedCountry = new Country(CountryInput.CountryName, CountryInput.CountryCode);
            ViewData["Message"] = $"Pa�s cadastrado: {CreatedCountry.CountryName} ({CreatedCountry.CountryCode})";
        }
    }
}