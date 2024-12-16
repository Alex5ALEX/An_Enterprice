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

namespace EnterpriseClient.Views.ProviderView;

public partial class ProviderRow : UserControl
{
    private ProviderControl mainController;
    private Provider provider;

    public ProviderRow(ProviderControl maincontroller, Provider provider)
    {
        this.mainController = maincontroller;
        this.provider = provider;

        InitializeComponent();
        InitializeData();

        labelCompany.Click += change_selected;
        labelCompanyText.Click += change_selected;
        labelContactPerson.Click += change_selected;
        labelContactPersonText.Click += change_selected;
        labelPhone.Click += change_selected;
        labelPhoneText.Click += change_selected;
        labelEmail.Click += change_selected;
        labelEmailText.Click += change_selected;
        labelAddresText.Click += change_selected;
        labelAddresText.Click += change_selected;
        groupBox1.Click += change_selected;
    }

    private void InitializeData()
    {
        labelCompanyText.Text = provider.Company;
        labelContactPersonText.Text = provider.ContactPerson;
        labelPhoneText.Text = provider.Phone;
        labelEmailText.Text = provider.Email;
        labelAddresText.Text = provider.Address;
    }

    private void change_selected(object sender, EventArgs e)
    {
        mainController.choisedProvider = provider;
    }
}
