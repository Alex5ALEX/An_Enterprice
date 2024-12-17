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

namespace EnterpriseClient.Views.ReportView;

public partial class MaterialBox : UserControl
{
    private Material Material;
    private int quant;

    public MaterialBox(Material material, int quant)
    {
        this.Material = material;
        this.quant = quant;

        InitializeComponent();
        InitData();
    }


    private void InitData()
    {
        label2.Text = Material.Name;
        label3.Text = Material.Type;
        label5.Text = quant.ToString();

        if(quant > 0)
        {
            label5.ForeColor = Color.Green;
        }else if(quant == 0)
        {
            label5.ForeColor= Color.Yellow;
        }else
        {
            label5.ForeColor = Color.Red;
        }
    }

}
