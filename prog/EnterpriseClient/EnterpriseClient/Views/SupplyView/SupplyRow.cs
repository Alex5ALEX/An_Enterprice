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

namespace EnterpriseClient.Views.SupplyView;

public partial class SupplyRow : UserControl
{
    private SupplyControl mainController;
    private Supply supply;

    public SupplyRow(SupplyControl maincontroller, Supply supply)
    {
        this.mainController = maincontroller;
        this.supply = supply;

        InitializeComponent();
        InitializeData();

        
        groupBox1.Click += change_selected;
        groupBox2.Click += change_selected;
        label1.Click += change_selected;
        label2.Click += change_selected;
        label5.Click += change_selected;
        label6.Click += change_selected;
        label7.Click += change_selected;
        label8.Click += change_selected;
        label9.Click += change_selected;
        label10.Click += change_selected;
    }

    private void Label1_Click(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private async void InitializeData()
    {
        label2.Text = supply.Date.ToString("dd MM yyyy");


        
        
        Provider provider = await mainController.providerController.GetById(supply.Id_Provider);

        label6.Text = provider.Company.ToString();
        label8.Text = provider.ContactPerson.ToString();
        label10.Text = provider.Phone.ToString();
    }





    private void change_selected(object sender, EventArgs e)
    {
        mainController.choisedSupply = supply;
    }
}
