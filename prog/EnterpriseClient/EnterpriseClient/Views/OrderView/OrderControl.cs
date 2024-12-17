using EnterpriseClient.Controllers;
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

public partial class OrderControl : UserControl
{
    private MainForm mainForm;
    public OrderController orderController;
    public OrderCompaundController orderCompaundController;
    public CustomerController customerController;
    public ProductController productController;
    private OrderAdd orderAdd;

    public List<Order> orders { get; set; }

    public Order choisedOrder { get; set; }



    public OrderControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuControl;

        buttonAdd.Click += AddNew;
        buttonEdit.Click += Edit;
    }



    public void InitializeData()
    {
        choisedOrder = new Order();

        orderController = new OrderController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        productController = new ProductController(mainForm.httpClient);


        orderAdd = new OrderAdd(this);
    }


    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        orders = await orderController.GetAll();

        foreach (var order in orders)
        {
            flowLayoutPanel1.Controls.Add(new OrderRow(this, order));
        }
    }

    public void HideActionGroupBox()
    {
        //pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object sender, EventArgs e)
    {
        //pictureBox.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(orderAdd);
    }

    private void Edit(object sender, EventArgs e)
    {
        if (choisedOrder.Id == Guid.Empty) { return; }

        //pictureBox.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new OrderEdit(this, choisedOrder));
    }

}