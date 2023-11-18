

using lojaSuplementosAppWeb.Models;
using lojaSuplementosAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lojaSuplementosAppWeb.Pages;

public class CreateModel : PageModel {
    private ISupplementService _service;

    public CreateModel(ISupplementService supplememtService) {
        _service = supplememtService;
    }

    [BindProperty]
    public Supplement Supplement {get; set;}

    public IActionResult OnPost() {
        if(!ModelState.IsValid) {
            return Page();
        }
        _service.Insert(Supplement);

        return RedirectToPage("/Index");
    }
}