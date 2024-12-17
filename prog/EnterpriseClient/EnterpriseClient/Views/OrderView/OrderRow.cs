using EnterpriseClient.Models;
using EnterpriseClient.Views.MaterialView;
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

public partial class OrderRow : UserControl
{
    private OrderControl mainController;
    private Order order;

    public OrderRow(OrderControl maincontroller, Order order)
    {
        this.mainController = maincontroller;
        this.order = order;

        InitializeComponent();
        InitializeData();

        
        groupBox1.Click += change_selected;
        groupBox2.Click += change_selected;
        label1.Click += change_selected;
        label2.Click += change_selected;
        label5.Click += change_selected;
        label6.Click += change_selected;
        label7.Click += change_selected;
        label8.Click += change_selected;
        label9.Click += change_selected;
        label10.Click += change_selected;
    }

    private void Label1_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private async void InitializeData()
    {
        label2.Text = order.Date.ToString("dd MM yyyy");

        Customer customer = await mainController.customerController.GetById(order.Id_Customer);
        
        label6.Text = customer.Name.ToString();
        label8.Text = customer.Surname.ToString();
        label10.Text = customer.Phone.ToString();
    }





    private void change_selected(object sender, EventArgs e)
    {
        mainController.choisedOrder = order;
    }
}
