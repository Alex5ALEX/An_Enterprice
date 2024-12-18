using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnterpriseClient.Controllers;
using EnterpriseClient.Models;
using EnterpriseClient.Views.CustomerView;


namespace EnterpriseClient.Views.ProviderView;

public partial class ProviderControl : UserControl
{
    private MainForm mainForm;
    public ProviderController providerController;
    private ProviderAdd providerAdd;

    public List<Provider> providers { get; set; }
    public Provider choisedProvider {  get; set; }


    public ProviderControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuControl;

        buttonAdd.Click += AddNew;
        buttonEdit.Click += Edit;
    }


    private void InitializeData()
    {
        choisedProvider = new Provider();
        providerController = new ProviderController(mainForm.httpClient);
        providerAdd = new ProviderAdd(this);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        providers = await providerController.GetAll();

        foreach (var provider in providers)
        {
            flowLayoutPanel1.Controls.Add(new ProviderRow(this, provider));
        }

    }


    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(providerAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedProvider.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ProviderEdit(this, choisedProvider));
    }
}
