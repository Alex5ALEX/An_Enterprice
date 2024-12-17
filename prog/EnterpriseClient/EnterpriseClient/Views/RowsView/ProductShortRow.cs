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

namespace EnterpriseClient.Views.RowsView;

public partial class ProductShortRow : UserControl
{
    public Product Product;


    public ProductShortRow(Product Product)
    {
        this.Product = Product;

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




    private void InitData()
    {
        label2.Text = Product.Name;
        label4.Text = Product.Price.ToString("0.00");
    }
}
