namespace lojaSuplementosAppWeb.Models;

public class Brand
{
    public int brandId { get; set; }
    public string description { get; set; }

    public ICollection<Supplement> Supplements { get; set; }
}
