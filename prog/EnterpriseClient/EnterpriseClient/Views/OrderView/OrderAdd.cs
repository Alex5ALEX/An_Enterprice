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

using EnterpriseClient.Views.RowsView;

namespace EnterpriseClient.Views.OrderView;

public partial class OrderAdd : UserControl
{
    private OrderControl mainController;

    private List<ProductShortRow> productRow { get; set; } = [];
    private List<CustomerShortRow> customerRow { get; set; } = [];


    public Customer choisedCustomer { get; set; } = new Customer() { Id = Guid.Empty};



    public OrderAdd(OrderControl mainController)
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
    }

    public async void InitProducts()
    {
        flowLayoutPanelProduct.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAll();

        foreach(var item in products)
        {
            var token = new ProductShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProduct.Controls.Add(token);
        }

    }

    public async void InitCustomers()
    {
        flowLayoutPanelCustomers.Controls.Clear();
        customerRow.Clear();

        var customers = await mainController.customerController.GetAll();

        foreach(var item in customers)
        {
            var token = new CustomerShortRow(this, item);
            customerRow.Add(token);
            flowLayoutPanelCustomers.Controls.Add(token);
        }
    }


    //action

    public void ShowCustomer()
    {
        label1.Text = choisedCustomer.Name;
        label2.Text = choisedCustomer.Surname;
        label3.Text = choisedCustomer.Phone;
        label4.Text = choisedCustomer.Email;
        label5.Text = choisedCustomer.Address;
    }


    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (choisedCustomer.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите работника/покупателя.");
            return;
        }

        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker.Value,
            Description = richTextBox1.Text,
            Id_Customer = choisedCustomer.Id
        };


        var response = await mainController.orderController.Post(order);

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
                    Id_Product = item.Product.Id,
                    Quantity = item.GetQuantity()
                };

                var responseCompaund = await mainController.orderCompaundController.Post(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }

            }
        }


        dateTimePicker.Value = DateTime.Now;
        choisedCustomer = new Customer();
        richTextBox1.Text = ""; 
        ShowCustomer();
        InitData();
        mainController.UpdateData();
    }

}


