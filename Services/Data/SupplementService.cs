using lojaSuplementosAppWeb.Data;
using lojaSuplementosAppWeb.Models;

namespace lojaSuplementosAppWeb.Services.Data
{
    public class SupplementService : ISupplementService
    {
        private LojaSuplementosDbContext _context;

        public SupplementService(LojaSuplementosDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var foundSupplement = Get(id);
            _context.Supplement.Remove(foundSupplement);
            _context.SaveChanges();
        }

        public Supplement Get(int id)
        {
            return _context.Supplement.SingleOrDefault(item => item.SupplementId == id);
        }

        public IList<Supplement> GetAll()
        {
            return _context.Supplement.ToList();
        }

        public IList<Brand> GetAllBrands()
        {
            return _context.Brand.ToList();
        }

        public void Insert(Supplement supplement)
        {
            _context.Supplement.Add(supplement);
            _context.SaveChanges();
        }

        public void Update(Supplement supplement)
        {
            var supplementFound = Get(supplement.SupplementId);
            supplementFound.Name = supplement.Name;
            supplementFound.Description = supplement.Description;
            supplementFound.Value = supplement.Value;
            supplementFound.HasGluten = supplement.HasGluten;
            supplementFound.RegistrationDate = supplement.RegistrationDate;
            supplementFound.ImageUri = supplement.ImageUri;
            supplementFound.BrandId = supplement.BrandId;
            _context.SaveChanges();
        }
    }
}
