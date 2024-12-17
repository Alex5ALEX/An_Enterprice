using EnterpriseClient.Models;
using EnterpriseClient.Views.RowsView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.OrderView;

public partial class OrderEdit : UserControl
{
    private OrderControl mainController;

    private Order order;

    private List<ProductShortRow> productRow { get; set; } = [];
    private List<CustomerShortRow> customerRow { get; set; } = [];
    private List<OrderCompaund> orderCompaundRow { get; set; } = [];


    public Customer choisedCustomer { get; set; } = new Customer() { Id = Guid.Empty };


    public OrderEdit(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    private async void InitData()
    {
        dateTimePicker.Value = order.Date;
        richTextBox1.Text = order.Description;

        choisedCustomer = await mainController.customerController.GetById(order.Id_Customer);
        ShowCustomer();

        InitProducts();
        InitCustomers();
    }



    public async void InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAll();

        foreach (var product in products)
        {
            var token = new ProductShortRow(product);
            flowLayoutPanelProducts.Controls.Add(token);
            productRow.Add(token);
        }

        orderCompaundRow = await mainController.orderCompaundController.GetByIdOrder(order.Id);

        foreach (var item in orderCompaundRow)
        {
            foreach (var token in productRow)
            {
                if (token.Product.Id == item.Id_Product)
                {
                    token.SetQuantity(item.Quantity);
                }

            }
        }
    }



    public async void InitCustomers()
    {
        flowLayoutPanelCustomer.Controls.Clear();
        customerRow.Clear();

        var customers = await mainController.customerController.GetAll();


        foreach (var customer in customers)
        {
            var token = new CustomerShortRow(this, customer);
            customerRow.Add(token);
            flowLayoutPanelCustomer.Controls.Add(token);
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



    private async void Edit(object? sender, EventArgs e)
    {


        order.Description = richTextBox1.Text;
        order.Date = dateTimePicker.Value;
        order.Id_Customer = choisedCustomer.Id;


        mainController.orderController.Put(order);

        foreach (var item in productRow)//List<ProductAddRowControl>
        {
            bool temp1 = false;

            foreach (var temp in orderCompaundRow)//List<SupplyCompaund>
            {

                if (item.Product.Id == temp.Id_Product)
                {

                    if (item.GetQuantity() != temp.Quantity)
                    {
                        temp.Quantity = item.GetQuantity();
                        mainController.orderCompaundController.Put(temp);
                    }
                }
            }
            if (temp1 == false)
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

        }


        InitData();
        mainController.UpdateData();

    }



    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.orderController.Del(order);

        foreach (var item in orderCompaundRow)
        {
            mainController.orderCompaundController.Del(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }


}
