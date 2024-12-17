using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseClient.Views.ReportView;

public partial class StatisticControl : UserControl
{
    private ReportControl mainController;

    public StatisticControl(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    }


    private async void InitData()
    {
        InitLayout();

        label2.Text = (await mainController.customerController.GetAll()).Count.ToString();
        label3.Text = (await mainController.employeeController.GetAll()).Count.ToString();
        label5.Text = (await mainController.providerController.GetAll()).Count.ToString();
        label7.Text = (await mainController.productController.GetAll()).Count.ToString();
        label10.Text = (await mainController.materialController.GetAll()).Count.ToString();
    }

    private async void InitLayout()
    {
        var materials = await mainController.materialController.GetAll();

        foreach (var material in materials) 
        {
            int quantity = 0;
            double minus = 0;

            var suplies = await mainController.supplyCompaundController.GetByIdMaterial(material.Id);

            foreach (var sup in suplies)
            {
                quantity += sup.Quantity;
            }

            var compaund = await mainController.materialCompaundController.GetByIdMaterial(material.Id);

            foreach(var comp in compaund)
            {
                var prod = await mainController.orderCompaundController.GetByIdProduct(comp.Id_Product);
                int num = 0;

                foreach(var token in prod)
                {
                    num += token.Quantity;
                }


                minus += comp.Weight * num;
            }

            quantity -= (int)(minus/1000);


            flowLayoutPanel1.Controls.Add(new MaterialBox(material, quantity));
        }
    }
}
