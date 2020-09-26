using System.Threading.Tasks;
using Blazor.SkriftDemo.SharedComponentLibrary.Services;
using Blazor.SkriftDemo.WASM.Model;
using Microsoft.AspNetCore.Components;

namespace Blazor.SkriftDemo.SharedComponentLibrary.Components
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
