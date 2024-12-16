using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnterpriseClient.Models;


namespace EnterpriseClient.Views.EnterpriseView;

public partial class EnterpriseRow : UserControl
{
    private EnterpriseControl mainController;
    private Enterprise enterprise;

    public EnterpriseRow(EnterpriseControl maincontroller, Enterprise enterprise)
    {
        this.mainController = maincontroller;
        this.enterprise = enterprise;

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
        labelCompanyText.Text = enterprise.Company;
        labelContactPersonText.Text = enterprise.ContactPerson;
        labelPhoneText.Text = enterprise.Phone;
        labelEmailText.Text = enterprise.Email;
        labelAddresText.Text = enterprise.Address;
    }

    private void change_selected(object sender, EventArgs e)
    {
        mainController.choisedEnterprise = enterprise;
    }
}
