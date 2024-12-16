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

public class SupplyCompaundController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public SupplyCompaundController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/supply_compaund");

    }



    public async Task<List<SupplyCompaund>> GetAll()
    {
        List<SupplyCompaund> compaund = new List<SupplyCompaund>(); // Initialize the list of customers
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
            compaund.Add(new SupplyCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Material = Guid.Parse(token["id_Material"].ToString()),
                Id_Supply = Guid.Parse(token["id_Supply"].ToString()),

            });
        }
        return compaund; // Return the populated list of customers
    }



    public async Task<List<SupplyCompaund>> GetByIdMaterial(Guid Id)
    {
        List<SupplyCompaund> compaund = new List<SupplyCompaund>(); // Initialize the list of customers
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
            compaund.Add(new SupplyCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Material = Guid.Parse(token["id_Material"].ToString()),
                Id_Supply = Guid.Parse(token["id_Supply"].ToString()),

            });
        }
        return compaund; // Return the populated list of customers
    }


    public async Task<List<SupplyCompaund>> GetByIdSupply(Guid Id)
    {
        List<SupplyCompaund> compaund = new List<SupplyCompaund>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync($"{url}/by_supply/{Id}");

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
            compaund.Add(new SupplyCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Material = Guid.Parse(token["id_Material"].ToString()),
                Id_Supply = Guid.Parse(token["id_Supply"].ToString()),

            });
        }
        return compaund; // Return the populated list of customers
    }





    public Task<HttpResponseMessage> Post(SupplyCompaund compaund)
    {
        return httpClient.PostAsJsonAsync(url, compaund);
    }


    public Task<HttpResponseMessage> Put(SupplyCompaund compaund)
    {
        return httpClient.PutAsJsonAsync(url, compaund);
    }


    public Task<HttpResponseMessage> Del(SupplyCompaund compaund)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(compaund) // Создание JSON-содержимого из объекта
        });
    }


}
