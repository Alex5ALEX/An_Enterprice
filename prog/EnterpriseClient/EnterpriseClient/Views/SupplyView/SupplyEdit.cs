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

namespace EnterpriseClient.Views.SupplyView;

public partial class SupplyEdit : UserControl
{
    private SupplyControl mainController;

    private Supply supply;

    private List<MaterialShortRow> materialRow { get; set; } = [];
    private List<ProviderShortRow> providerRow { get; set; } = [];
    private List<SupplyCompaund> supplyCompaundRow { get; set; } = [];


    public Provider choisedProvider { get; set; } = new Provider() { Id = Guid.Empty };


    public SupplyEdit(SupplyControl mainController, Supply supply)
    {
        this.mainController = mainController;
        this.supply = supply;

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
        dateTimePicker.Value = supply.Date;
        richTextBox1.Text = supply.Description;

        choisedProvider = await mainController.providerController.GetById(supply.Id_Provider);
        ShowProvider();

        InitMaterials();
        InitProviders();
    }



    public async void InitMaterials()
    {
        flowLayoutPanelMaterial.Controls.Clear();
        materialRow.Clear();

        var materials = await mainController.materialController.GetAll();

        foreach(var material in materials)
        {
            var token = new MaterialShortRow(material);
            token.SupplyLabel();
            flowLayoutPanelMaterial.Controls.Add(token);
            materialRow.Add(token);
        }

        supplyCompaundRow = await mainController.SupplyCompaundController.GetByIdSupply(supply.Id);

        foreach(var item in supplyCompaundRow)
        {
            foreach(var token in materialRow)
            {
                if(token.Material.Id == item.Id_Material)
                {
                    token.SetQuantity(item.Quantity);
                }

            }
        }
    }




    


    public async void InitProviders()
    {
        flowLayoutPanelProvider.Controls.Clear();
        providerRow.Clear();

        var providers = await mainController.providerController.GetAll();


        foreach (var provider in providers)
        {
            var token = new ProviderShortRow(this, provider);
            providerRow.Add(token);
            flowLayoutPanelProvider.Controls.Add(token);
        }

    }






    //action

    public void ShowProvider()
    {
        label1.Text = choisedProvider.Company;
        label2.Text = choisedProvider.ContactPerson;
        label3.Text = choisedProvider.Phone;
        label4.Text = choisedProvider.Email;
    }



    private async void Edit(object? sender, EventArgs e)
    {
        supply.Description = richTextBox1.Text;
        supply.Date = dateTimePicker.Value;
        supply.Id_Provider = choisedProvider.Id;


        mainController.supplyController.Put(supply);

        foreach (var item in materialRow)//List<ProductAddRowControl>
        {
            bool temp1 = false;

            foreach (var temp in supplyCompaundRow)//List<SupplyCompaund>
            {

                if (item.Material.Id == temp.Id_Material)
                {

                    if (item.GetQuantity() != temp.Quantity)
                    {
                        temp.Quantity = item.GetQuantity();
                        mainController.SupplyCompaundController.Put(temp);
                    }
                }
            }
            if (temp1 == false)
            {
                if (item.GetQuantity() > 0)
                {
                    SupplyCompaund compaund = new SupplyCompaund()
                    {
                        Id_Supply = supply.Id,
                        Id_Material = item.Material.Id,
                        Quantity = item.GetQuantity()
                    };


                    var responseCompaund = await mainController.SupplyCompaundController.Post(compaund);

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


        var response = mainController.supplyController.Del(supply);

        foreach (var item in supplyCompaundRow)
        {
            mainController.SupplyCompaundController.Del(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
