using System.ComponentModel.DataAnnotations;

namespace lojaSuplementosAppWeb.Models;


public class Supplement {
    public int SupplementId {get; set;}

    [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'nome' é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo 'Nome'deve conter entre 3 e 50 caracteres.")]
    public string Name {get; set;}

    public string NameSlug => Name.ToLower().Replace(" ", "-");

    [Display(Name = "Descrição")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'descrição' é obrigatório.")]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "O campo 'descrição' deve conter entre 10 e 100 caracteres.")]
    public string Description {get; set;}

    [Display(Name = "Preço")]
    [Required(ErrorMessage = "O campo 'Preço' é obrigatório.")]
    [DataType(DataType.Currency)]
    public double Value {get; set;}

    [Display(Name = "Possui glúten")]
    public bool HasGluten { get; set; }

    public string formatedHasGluten => HasGluten ? "Sim" : "Não";

    [Display(Name = "Caminho da Imagem")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "O campo 'Caminho da Image' é obrigatório.")]
    public string ImageUri {get; set;}

    [Display(Name = "Data de fabricação")]
    [Required(ErrorMessage = "O campo 'data de fabricação' é obrigatório.")]
    [DataType("month")]
    [DisplayFormat(DataFormatString = "{0:D}")]
    public DateTime RegistrationDate {get; set;}

    [Display(Name = "Marca")]
    public int? BrandId { get; set; }
}