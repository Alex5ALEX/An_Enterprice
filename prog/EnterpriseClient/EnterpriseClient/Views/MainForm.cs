using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EnterpriseClient.Views.CustomerView;
using EnterpriseClient.Views.EmployeeView;
using EnterpriseClient.Views.EnterpriseView;
using EnterpriseClient.Views.ProviderView;
using EnterpriseClient.Views.MaterialView;
using EnterpriseClient.Views.SupplyView;

namespace EnterpriseClient.Views;

public partial class MainForm : Form
{
    public HttpClient httpClient { get; set; }

    CustomerControl customerControl;
    EmployeeControl employeeControl;
    EnterpriseControl enterpriseControl;
    ProviderControl providerControl;
    MaterialControl materialControl;
    SupplyControl supplyControl;
    /*
    OrderControl orderControl;
    ProductControl productControl;
    ProviderControl providerControl;
    SupplyControl supplyControl;
    ReportControl reportControl;*/


    public MainForm()
    {
        InitializeComponent();
        InitializeData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        MenuButton.Click += ShowMenuControl;
        groupBoxMenu.Click += HideMenuControl;
        labelMenu.Click += HideMenuControl;

        optionCustomer.Click += InitCustomerControl;
        optionEmployee.Click += InitEmployeeControl;
        optionEnterprise.Click += InitEnterpriseControl;
        optionProvider.Click += InitProviderControl;
        optionMaterial.Click += InitMaterialControl;
        optionSupply.Click += InitSupplyControl;

        /*
        orderOption.Click += InitOrderControl;
        productOption.Click += InitProductControl;
        providerOption.Click += InitProviderControl;
        supplyOption.Click += InitSupplyControl;
        ReportOption.Click += InitReportControl;*/
    }



    private void InitializeData()
    {
        httpClient = new HttpClient();

        customerControl = new CustomerControl(this);
        employeeControl = new EmployeeControl(this);
        enterpriseControl = new EnterpriseControl(this);
        providerControl = new ProviderControl(this);
        materialControl = new MaterialControl(this);
        supplyControl = new SupplyControl(this);

        /*orderControl = new OrderControl(this);
        productControl = new ProductControl(this);
        providerControl = new ProviderControl(this);
        supplyControl = new SupplyControl(this);
        reportControl = new ReportControl(this);*/

        Controls.Add(customerControl);
        Controls.Add(employeeControl);
        Controls.Add(enterpriseControl);
        Controls.Add(providerControl);
        Controls.Add(materialControl);
        Controls.Add(supplyControl);
        /*Controls.Add(orderControl);
        Controls.Add(productControl);
        Controls.Add(providerControl);
        Controls.Add(supplyControl);
        Controls.Add(reportControl);*/

        HideMainControls();
        HideMenuControl();
    }


    //menu options
    private void InitCustomerControl(object sender, EventArgs e)
    {
        HideAllControls();
        customerControl.Visible = true;
    }
    
    private void InitEmployeeControl(object sender, EventArgs e)
    {
        HideAllControls();
        employeeControl.Visible = true;
    }

    private void InitEnterpriseControl(object sender, EventArgs e)
    {
        HideAllControls();
        enterpriseControl.Visible = true;
    }


    private void InitProviderControl(object sender, EventArgs e)
    {
        HideAllControls();
        providerControl.Visible = true; 
    }

    private void InitMaterialControl(object sender, EventArgs e)
    {
        HideAllControls();
        materialControl.Visible = true;
    }


    private void InitSupplyControl(object sender, EventArgs e)
    {
        HideAllControls();
        supplyControl.Visible = true;
    }

    /*
    private void InitOrderControl(object sender, EventArgs e)
    {
        HideAllControls();
        orderControl.Visible = true;
    }

    private void InitProductControl(object sender, EventArgs e)
    {
        HideAllControls();
        productControl.Visible = true;
    }


    private void InitReportControl(object sender, EventArgs e)
    {
        HideAllControls();
        reportControl.Visible = true;
    }
    */
    //controls



    private void HideAllControls()
    {
        HideMenuControl();
        MenuButton.Visible = false;
        labelHello.Visible = false;
        pictureHello.Visible = false;


        HideMainControls();
    }


    private void HideMainControls()
    {
        customerControl.Visible = false;
        employeeControl.Visible = false;
        enterpriseControl.Visible = false;
        providerControl.Visible = false;
        materialControl.Visible = false;
        supplyControl.Visible= false;
        /*
        orderControl.Visible = false;
        productControl.Visible = false;
        providerControl.Visible = false;
        reportControl.Visible = false;*/
    }



    //menu
    public void ShowMenuControl(object sender, EventArgs e)
    {
        ShowMenuControl();
    }

    public void HideMenuControl(object sender, EventArgs e)
    {
        HideMenuControl();
    }

    public void ShowMenuControl()
    {
        //groupBoxMenu.BringToFront();
        groupBoxMenu.Visible = true;
    }

    public void HideMenuControl()
    {
        groupBoxMenu.Visible = false;
    }


    //exit
    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}

