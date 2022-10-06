using BlazorWebAndMAUI.Shared.Data;
using BlazorWebAndMAUI.Shared.Models;
using System.Net.Http.Json;

namespace BlazorWebAndMAUI.WebAssembly.Data
{
    public class NTKDBRepository : INTKDBRepository
    {
        private readonly HttpClient _httpClient;

        public NTKDBRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddMnenje(Mnenje mnenje)
        {
            await _httpClient.PostAsJsonAsync("mnenje", mnenje);
        }

        public async Task<List<Mnenje>> GetAllMnenje()
        {
            return await _httpClient.GetFromJsonAsync<List<Mnenje>>("mnenje");
        }
    }
}
