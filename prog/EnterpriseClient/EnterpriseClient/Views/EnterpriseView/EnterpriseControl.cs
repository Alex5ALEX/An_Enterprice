using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnterpriseClient.Controllers;
using EnterpriseClient.Models;



namespace EnterpriseClient.Views.EnterpriseView;

public partial class EnterpriseControl : UserControl
{
    private MainForm mainForm;
    public EnterpriseController enterpriseController;
    private EnterpriseAdd enterpriseAdd;

    public List<Enterprise> enterprises {  get; set; }

    public Enterprise choisedEnterprise { get; set; }



    public EnterpriseControl(MainForm mainForm)
    {
        this.mainForm = mainForm;
    
        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuControl;

        buttonAdd.Click += AddNew;
        buttonEdit.Click += Edit;
    }



    public void InitializeData()
    {
        choisedEnterprise = new Enterprise();
        enterpriseController = new EnterpriseController(mainForm.httpClient);
        enterpriseAdd = new EnterpriseAdd(this);
    }


    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        enterprises = await enterpriseController.GetAll();

        foreach (Enterprise enterprise in enterprises) 
        {
            flowLayoutPanel1.Controls.Add(new EnterpriseRow(this, enterprise));
        }
    }

    public void HideActionGroupBox()
    {
        pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object sender,EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(enterpriseAdd);
    }

    private void Edit(object sender, EventArgs e)
    {
        if (choisedEnterprise.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new EnterpriseEdit(this, choisedEnterprise));
    }


}
