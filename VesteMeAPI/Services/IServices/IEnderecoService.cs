using System.Threading.Tasks;
using VesteMeAPI.Models;

namespace VesteMeAPI.Services.IServices
{
    public interface IEnderecoService
    {
        Task<Endereco> BuscarEndereco(int idEndereco);
        Task CriarEndereco(Endereco endereco);
        Task AtualizarEndereco(Endereco endereco);
    }
}