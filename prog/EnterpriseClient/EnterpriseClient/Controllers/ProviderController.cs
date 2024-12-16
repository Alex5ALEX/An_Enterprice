using EnterpriseClient.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseClient.Controllers;

public class ProviderController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public ProviderController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/provider");

    }



    public async Task<List<Provider>> GetAll()
    {
        List<Provider> provider = new List<Provider>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            content = await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null; // Return null on error
        }

        var contentArray = JArray.Parse(content);

        foreach (var token in contentArray)
        {
            provider.Add(new Provider()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Company = token["company"].ToString(),
                ContactPerson = token["contactPerson"].ToString(),
                Phone = token["phone"].ToString(),
                Email = token["email"].ToString(),
                Address = token["address"].ToString(),
            });
        }
        return provider; // Return the populated list of customers
    }



    public async Task<Provider> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Provider(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Provider>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Provider provider)
    {
        return httpClient.PostAsJsonAsync(url, provider);
    }


    public Task<HttpResponseMessage> Put(Provider provider)
    {
        return httpClient.PutAsJsonAsync(url, provider);
    }


    public Task<HttpResponseMessage> Del(Provider provider)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(provider) // Создание JSON-содержимого из объекта
        });
    }

}
