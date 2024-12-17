using EnterpriseClient.Models;
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

using EnterpriseClient.Views.RowsView;

namespace EnterpriseClient.Views.SupplyView;

public partial class SupplyAdd : UserControl
{
    private SupplyControl mainController;

    private List<MaterialShortRow> materialRow { get; set; } = [];
    private List<ProviderShortRow> providerRow { get; set; } = [];


    public Provider choisedProvider { get; set; } = new Provider() { Id = Guid.Empty};



    public SupplyAdd(SupplyControl mainController)
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
        InitProviders();
    }

    public async void InitMaterials()
    {
        flowLayoutPanelMaterial.Controls.Clear();
        materialRow.Clear();

        var materials = await mainController.materialController.GetAll();

        foreach(var item in materials)
        {
            var token = new MaterialShortRow(item);
            token.SupplyLabel();
            materialRow.Add(token);
            flowLayoutPanelMaterial.Controls.Add(token);
        }

    }

    public async void InitProviders()
    {
        flowLayoutPanelProvider.Controls.Clear();
        providerRow.Clear();

        var providers = await mainController.providerController.GetAll();

        foreach(var item in providers)
        {
            var token = new ProviderShortRow(this, item);
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
        label5.Text = choisedProvider.Address;
    }


    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (choisedProvider.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите работника/покупателя.");
            return;
        }

        Supply supply = new Supply()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker.Value,
            Description = richTextBox1.Text,
            Id_Provider = choisedProvider.Id
        };

        var response = await mainController.supplyController.Post(supply);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var item in materialRow)
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


        dateTimePicker.Value = DateTime.Now;
        choisedProvider = new Provider();
        richTextBox1.Text = ""; 
        ShowProvider();
        InitData();
        mainController.UpdateData();
    }

}


