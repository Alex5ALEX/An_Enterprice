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
using System.Windows.Forms.DataVisualization.Charting;

namespace EnterpriseClient.Views.ReportView;

public partial class FinanceControl : UserControl
{
    
    List<Order> orders { get; set; } = [];
    List<Supply> supplies { get; set; } = [];


    ReportControl mainController;

    public FinanceControl(ReportControl mainController)
    {
        this.mainController = mainController;
        InitializeComponent();
        InitData();
    }

    private async void InitData()
    {
        orders = await mainController.orderController.GetAll();

        decimal profit = 0;
        foreach (Order order in orders)
        {
            List<OrderCompaund> compaunds = await mainController.orderCompaundController.GetByIdOrder(order.Id);

            foreach (OrderCompaund compaund in compaunds)
            {
                Product product = await mainController.productController.GetById(compaund.Id_Product);

                profit += compaund.Quantity * product.Price;
            }
        }

        label2.Text = profit.ToString("0.00");
        label4.Text = orders.Count.ToString();



        label6.Text = (await mainController.supplyController.GetAll()).Count.ToString();
        

        InitPositiveSchedule();
    }



    private async void InitPositiveSchedule()
    {
        chart1.Series.Clear();
        Series series = new Series()
        {
            Name = "TotalCostPerYear",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Column // Столбчатая диаграмма
        };

        Dictionary<int, decimal> quantPerYear = new Dictionary<int, decimal>();

        foreach (Order order in orders)
        {
            decimal profit = 0;
            List<OrderCompaund> compaunds = await mainController.orderCompaundController.GetByIdOrder(order.Id);

            foreach (OrderCompaund compaund in compaunds)
            {
                Product product = await mainController.productController.GetById(compaund.Id_Product);

                profit += compaund.Quantity * product.Price;
            }

            if (quantPerYear.ContainsKey(order.Date.Year))
            {
                quantPerYear[order.Date.Year] += profit;
            }
            else
            {
                quantPerYear.Add(order.Date.Year, profit);
            }

        }

        foreach (var item in quantPerYear)
        {
            series.Points.AddXY(item.Key, item.Value);
        }


        chart1.Series.Add(series);

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Years";
        chart1.ChartAreas[0].AxisY.Title = "Total Profit";

        // Заголовок диаграммы
        chart1.Titles.Add("Profit in Year");


    }




}
