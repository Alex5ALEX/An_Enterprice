using EnterpriseClient.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EnterpriseClient.Controllers;

public class SupplyController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public SupplyController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/supply");

    }



    public async Task<List<Supply>> GetAll()
    {
        List<Supply> supply = new List<Supply>(); // Initialize the list of customers
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
            supply.Add(new Supply()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Date = DateTime.Parse(token["date"].ToString()),
                Description = token["description"].ToString(),
                Id_Provider = Guid.Parse(token["id_Provider"].ToString())
            });
        }
        return supply; // Return the populated list of customers
    }



    public async Task<Supply> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Supply(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Supply>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Supply supply)
    {
        return httpClient.PostAsJsonAsync(url, supply);
    }


    public Task<HttpResponseMessage> Put(Supply supply)
    {
        return httpClient.PutAsJsonAsync(url, supply);
    }


    public Task<HttpResponseMessage> Del(Supply supply)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(supply) // Создание JSON-содержимого из объекта
        });
    }

}
