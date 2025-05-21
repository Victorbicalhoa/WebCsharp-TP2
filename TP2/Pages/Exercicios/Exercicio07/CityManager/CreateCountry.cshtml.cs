using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using TP2.Models;

namespace TP2.Pages.Exercicios.Exercicio07
{
    public class CreateCountryModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O nome do pa�s � obrigat�rio.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "O c�digo do pa�s � obrigat�rio.")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O c�digo do pa�s deve ter exatamente 2 caracteres.")]
            public string CountryCode { get; set; }
        }

        [BindProperty]
        public List<InputModel> Countries { get; set; } = new List<InputModel> {
            new InputModel(), new InputModel(), new InputModel(), new InputModel(), new InputModel()
        };

        public List<Country> CreatedCountries { get; set; } = new List<Country>();

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return; // Mant�m a p�gina se houver erros
            }

            foreach (var input in Countries)
            {
                CreatedCountries.Add(new Country(input.CountryName, input.CountryCode));
            }

            ViewData["Message"] = $"Foram cadastrados {CreatedCountries.Count} pa�ses.";
        }
    }
}