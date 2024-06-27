using APIAmbiental.Models;

namespace APIAmbiental.Data.Repository
{
    public interface IColetaRepository
    {
        IEnumerable<ColetaModel> GetALL();

        ColetaModel GetById(int id);

        void Add(ColetaModel coletaModel);
        void Update(ColetaModel coletaModel);
        void Delete(ColetaModel coletaModel);


    }
}
