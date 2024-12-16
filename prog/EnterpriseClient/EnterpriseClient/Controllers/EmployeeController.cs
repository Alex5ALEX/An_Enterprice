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

public class EmployeeController
{
    private HttpClient httpClient;
    private readonly Uri url;


    public EmployeeController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7004/api/employee");

    }



    public async Task<List<Employee>> GetAll()
    {
        List<Employee> employee = new List<Employee>(); // Initialize the list of customers
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
            employee.Add(new Employee()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Name = token["name"].ToString(),
                Surname = token["surname"].ToString(),
                Jobtitle = token["jobtitle"].ToString(),
                Phone = token["phone"].ToString(),
                Email = token["email"].ToString(),
                Address = token["address"].ToString()
            });
        }
        return employee; // Return the populated list of customers
    }



    public async Task<Employee> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode) { return new Employee(); }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Employee>(data);

        return content;
    }





    public Task<HttpResponseMessage> Post(Employee employee)
    {
        return httpClient.PostAsJsonAsync(url, employee);
    }


    public Task<HttpResponseMessage> Put(Employee employee)
    {
        return httpClient.PutAsJsonAsync(url, employee);
    }


    public Task<HttpResponseMessage> Del(Employee employee)
    {
        return httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = url,
            Content = JsonContent.Create(employee) // Создание JSON-содержимого из объекта
        });
    }



}
