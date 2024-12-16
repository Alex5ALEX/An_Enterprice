using EnterpriseClient.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseClient.Controllers;

public class MaterialCompaundController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public MaterialCompaundController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/material_compaund");

    }



    public async Task<List<MaterialCompaund>> GetAll()
    {
        List<MaterialCompaund> compaund = new List<MaterialCompaund>(); // Initialize the list of customers
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
            compaund.Add(new MaterialCompaund()
            {
                Weight = double.Parse(token["weight"].ToString()),
                Id_Material = Guid.Parse(token["id_Material"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }
        return compaund; // Return the populated list of customers
    }



    public async Task<List<MaterialCompaund>> GetByIdMaterial(Guid Id)
    {
        List<MaterialCompaund> compaund = new List<MaterialCompaund>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync($"{url}/by_material/{Id}");

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
            compaund.Add(new MaterialCompaund()
            {
                Weight = double.Parse(token["weight"].ToString()),
                Id_Material = Guid.Parse(token["id_Material"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }
        return compaund; // Return the populated list of customers
    }


    public async Task<List<MaterialCompaund>> GetByIdProduct(Guid Id)
    {
        List<MaterialCompaund> compaund = new List<MaterialCompaund>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync($"{url}/by_product/{Id}");

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
            compaund.Add(new MaterialCompaund()
            {
                Weight = double.Parse(token["weight"].ToString()),
                Id_Material = Guid.Parse(token["id_Material"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }
        return compaund; // Return the populated list of customers
    }





    public Task<HttpResponseMessage> Post(MaterialCompaund compaund)
    {
        return httpClient.PostAsJsonAsync(url, compaund);
    }


    public Task<HttpResponseMessage> Put(MaterialCompaund compaund)
    {
        return httpClient.PutAsJsonAsync(url, compaund);
    }


    public Task<HttpResponseMessage> Del(MaterialCompaund compaund)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(compaund) // Создание JSON-содержимого из объекта
        });
    }


}
