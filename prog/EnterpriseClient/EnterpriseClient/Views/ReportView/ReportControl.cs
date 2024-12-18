using EnterpriseClient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.ReportView;

public partial class ReportControl : UserControl
{
    public CustomerController customerController;
    public EmployeeController employeeController;
    public EnterpriseController enterpriseController;
    public OrderController orderController;
    public OrderCompaundController orderCompaundController;
    public ProductController productController;
    public MaterialController materialController;
    public MaterialCompaundController materialCompaundController;
    public ProviderController providerController;
    public SupplyCompaundController supplyCompaundController;
    public SupplyController supplyController;

    private MainForm mainForm;

    public ReportControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitData();


        buttonMenu.Click += CallMenu;
        button1.Click += InitFinanceReport;
        button2.Click += InitQuantityReport;
        button3.Click += HideActionGroupBox;
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }


    private void InitData()
    {
        customerController = new CustomerController(mainForm.httpClient);
        employeeController = new EmployeeController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);
        orderController = new OrderController(mainForm.httpClient);
        productController = new ProductController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        supplyCompaundController = new SupplyCompaundController(mainForm.httpClient);
        supplyController = new SupplyController(mainForm.httpClient);
        materialController = new MaterialController(mainForm.httpClient);
        materialCompaundController = new MaterialCompaundController(mainForm.httpClient);
        enterpriseController = new EnterpriseController(mainForm.httpClient);
    }

    public void HideActionGroupBox(object sender, EventArgs e)
    {
        HideActionGroupBox();
    }


    public void HideActionGroupBox()
    {
        groupBox1.Controls.Clear();
        pictureBox1.Visible = true;
    }


    private void InitFinanceReport(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new FinanceControl(this));
    }


    private void InitQuantityReport(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new StatisticControl(this));
    }

}
