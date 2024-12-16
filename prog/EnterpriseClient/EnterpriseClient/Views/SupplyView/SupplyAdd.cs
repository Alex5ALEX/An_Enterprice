using EnterpriseClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.SupplyView;

public partial class SupplyAdd : UserControl
{
    private OrderControl mainController;
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<CustomerShortRow> customerRow { get; set; } = [];
    private List<EmployeeShortRow> employeeRow { get; set; } = [];

    public Customer choisedCustomer { get; set; } = new Customer() { Id = Guid.Empty };
    public Employee choisedEmployee { get; set; } = new Employee() { Id = Guid.Empty };



    public OrderAddController(OrderControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    //memu
    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    //data
    public async void InitData()
    {
        InitProducts();
        InitCustomers();
        InitEmployee();
    }


    public async void InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAllProductsAsync();

        foreach (var item in products)
        {
            var token = new ProductShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProducts.Controls.Add(token);
        }

    }

    public async void InitCustomers()
    {
        flowLayoutPanelCustomers.Controls.Clear();
        customerRow.Clear();

        var customers = await mainController.customerController.GetAllCustomersAsync();

        foreach (var item in customers)
        {
            var token = new CustomerShortRow(this, item);
            customerRow.Add(token);
            flowLayoutPanelCustomers.Controls.Add(token);
        }
    }

    public async void InitEmployee()
    {
        flowLayoutPanelEmployers.Controls.Clear();
        employeeRow.Clear();

        var employee = await mainController.employeeController.GetAllEmployersAsync();

        foreach (var item in employee)
        {
            var token = new EmployeeShortRow(this, item);
            employeeRow.Add(token);
            flowLayoutPanelEmployers.Controls.Add(token);
        }
    }



    //action

    public void ShowCustomer()
    {
        label1.Text = choisedCustomer.Name;
        label2.Text = choisedCustomer.Surname;
        label3.Text = choisedCustomer.Phone;
        label4.Text = choisedCustomer.Email;
    }

    public void ShowEmployee()
    {
        label8.Text = choisedEmployee.Name;
        label7.Text = choisedEmployee.Surname;
        label6.Text = choisedEmployee.Phone;
        label5.Text = choisedEmployee.Email;
    }




    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (choisedCustomer.Id == Guid.Empty ||
        choisedEmployee.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите работника/покупателя.");
            return;
        }


        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker.Value,
            Id_Customer = choisedCustomer.Id,
            Id_Employee = choisedEmployee.Id
        };

        var response = await mainController.orderController.PostOrder(order);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var item in productRow)
        {
            if (item.GetQuantity() > 0)
            {
                OrderCompaund compaund = new OrderCompaund()
                {
                    Id_Order = order.Id,
                    Id_Product = item.product.Id,
                    Quantity = item.GetQuantity()
                };


                var responseCompaund = await mainController.orderCompaundController.PostOrderCompaund(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }

            }
        }


        dateTimePicker.Value = DateTime.Now;
        choisedCustomer = new Customer();
        choisedEmployee = new Employee();
        ShowCustomer();
        ShowEmployee();
        InitData();
        mainController.UpdateData();



    }

}


