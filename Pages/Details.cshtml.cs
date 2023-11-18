using lojaSuplementosAppWeb.Models;
using lojaSuplementosAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lojaSuplementosAppWeb.Pages;

public class DetailsModel : PageModel {
    private ISupplementService _service;

    public DetailsModel(ISupplementService supplementService)
    {
        _service = supplementService;
    }

    public Supplement Supplement { get; private set; }

    public IActionResult OnGet(int id)
    {
        Supplement = _service.Get(id);

        if (Supplement == null)
        {
            return NotFound();
        }

        return Page();
    }
}