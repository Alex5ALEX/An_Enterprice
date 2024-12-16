using EnterpriseClient.Controllers;
using EnterpriseClient.Logic;
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

namespace EnterpriseClient.Views.EnterpriseView;

public partial class EnterpriseEdit : UserControl
{
    private EnterpriseControl mainController;
    private Enterprise enterprise;
    private Validation validation;

    public EnterpriseEdit(EnterpriseControl mainController, Enterprise enterprise)
    {
        this.mainController = mainController;
        this.enterprise = enterprise;   

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
        textBoxCompany.Text = enterprise.Company;
        textBoxContactPerson.Text = enterprise.ContactPerson;
        textBoxPhone.Text = enterprise.Phone;
        textBoxEmail.Text = enterprise.Email;
        textBoxAddres.Text = enterprise.Address;
        richTextBoxDescription.Text = enterprise.Description;
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


        enterprise.Company = textBoxCompany.Text;
        enterprise.ContactPerson = textBoxContactPerson.Text;
        enterprise.Phone = textBoxPhone.Text;
        enterprise.Email = textBoxEmail.Text;
        enterprise.Address = textBoxAddres.Text;
        enterprise.Description = richTextBoxDescription.Text;


        var response = mainController.enterpriseController.Put(enterprise);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.enterpriseController.Del(enterprise);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }



}
