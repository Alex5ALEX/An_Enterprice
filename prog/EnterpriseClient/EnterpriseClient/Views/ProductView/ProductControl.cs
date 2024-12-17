using EnterpriseClient.Controllers;
using EnterpriseClient.Models;
using EnterpriseClient.Views.SupplyView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.ProductView;

public partial class ProductControl : UserControl
{
    private MainForm mainForm;

    public ProductController productController;
    public MaterialController materialController;
    public MaterialCompaundController materialComapundController;
    public EnterpriseController enterpriseController;
    

    private ProductAdd productAdd;

    public List<Product> products { get; set; }

    public Product choisedProduct { get; set; }



    public ProductControl(MainForm mainForm)
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
        choisedProduct = new Product();

        productController = new ProductController(mainForm.httpClient);
        materialController = new MaterialController(mainForm.httpClient);
        materialComapundController = new MaterialCompaundController(mainForm.httpClient);
        enterpriseController = new EnterpriseController(mainForm.httpClient);

        productAdd = new ProductAdd(this);
    }


    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        products = await productController.GetAll();

        foreach (var product in products)
        {
            flowLayoutPanel1.Controls.Add(new ProductRow(this, product));
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
        groupBoxAction.Controls.Add(productAdd);
    }

    private void Edit(object sender, EventArgs e)
    {
        if (choisedProduct.Id == Guid.Empty) { return; }

        //pictureBox.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ProductEdit(this, choisedProduct));
    }
}
