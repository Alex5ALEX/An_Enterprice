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

public class MaterialController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public MaterialController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/material");

    }



    public async Task<List<Material>> GetAll()
    {
        List<Material> material = new List<Material>(); // Initialize the list of customers
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
            material.Add(new Material()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Name = token["name"].ToString(),
                Type = token["type"].ToString(),
                Description = token["description"].ToString()
            });
        }
        return material; // Return the populated list of customers
    }



    public async Task<Material> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Material(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Material>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Material material)
    {
        return httpClient.PostAsJsonAsync(url, material);
    }


    public Task<HttpResponseMessage> Put(Material material)
    {
        return httpClient.PutAsJsonAsync(url, material);
    }


    public Task<HttpResponseMessage> Del(Material material)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(material) // Создание JSON-содержимого из объекта
        });
    }



}
