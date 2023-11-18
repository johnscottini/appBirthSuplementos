
using lojaSuplementosAppWeb.Models;

namespace lojaSuplementosAppWeb.Services;
public class SupplementService : ISupplementService {

    private IList<Supplement> _supplements;

    public SupplementService()
        => LoadInitialList();

    private void LoadInitialList()
    {
        _supplements = new List<Supplement>()
        {
            new Supplement
            {
                SupplementId = 1,
                Name = "Creatina",
                Description = "A melhor creatina. Com selo creapure e com ótimo custo benefício.",
                ImageUri = "/images/creatina.jpg",
                RegistrationDate = DateTime.Now,
                HasGluten = true,
                Value = 85.00,
            },
            new Supplement
            {
                SupplementId = 2,
                Name = "Dittor",
                Description = "Um novo suplemento, contendo as mais importantes vitaminas para garantir sua hipertrofia ",
                ImageUri = "/images/diottor.jpg",
                RegistrationDate = DateTime.Now,
                HasGluten = false,
                Value = 150.00,
            },
            new Supplement
            {
                SupplementId = 3,
                Name = "Awesoe blue shirt",
                Description = "Camisa azul slim-fit que se ajusta conforme seu corpo!",
                ImageUri = "/images/shirts.jpg",
                RegistrationDate = DateTime.Now,
                HasGluten = true,
                Value = 99.00,
            },
            new Supplement
            {
                SupplementId = 4,
                Name = "Vitamina Will",
                Description = "A Vitamina Will é um novo formato de cápsulas que irá revolucionar o mercado",
                ImageUri = "/images/vitaminWill.jpg",
                RegistrationDate = DateTime.Now,
                HasGluten = false,
                Value = 229.00,
            },
        };
    }
    public IList<Supplement> GetAll() => _supplements;

    public Supplement Get(int id) {
        return _supplements.SingleOrDefault(item => item.SupplementId == id);
    }

    public void Insert(Supplement supplement)
    {
        var nextNumber = _supplements.Max(item =>  item.SupplementId) + 1;
        supplement.SupplementId = nextNumber;
        _supplements.Add(supplement);
    }

    public void Update(Supplement supplement)
    {
        var supplementFound = Get(supplement.SupplementId);
        supplementFound.Name = supplement.Name;
        supplementFound.Description = supplement.Description;
        supplementFound.Value = supplement.Value;
        supplementFound.HasGluten = supplement.HasGluten;
        supplementFound.RegistrationDate = supplement.RegistrationDate;
    }

    public void Delete(int id)
    {
        var supplementFound = Get(id);
        _supplements.Remove(supplementFound);
    }
}