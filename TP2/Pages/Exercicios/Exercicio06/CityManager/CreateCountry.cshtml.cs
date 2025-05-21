using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TP2.Models;

namespace TP2.Pages.Exercicios.Exercicio06
{
    public class CreateCountryModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O nome do país é obrigatório.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "O código do país é obrigatório.")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país deve ter exatamente 2 caracteres.")]
            public string CountryCode { get; set; }
        }

        [BindProperty]
        public InputModel CountryInput { get; set; }

        public Country CreatedCountry { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return; // Mantém a página se houver erros
            }

            CreatedCountry = new Country(CountryInput.CountryName, CountryInput.CountryCode);
            ViewData["Message"] = $"País cadastrado: {CreatedCountry.CountryName} ({CreatedCountry.CountryCode})";
        }
    }
}