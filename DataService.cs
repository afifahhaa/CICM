using CICMmauiApp.Data;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CICMmauiApp
{
    public class DataService : ContentPage
    {
        private readonly HttpClient _httpClient;

        public DataService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<GetIssue>> GetItemsAsync(string url)
        {
            var items = await _httpClient.GetFromJsonAsync<List<GetIssue>>(url);
            return items;
        }

        internal async Task GetIssueAsync(string apiUrl)
        {
           //throw new NotImplementedException();
        }
    }
}