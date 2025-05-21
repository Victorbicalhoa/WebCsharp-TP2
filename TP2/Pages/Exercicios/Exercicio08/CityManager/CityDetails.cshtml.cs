using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace TP2.Pages.Exercicios.Exercicio09
{
    public class CityListModel : PageModel
    {
        public List<string> Cities { get; set; } = new List<string> { "Rio de Janeiro", "São Paulo", "Brasília" };
    }
}