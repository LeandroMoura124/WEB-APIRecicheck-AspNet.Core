using APIAmbiental.Data.Contexts;
using APIAmbiental.Models;

namespace APIAmbiental.Data.Repository
{


    public class ColetaRepository : IColetaRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ColetaRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }
        
        public void Add(ColetaModel coletaModel)
        {
            _databaseContext.Coletas.Add(coletaModel);
            _databaseContext.SaveChanges();
        }

        public void Delete(ColetaModel coletaModel)
        {
            _databaseContext.Coletas.Remove(coletaModel);
            _databaseContext.SaveChanges();
        }

        public IEnumerable<ColetaModel> GetALL()
        {
            return _databaseContext.Coletas.ToList(); ;
        }

        public ColetaModel GetById(int id)
        {
            return _databaseContext.Coletas.Find(id);
        }

        public void Update(ColetaModel coletaModel)
        {
            _databaseContext.Coletas.Update(coletaModel);
            _databaseContext.SaveChanges();
        }
    }
}
