using EnterpriseClient.Models;
using EnterpriseClient.Views.SupplyView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EnterpriseClient.Views.ProductView;

public partial class ProductRow : UserControl
{
    private ProductControl mainController;
    private Product product;

    public ProductRow(ProductControl maincontroller, Product product)
    {
        this.mainController = maincontroller;
        this.product = product;

        InitializeComponent();
        InitializeData();


        groupBox1.Click += change_selected;
        label1.Click += change_selected;
        label2.Click += change_selected;
        label5.Click += change_selected;
        label6.Click += change_selected;
        label7.Click += change_selected;
        label8.Click += change_selected;
    }


    private async void InitializeData()
    {
        label2.Text = product.Name;
        label6.Text = product.Price.ToString("0.00");
        label8.Text = product.Weight.ToString();
        
    }





    private void change_selected(object sender, EventArgs e)
    {
        mainController.choisedProduct = product;
    }


}
