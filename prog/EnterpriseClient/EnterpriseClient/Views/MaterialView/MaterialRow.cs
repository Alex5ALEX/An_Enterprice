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

public partial class MaterialRow : UserControl
{
    private MaterialControl mainController;
    private Material material;

    public MaterialRow(MaterialControl maincontroller, Material material)
    {
        this.mainController = maincontroller;
        this.material = material;

        InitializeComponent();
        InitializeData();

        labelName.Click += change_selected;
        labelNameText.Click += change_selected;
        labelType.Click += change_selected;
        labelTypeText.Click += change_selected;
        labelDescription.Click += change_selected;
        labelDescriptionText.Click += change_selected;
        groupBox1.Click += change_selected;
    }

    private void InitializeData()
    {
        labelNameText.Text = material.Name;
        labelTypeText.Text = material.Type;
        

        if (material.Description.Length > 80)
        {
            labelDescriptionText.Text = material.Description.Substring(0, 80) + "...";
        }
        else
        {
            labelDescriptionText.Text = material.Description;
        }
    }

    private void change_selected(object sender, EventArgs e)
    {
        mainController.choisedMaterial = material;
    }
}
