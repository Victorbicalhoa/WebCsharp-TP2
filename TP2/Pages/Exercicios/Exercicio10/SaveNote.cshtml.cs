using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace TP2.Pages.Exercicios.Exercicio10
{
    public class SaveNoteModel : PageModel
    {
        public class InputModel
        {
            [Required(ErrorMessage = "O conte�do da nota � obrigat�rio.")]
            public string Content { get; set; }
        }

        [BindProperty]
        public InputModel NoteInput { get; set; }

        public string FilePath { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return; // Mant�m a p�gina se houver erros
            }

            // Define o caminho do arquivo
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            Directory.CreateDirectory(folderPath); // Garante que a pasta existe

            string fileName = $"note-{DateTime.Now:yyyyMMdd-HHmmss}.txt";
            FilePath = $"/files/{fileName}";

            string fullPath = Path.Combine(folderPath, fileName);
            System.IO.File.WriteAllText(fullPath, NoteInput.Content); // Grava o conte�do

            ViewData["Message"] = $"Nota salva com sucesso! <a href='{FilePath}' download>Baixar Arquivo</a>";
        }
    }
}