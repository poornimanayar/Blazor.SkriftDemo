using System.Threading.Tasks;
using Blazor.SkriftDemo.WASM.Model;

namespace Blazor.SkriftDemo.WASM.Services
{
   public interface IGetWhereAmIService
    {
        Task<WhereAmIResponseModel> GetWhereAmI(string latitude, string longitude);
    }
}
