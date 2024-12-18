using EnterpriseClient.Controllers;
using EnterpriseClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.CustomerView;

public partial class CustomerControl : UserControl
{
    private MainForm mainForm;
    public CustomerController customerController;
    private CustomerAdd customerAdd;

    public List<Customer> customers { get; set; }
    public Customer choisedCustomer { get; set; }




    public CustomerControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuControl;

        buttonAdd.Click += AddNew;
        buttonEdit.Click += Edit;
    }



    private void InitializeData()
    {
        choisedCustomer = new Customer();
        customerController = new CustomerController(mainForm.httpClient);
        customerAdd = new CustomerAdd(this);
    }

    
    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        customers = await customerController.GetAll();

        foreach (var customer in customers)
        {
            flowLayoutPanel1.Controls.Add(new CustomerRow(this, customer));
        }

    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(customerAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedCustomer.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new CustomerEdit(this, choisedCustomer));
    }
}
