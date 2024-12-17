using EnterpriseClient.Views.SupplyView;
using EnterpriseClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.RowsView;

public partial class ProviderShortRow : UserControl
{
    public Provider provider;

    private SupplyAdd supplyAdd;

    private SupplyEdit supplyEdit;

    public ProviderShortRow(SupplyAdd supplyAdd, Provider provider)
    {
        this.provider = provider;
        this.supplyAdd = supplyAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += cohise_supplyAdd;
        label1.Click += cohise_supplyAdd;
        label2.Click += cohise_supplyAdd;
        label3.Click += cohise_supplyAdd;
        label4.Click += cohise_supplyAdd;
        label5.Click += cohise_supplyAdd;
        label6.Click += cohise_supplyAdd;
        label7.Click += cohise_supplyAdd;
        label8.Click += cohise_supplyAdd;
        label9.Click += cohise_supplyAdd;
        label10.Click += cohise_supplyAdd;
    }


    public ProviderShortRow(SupplyEdit supplyEdit, Provider provider)
    {
        this.provider = provider;
        this.supplyEdit = supplyEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += cohise_supplyEdit;
        label1.Click += cohise_supplyEdit;
        label2.Click += cohise_supplyEdit;
        label3.Click += cohise_supplyEdit;
        label4.Click += cohise_supplyEdit;
        label5.Click += cohise_supplyEdit;
        label6.Click += cohise_supplyEdit;
        label7.Click += cohise_supplyEdit;
        label8.Click += cohise_supplyEdit;
        label9.Click += cohise_supplyEdit;
        label10.Click += cohise_supplyEdit;
    }





    private void cohise_supplyAdd(object sender, EventArgs e)
    {
        supplyAdd.choisedProvider = provider;
        supplyAdd.ShowProvider();
    }

    private void cohise_supplyEdit(object sender, EventArgs e)
    {
        supplyEdit.choisedProvider = provider;
        supplyEdit.ShowProvider();
    }


    private void InitData()
    {
        label2.Text = provider.Company;
        label3.Text = provider.ContactPerson;
        label5.Text = provider.Phone;
        label7.Text = provider.Email;
        label9.Text = provider.Address;
    }


}
