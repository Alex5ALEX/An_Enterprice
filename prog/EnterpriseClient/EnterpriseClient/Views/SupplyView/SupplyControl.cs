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

namespace EnterpriseClient.Views.SupplyView;

public partial class SupplyControl : UserControl
{
    private MainForm mainForm;
    public SupplyController supplyController;
    public ProviderController providerController;
    private SupplyAdd supplyAdd;

    public List<Supply> supplies { get; set; }

    public Supply choisedSupply { get; set; }



    public SupplyControl(MainForm mainForm)
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
        choisedSupply = new Supply();
        supplyController = new SupplyController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        supplyAdd = new SupplyAdd(this);
    }


    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        supplies = await supplyController.GetAll();

        foreach (var supply in supplies)
        {
            flowLayoutPanel1.Controls.Add(new SupplyRow(this, supply));
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
        groupBoxAction.Controls.Add(supplyAdd);
    }

    private void Edit(object sender, EventArgs e)
    {
        if (choisedSupply.Id == Guid.Empty) { return; }

        //pictureBox.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new SupplyEdit(this, choisedSupply));
    }

}