using APIAmbiental.Data.Contexts;
using APIAmbiental.Data.Repository;
using APIAmbiental.Models;

namespace APIAmbiental.Services
{
    public class ColetaService : IColetaService
    {
        private readonly IColetaRepository _repository;

        public ColetaService(IColetaRepository repository)
        {
            _repository = repository;
        }

        public void CadastrarColeta(ColetaModel coletaModel) => _repository.Add(coletaModel);
        public void AtualizarColeta(ColetaModel coletaModel) => _repository.Update(coletaModel);
        public void DeletarColeta(int id)
        {
            var coletas = _repository.GetById(id);
            if (coletas != null)
            {
                _repository.Delete(coletas);
            }
        }

        public IEnumerable<ColetaModel> ListarColetas() => _repository.GetALL(); 
   
        public ColetaModel ObterColetaPorID(int id) => _repository.GetById(id);
    }
}
