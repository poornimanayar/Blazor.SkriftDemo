using System.Threading.Tasks;
using Blazor.SkriftDemo.WASM.Model;
using Blazor.SkriftDemo.WASM.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor.SkriftDemo.WASM.Components
{
    public partial class WhereAmI
    {
        [Inject]
        private IGetWhereAmIService getWhereAmIService { get; set; }

        private string Latitude;

        private string Longitude;

        private WhereAmIResponseModel _whereAmIResponse;

        private async Task CheckWhereAmI()
        {
            _whereAmIResponse = await getWhereAmIService.GetWhereAmI(Latitude, Longitude);
        }
    }
}
