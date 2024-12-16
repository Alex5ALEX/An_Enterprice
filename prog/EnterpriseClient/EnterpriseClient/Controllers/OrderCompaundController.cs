using EnterpriseClient.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseClient.Controllers;

public class OrderCompaundController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public OrderCompaundController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/order_compaund");

    }



    public async Task<List<OrderCompaund>> GetAll()
    {
        List<OrderCompaund> compaund = new List<OrderCompaund>(); // Initialize the list of customers
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
            compaund.Add(new OrderCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }
        return compaund; // Return the populated list of customers
    }



    public async Task<List<OrderCompaund>> GetByIdOrder(Guid Id)
    {
        List<OrderCompaund> compaund = new List<OrderCompaund>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync($"{url}/by_order/{Id}");

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
            compaund.Add(new OrderCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }
        return compaund; // Return the populated list of customers
    }


    public async Task<List<OrderCompaund>> GetByIdProduct(Guid Id)
    {
        List<OrderCompaund> compaund = new List<OrderCompaund>(); // Initialize the list of customers
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
            compaund.Add(new OrderCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }
        return compaund; // Return the populated list of customers
    }





    public Task<HttpResponseMessage> Post(OrderCompaund compaund)
    {
        return httpClient.PostAsJsonAsync(url, compaund);
    }


    public Task<HttpResponseMessage> Put(OrderCompaund compaund)
    {
        return httpClient.PutAsJsonAsync(url, compaund);
    }


    public Task<HttpResponseMessage> Del(OrderCompaund compaund)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(compaund) // Создание JSON-содержимого из объекта
        });
    }


}
