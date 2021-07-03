using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Tasked.Shared.Data;

namespace Tasked.Client.Services.Works
{
    public class WorkService : IWorkService
    {
        private readonly HttpClient _httpClient;

        public WorkService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Work>> GetWorks()
        {
            return await _httpClient.GetFromJsonAsync<List<Work>>("api/works");
        }

    }
}
