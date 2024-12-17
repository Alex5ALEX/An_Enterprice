using EnterpriseClient.Models;
using EnterpriseClient.Views.RowsView;
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

public partial class ProductEdit : UserControl
{
    private ProductControl mainController;

    private Product product;

    private List<MaterialShortRow> materialRow { get; set; } = [];
    private List<EnterpriseShorRow> enterpriseRow { get; set; } = [];

    private List<MaterialCompaund> materialCompaund { get; set; } = [];

    public Enterprise choisedEnterprise { get; set; } = new Enterprise() { Id = Guid.Empty };

    public ProductEdit(ProductControl mainController, Product product)
    {
        this.mainController = mainController;
        this.product = product;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;

    }


    //memu
    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    //data
    public async void InitData()
    {
        numericUpDown1.Value = (int)product.Weight;
        textBoxName.Text = product.Name;
        textBoxPrice.Text = product.Price.ToString("0.00");


        choisedEnterprise = await mainController.enterpriseController.GetById(product.Id_Enterprise);
        ShowEnterprise();

        InitMaterials();
        InitEnterprise();
    }

    public async void InitMaterials()
    {
        flowLayoutPanelMaterial.Controls.Clear();
        materialRow.Clear();

        var materials = await mainController.materialController.GetAll();

        foreach (var material in materials)
        {
            var token = new MaterialShortRow(material);
            token.MaterialLabel();
            flowLayoutPanelMaterial.Controls.Add(token);
            materialRow.Add(token);
        }

        materialCompaund = await mainController.materialComapundController.GetByIdProduct(product.Id);

        foreach (var item in materialCompaund)
        {
            
            foreach (var token in materialRow)
            {
                if (token.Material.Id == item.Id_Material)
                {
                    token.SetQuantity((int)item.Weight);
                }
            
            }
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

    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
            numericUpDown1.Value == 0)
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
        }


        product.Name = textBoxName.Text;
        product.Weight = (double)numericUpDown1.Value;

        decimal price = 0;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }

        product.Price = price;
        product.Id_Enterprise = choisedEnterprise.Id;

        mainController.productController.Put(product);


        foreach (var item in materialRow)//List<ProductAddRowControl>
        {
            bool temp1 = false;

            foreach (var temp in materialCompaund)//List<SupplyCompaund>
            {

                if (item.Material.Id == temp.Id_Material)
                {

                    if (item.GetQuantity() != temp.Weight)
                    {
                        temp.Weight = item.GetQuantity();
                        mainController.materialComapundController.Put(temp);
                    }
                }
            }
            if (temp1 == false)
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

        }


        InitData();
        mainController.UpdateData();

    }



    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.productController.Del(product);

        foreach (var item in materialCompaund)
        {
            mainController.materialComapundController.Del(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
