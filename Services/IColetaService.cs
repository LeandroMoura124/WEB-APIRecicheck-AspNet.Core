using APIAmbiental.Models;

namespace APIAmbiental.Services
{
    public interface IColetaService
    {

        IEnumerable<ColetaModel> ListarColetas();

        ColetaModel ObterColetaPorID(int id);

        void CadastrarColeta(ColetaModel coletaModel);
        void AtualizarColeta(ColetaModel coletaModel);
        void DeletarColeta(int id);
    }
}
