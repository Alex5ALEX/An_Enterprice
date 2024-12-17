using EnterpriseClient.Models;
using EnterpriseClient.Views.SupplyView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.RowsView;

public partial class MaterialShortRow : UserControl
{
    public Material Material;


    public MaterialShortRow(Material Material)
    {
        this.Material = Material;

        InitializeComponent();
        InitData();
    }



    public void SetQuantity(int quantity)
    {
        numericUpDown1.Value = quantity;
    }

    public int GetQuantity()
    {
        return int.Parse(numericUpDown1.Value.ToString());
    }

    public void SupplyLabel()
    {
        label5.Text = "(KiloGram)";
    }

    public void MaterialLabel()
    {
        label5.Text = "(Gram)";
    }


    private void InitData()
    {
        label2.Text = Material.Name;
        label4.Text = Material.Type;
    }
}
