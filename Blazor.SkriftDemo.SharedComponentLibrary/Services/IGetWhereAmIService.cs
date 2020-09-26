using System.Threading.Tasks;
using Blazor.SkriftDemo.WASM.Model;

namespace Blazor.SkriftDemo.SharedComponentLibrary.Services
{
   public interface IGetWhereAmIService
    {
        Task<WhereAmIResponseModel> GetWhereAmI(string latitude, string longitude);
    }
}
