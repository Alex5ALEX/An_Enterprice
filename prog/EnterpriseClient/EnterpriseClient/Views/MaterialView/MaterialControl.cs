using EnterpriseClient.Controllers;
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

namespace EnterpriseClient.Views.MaterialView;

public partial class MaterialControl : UserControl
{
    private MainForm mainForm;
    public MaterialController materialController;
    private MaterialAdd materialAdd;

    public List<Material> materials { get; set; }

    public Material choisedMaterial { get; set; }



    public MaterialControl(MainForm mainForm)
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
        choisedMaterial = new Material();
        materialController = new MaterialController(mainForm.httpClient);
        materialAdd = new MaterialAdd(this);
    }


    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        materials = await materialController.GetAll();

        foreach (Material material in materials)
        {
            flowLayoutPanel1.Controls.Add(new MaterialRow(this, material));
        }
    }

    public void HideActionGroupBox()
    {
        pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(materialAdd);
    }

    private void Edit(object sender, EventArgs e)
    {
        if (choisedMaterial.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new MaterialEdit(this, choisedMaterial));
    }


}
