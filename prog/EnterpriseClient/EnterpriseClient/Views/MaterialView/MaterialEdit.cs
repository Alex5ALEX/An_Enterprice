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

namespace EnterpriseClient.Views.MaterialView;

public partial class MaterialEdit : UserControl
{
    private MaterialControl mainController;
    private Material material;
    private Validation validation;

    public MaterialEdit(MaterialControl mainController, Material material)
    {
        this.mainController = mainController;
        this.material = material;

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
        textBoxName.Text = material.Name;
        textBoxType.Text = material.Type;
        richTextBoxDescription.Text = material.Description;
    }



    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text)||
            string.IsNullOrWhiteSpace(textBoxType.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        material.Name = textBoxName.Text;
        material.Type = textBoxType.Text;
        material.Description = richTextBoxDescription.Text;



        var response = mainController.materialController.Put(material);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.materialController.Del(material);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
