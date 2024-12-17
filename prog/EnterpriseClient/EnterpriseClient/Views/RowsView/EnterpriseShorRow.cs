using EnterpriseClient.Models;
using EnterpriseClient.Views.MaterialView;
using EnterpriseClient.Views.ProductView;
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

public partial class EnterpriseShorRow : UserControl
{
    public Enterprise enterprise;

    private ProductAdd productAdd;

    private ProductEdit productEdit;

    public EnterpriseShorRow(ProductAdd productAdd, Enterprise enterprise)
    {
        this.enterprise = enterprise;
        this.productAdd = productAdd;

        InitializeComponent();
        InitData();

        groupBox1.Click += cohise_productAdd;
        label1.Click += cohise_productAdd;
        label2.Click += cohise_productAdd;
        label3.Click += cohise_productAdd;
        label4.Click += cohise_productAdd;
        label5.Click += cohise_productAdd;
        label6.Click += cohise_productAdd;
        label7.Click += cohise_productAdd;
        label8.Click += cohise_productAdd;
        label9.Click += cohise_productAdd;
        label10.Click += cohise_productAdd;
    }


    public EnterpriseShorRow(ProductEdit productEdit, Enterprise enterprise)
    {
        this.enterprise = enterprise;
        this.productEdit = productEdit;

        InitializeComponent();
        InitData();

        groupBox1.Click += cohise_productEdit;
        label1.Click += cohise_productEdit;
        label2.Click += cohise_productEdit;
        label3.Click += cohise_productEdit;
        label4.Click += cohise_productEdit;
        label5.Click += cohise_productEdit;
        label6.Click += cohise_productEdit;
        label7.Click += cohise_productEdit;
        label8.Click += cohise_productEdit;
        label9.Click += cohise_productEdit;
        label10.Click += cohise_productEdit;
    }





    private void cohise_productAdd(object sender, EventArgs e)
    {
        productAdd.choisedEnterprise = enterprise;
        productAdd.ShowEnterprise();
    }

    private void cohise_productEdit(object sender, EventArgs e)
    {
        productEdit.choisedEnterprise = enterprise;
        productEdit.ShowEnterprise();
    }


    private void InitData()
    {
        label2.Text = enterprise.Company;
        label3.Text = enterprise.ContactPerson;
        label5.Text = enterprise.Phone;
        label7.Text = enterprise.Email;
        label9.Text = enterprise.Address;
    }
}
