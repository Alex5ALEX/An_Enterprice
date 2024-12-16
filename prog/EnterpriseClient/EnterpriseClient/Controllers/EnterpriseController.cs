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

public class EnterpriseController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public EnterpriseController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/enterprise");

    }



    public async Task<List<Enterprise>> GetAll()
    {
        List<Enterprise> enterprises = new List<Enterprise>(); // Initialize the list of customers
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
            enterprises.Add(new Enterprise()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Company = token["company"].ToString(),
                ContactPerson = token["contactPerson"].ToString(),
                Phone = token["phone"].ToString(),
                Email = token["email"].ToString(),
                Address = token["address"].ToString(),
                Description = token["description"].ToString(),
            });
        }
        return enterprises; // Return the populated list of customers
    }



    public async Task<Enterprise> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Enterprise(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Enterprise>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Enterprise enterprise)
    {
        return httpClient.PostAsJsonAsync(url, enterprise);
    }


    public Task<HttpResponseMessage> Put(Enterprise enterprise)
    {
        return httpClient.PutAsJsonAsync(url, enterprise);
    }


    public Task<HttpResponseMessage> Del(Enterprise enterprise)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(enterprise) // Создание JSON-содержимого из объекта
        });
    }
}
