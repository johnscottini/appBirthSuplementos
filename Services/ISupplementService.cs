namespace lojaSuplementosAppWeb.Services;

using lojaSuplementosAppWeb.Models;

public interface ISupplementService {
    IList<Supplement> GetAll();
    Supplement Get(int id);
    IList<Brand> GetAllBrands();
    void Insert(Supplement supplement);
    void Update(Supplement supplement);

    void Delete(int id);
}