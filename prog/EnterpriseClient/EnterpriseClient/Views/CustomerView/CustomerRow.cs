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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EnterpriseClient.Views.CustomerView;

public partial class CustomerRow : UserControl
{
    private CustomerControl mainController;
    private Customer customer;



    public CustomerRow(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        this.customer = customer;



        InitializeComponent();
        InitializeData();



        groupBox1.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelSurname.Click += change_selected_Id;
        labelSurnameText.Click += change_selected_Id;
        labelPhone.Click += change_selected_Id;
        labelPhoneText.Click += change_selected_Id;
        labelEmail.Click += change_selected_Id;
        labelEmailText.Click += change_selected_Id;
        labelAddres.Click += change_selected_Id;
        labelAddresText.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelNameText.Text = customer.Name;
        labelSurnameText.Text = customer.Surname;
        labelPhoneText.Text = customer.Phone;
        labelEmailText.Text = customer.Email;
        labelAddresText.Text = customer.Address;
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(customer.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedCustomer = customer;
    }
}
