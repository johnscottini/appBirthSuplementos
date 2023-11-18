using lojaSuplementosAppWeb.Models;
using lojaSuplementosAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lojaSuplementosAppWeb.Pages;

public class IndexModel : PageModel{
    private ISupplementService _service;

    public IndexModel(ISupplementService supplememtService) {
        _service = supplememtService;
    }

    public IList<Supplement> SupplementList {get; set;}

    public void OnGet() {
        ViewData["Title"] = "Home page";
        SupplementList = _service.GetAll();
    }
}