using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;
using System.Collections.Generic;

namespace TP2.Pages.Exercicios.Exercicio11
{
    public class ReadNotesModel : PageModel
    {
        public List<string> FileNames { get; set; } = new List<string>();
        public string? FileContent { get; set; }

        public void OnGet()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            Directory.CreateDirectory(folderPath); // Garante que a pasta existe

            FileNames = new List<string>(Directory.GetFiles(folderPath, "*.txt"));
        }

        public void OnGetView(string fileName)
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            string fullPath = Path.Combine(folderPath, fileName);

            if (System.IO.File.Exists(fullPath))
            {
                FileContent = System.IO.File.ReadAllText(fullPath);
            }
            else
            {
                FileContent = "Arquivo não encontrado.";
            }
        }
    }
}