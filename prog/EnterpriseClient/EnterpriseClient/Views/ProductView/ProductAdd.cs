using EnterpriseClient.Logic;
using EnterpriseClient.Models;
using EnterpriseClient.Views.RowsView;
using EnterpriseClient.Views.MaterialView;
using EnterpriseClient.Views.ProviderView;
using EnterpriseClient.Views.RowsView;
using EnterpriseClient.Views.SupplyView;
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

namespace EnterpriseClient.Views.ProductView;

public partial class ProductAdd : UserControl
{
    private ProductControl mainController;

    private List<MaterialShortRow> materialRow { get; set; } = [];
    private List<EnterpriseShorRow> enterpriseRow { get; set; } = [];


    public Enterprise choisedEnterprise { get; set; } = new Enterprise() { Id = Guid.Empty };

    public ProductAdd(ProductControl mainController)
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
        InitMaterials();
        InitEnterprise();
    }

    public async void InitMaterials()
    {
        flowLayoutPanelMaterial.Controls.Clear();
        materialRow.Clear();

        var materials = await mainController.materialController.GetAll();

        foreach (var item in materials)
        {
            var token = new MaterialShortRow(item);
            token.MaterialLabel();
            materialRow.Add(token);
            flowLayoutPanelMaterial.Controls.Add(token);
        }
    }

    public async void InitEnterprise()
    {
        flowLayoutPanelEnterprise.Controls.Clear();
        enterpriseRow.Clear();

        var enterprise = await mainController.enterpriseController.GetAll();

        foreach (var item in enterprise)
        {
            var token = new EnterpriseShorRow(this, item);
            enterpriseRow.Add(token);
            flowLayoutPanelEnterprise.Controls.Add(token);
        }
    }


    //action

    public void ShowEnterprise()
    {
        label11.Text = choisedEnterprise.Company;
        label3.Text = choisedEnterprise.ContactPerson;
        label5.Text = choisedEnterprise.Phone;
        label7.Text = choisedEnterprise.Email;
        label9.Text = choisedEnterprise.Address;
    }

    private async void AddItem(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
            numericUpDown1.Value == 0)
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
        }

        decimal price = 0;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }

        Product product = new Product()
        {
            Id = Guid.NewGuid(),
            Name = textBoxName.Text,
            Price = price,
            Weight = double.Parse(numericUpDown1.Value.ToString()),
            Id_Enterprise = choisedEnterprise.Id
        };



        var response = await mainController.productController.Post(product);


        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var item in materialRow)
        {
            if (item.GetQuantity() > 0)
            {
                MaterialCompaund compaund = new MaterialCompaund()
                {
                    Id_Product = product.Id,
                    Id_Material = item.Material.Id,
                    Weight = item.GetQuantity()
                };


                var responseCompaund = await mainController.materialComapundController.Post(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }

            }
        }


        textBoxName.Text = "";
        textBoxPrice.Text = "";
        numericUpDown1.Value = 0;
        choisedEnterprise = new Enterprise();
        ShowEnterprise();
        InitData();
        mainController.UpdateData();

    }
}
