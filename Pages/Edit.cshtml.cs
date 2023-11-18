using lojaSuplementosAppWeb.Models;
using lojaSuplementosAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lojaSuplementosAppWeb.Pages;

public class EditModel : PageModel { 
        private ISupplementService _service;
        public EditModel(ISupplementService supplementService)
        {
            _service = supplementService;
        }

        [BindProperty]
        public Supplement Supplement { get; set; }

        public void OnGet(int id)
            => Supplement = _service.Get(id);

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Update(Supplement);

            return RedirectToPage("/Index");
        }
        public IActionResult OnPostDelete()
        {
            _service.Delete(Supplement.SupplementId);

            TempData["TempMensagemSucesso"] = true;
            
            return RedirectToPage("/Index");
        }
    }