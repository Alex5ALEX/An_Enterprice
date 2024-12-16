using EnterpriseClient.Logic;
using EnterpriseClient.Models;
using EnterpriseClient.Views.EnterpriseView;
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

public partial class ProviderEdit : UserControl
{
    private ProviderControl mainController;
    private Provider provider;
    private Validation validation;

    public ProviderEdit(ProviderControl mainController, Provider provider)
    {
        this.mainController = mainController;
        this.provider = provider;

        validation = new Validation();

        InitializeComponent();
        InitializeData();

        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;

    }



    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    private async void InitializeData()
    {
        textBoxCompany.Text = provider.Company;
        textBoxContactPerson.Text = provider.ContactPerson;
        textBoxPhone.Text = provider.Phone;
        textBoxEmail.Text = provider.Email;
        textBoxAddres.Text = provider.Address;
    }



    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxCompany.Text) ||
        string.IsNullOrWhiteSpace(textBoxContactPerson.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        provider.Company = textBoxCompany.Text;
        provider.ContactPerson = textBoxContactPerson.Text;
        provider.Phone = textBoxPhone.Text;
        provider.Email = textBoxEmail.Text;
        provider.Address = textBoxAddres.Text;
        


        var response = mainController.providerController.Put(provider);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.providerController.Del(provider);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
