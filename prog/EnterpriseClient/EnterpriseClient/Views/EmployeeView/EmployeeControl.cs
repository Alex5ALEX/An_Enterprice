using EnterpriseClient.Controllers;
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

namespace EnterpriseClient.Views.EmployeeView;

public partial class EmployeeControl : UserControl
{
    private MainForm mainForm;
    public EmployeeController employeeController;
    private EmployeeAdd employeeAdd;

    public List<Employee> employers { get; set; }
    public Employee choisedEmployee { get; set; }




    public EmployeeControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitializeData();
        UpdateData();


        buttonMenu.Click += CallMenu;

        buttonAdd.Click += AddNew;
        buttonEdit.Click += Edit;
    }



    private void InitializeData()
    {
        choisedEmployee = new Employee();
        employeeController = new EmployeeController(mainForm.httpClient);
        employeeAdd = new EmployeeAdd(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }



    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        employers = await employeeController.GetAll();

        foreach (var employee in employers)
        {
            flowLayoutPanel1.Controls.Add(new EmployeeRow(this, employee));
        }

    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(employeeAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedEmployee.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new EmployeeEdit(this, choisedEmployee));
    }
}
