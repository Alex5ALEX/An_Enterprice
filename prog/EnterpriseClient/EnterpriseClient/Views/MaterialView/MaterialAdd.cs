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

public partial class MaterialAdd : UserControl
{
    private MaterialControl mainController;
    private Validation validation;

    public MaterialAdd(MaterialControl mainController)
    {
        this.mainController = mainController;
        validation = new Validation();

        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;

    }


    private void Back(object sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private void AddItem(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxType.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
        }



        Material material = new Material()
        {
            Name = textBoxName.Text,
            Type = textBoxType.Text,
            Description = richTextBoxDescription.Text
        };

        var response = mainController.materialController.Post(material);

        textBoxName.Text = "";
        textBoxType.Text = "";
        richTextBoxDescription.Text = "";

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

    }
}
