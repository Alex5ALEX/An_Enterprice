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

public class OrderController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public OrderController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/order");

    }



    public async Task<List<Order>> GetAll()
    {
        List<Order> order = new List<Order>(); // Initialize the list of customers
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
            order.Add(new Order()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Date = DateTime.Parse(token["date"].ToString()),
                Description = token["description"].ToString(),
                Id_Customer = Guid.Parse(token["id_Customer"].ToString())
            });
        }
        return order; // Return the populated list of customers
    }



    public async Task<Order> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Order(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Order>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Order order)
    {
        return httpClient.PostAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> Put(Order order)
    {
        return httpClient.PutAsJsonAsync(url, order);
    }


    public Task<HttpResponseMessage> Del(Order order)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(order) // Создание JSON-содержимого из объекта
        });
    }
}
