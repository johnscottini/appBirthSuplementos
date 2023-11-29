

using lojaSuplementosAppWeb.Models;
using lojaSuplementosAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;

namespace lojaSuplementosAppWeb.Pages;

public class CreateModel : PageModel {
    private ISupplementService _service;
    public SelectList BrandOptionitens { get; set; }

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

    public void OnGet()
    {
        BrandOptionitens = new SelectList(_service.GetAllBrands(),
        nameof(Brand.brandId),
        nameof(Brand.description));
    }
}