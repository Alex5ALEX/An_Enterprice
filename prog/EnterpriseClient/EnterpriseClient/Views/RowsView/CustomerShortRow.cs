using EnterpriseClient.Models;
using EnterpriseClient.Views.OrderView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.RowsView;

public partial class CustomerShortRow : UserControl
{
    public Customer customer;

    private OrderAdd orderAdd;

    private OrderEdit orderEdit;

    public CustomerShortRow(OrderAdd orderAdd, Customer customer)
    {
        this.customer = customer;
        this.orderAdd = orderAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += cohise_supplyAdd;
        label1.Click += cohise_supplyAdd;
        label2.Click += cohise_supplyAdd;
        label3.Click += cohise_supplyAdd;
        label4.Click += cohise_supplyAdd;
        label5.Click += cohise_supplyAdd;
        label6.Click += cohise_supplyAdd;
        label7.Click += cohise_supplyAdd;
        label8.Click += cohise_supplyAdd;
        label9.Click += cohise_supplyAdd;
        label10.Click += cohise_supplyAdd;
    }


    public CustomerShortRow(OrderEdit orderEdit, Customer customer)
    {
        this.customer = customer;
        this.orderEdit = orderEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += cohise_supplyEdit;
        label1.Click += cohise_supplyEdit;
        label2.Click += cohise_supplyEdit;
        label3.Click += cohise_supplyEdit;
        label4.Click += cohise_supplyEdit;
        label5.Click += cohise_supplyEdit;
        label6.Click += cohise_supplyEdit;
        label7.Click += cohise_supplyEdit;
        label8.Click += cohise_supplyEdit;
        label9.Click += cohise_supplyEdit;
        label10.Click += cohise_supplyEdit;
    }





    private void cohise_supplyAdd(object sender, EventArgs e)
    {
        orderAdd.choisedCustomer = customer;
        orderAdd.ShowCustomer();
    }

    private void cohise_supplyEdit(object sender, EventArgs e)
    {
        orderEdit.choisedCustomer = customer;
        orderEdit.ShowCustomer();
    }


    private void InitData()
    {
        label2.Text = customer.Name;
        label3.Text = customer.Surname;
        label5.Text = customer.Phone;
        label7.Text = customer.Email;
        label9.Text = customer.Address;
    }
}
