using EnterpriseClient.Models;
using EnterpriseClient.Logic; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EnterpriseClient.Views.EnterpriseView;

public partial class EnterpriseAdd : UserControl
{
    private EnterpriseControl mainController;
    private Validation validation;

    public EnterpriseAdd(EnterpriseControl mainController)
    {
        this.mainController = mainController;
        validation = new Validation();

        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;

    }


    private void Back(object sender,EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private void AddItem(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(textBoxAddres.Text)||
            string.IsNullOrWhiteSpace(textBoxCompany.Text)||
            string.IsNullOrWhiteSpace(textBoxContactPerson.Text)||
            string.IsNullOrWhiteSpace(textBoxPhone.Text)|
            string.IsNullOrWhiteSpace(textBoxEmail.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
        }


        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        Enterprise enterprise = new Enterprise()
        { 
            Company = textBoxCompany.Text,
            ContactPerson = textBoxContactPerson.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text,
            Description = richTextBoxDescription.Text
        };

        var response = mainController.enterpriseController.Post(enterprise);

        textBoxCompany.Text = "";
        textBoxContactPerson.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";
        richTextBoxDescription.Text = "";

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

    }
}
