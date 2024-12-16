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

namespace EnterpriseClient.Views.EmployeeView;

public partial class EmployeeRow : UserControl
{
    private EmployeeControl mainController;
    private Employee employee;



    public EmployeeRow(EmployeeControl mainController, Employee employee)
    {
        this.mainController = mainController;
        this.employee = employee;



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
        labelJobtitle.Click += change_selected_Id;
        labelJobtitleText.Click += change_selected_Id;
        labelAddres.Click += change_selected_Id;
        labelAddresText.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelNameText.Text = employee.Name;
        labelSurnameText.Text = employee.Surname;
        labelJobtitleText.Text = employee.Jobtitle;
        labelPhoneText.Text = employee.Phone;
        labelEmailText.Text = employee.Email;
        labelAddresText.Text = employee.Address;
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(employee.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedEmployee = employee;
    }
}
