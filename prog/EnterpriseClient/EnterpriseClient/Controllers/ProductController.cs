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

public class ProductController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public ProductController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/product");

    }



    public async Task<List<Product>> GetAll()
    {
        List<Product> product = new List<Product>(); // Initialize the list of customers
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
            product.Add(new Product()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Name = token["name"].ToString(),
                Price = decimal.Parse(token["price"].ToString()),
                Weight = double.Parse(token["weight"].ToString()),
                Id_Enterprise = Guid.Parse(token["id_Enterprise"].ToString())
            });
        }
        return product; // Return the populated list of customers
    }



    public async Task<Product> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Product(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Product>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Product product)
    {
        return httpClient.PostAsJsonAsync(url, product);
    }


    public Task<HttpResponseMessage> Put(Product product)
    {
        return httpClient.PutAsJsonAsync(url, product);
    }


    public Task<HttpResponseMessage> Del(Product product)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(product) // Создание JSON-содержимого из объекта
        });
    }


}
