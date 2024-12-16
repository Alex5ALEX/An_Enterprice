using EnterpriseClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Json;

namespace EnterpriseClient.Controllers;

public class CustomerController
{

    private HttpClient httpClient;
    private readonly Uri url;


    public CustomerController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/customer");

    }



    public async Task<List<Customer>> GetAll()
    {
        List<Customer> customers = new List<Customer>(); // Initialize the list of customers
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

        foreach (var customer in contentArray)
        {
            customers.Add(new Customer()
            {
                Id = Guid.Parse(customer["id"].ToString()),
                Name = customer["name"].ToString(),
                Surname = customer["surname"].ToString(),
                Phone = customer["phone"].ToString(),
                Email = customer["email"].ToString(),
                Address = customer["address"].ToString()
            });
        }
        return customers; // Return the populated list of customers
    }



    public async Task<Customer> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");


        if (!response.IsSuccessStatusCode){return new Customer();        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Customer>(data);

        return content;
    }





    public  Task<HttpResponseMessage> Post(Customer customer)
    {
        return httpClient.PostAsJsonAsync(url, customer);
    }


    public Task<HttpResponseMessage> Put(Customer customer)
    {
        return httpClient.PutAsJsonAsync(url, customer);
    }


    public Task<HttpResponseMessage> Del(Customer customer)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(customer) // Создание JSON-содержимого из объекта
        });
    }

}
