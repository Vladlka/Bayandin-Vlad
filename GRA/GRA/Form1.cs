﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GRA
{
    /*Функции
     * (x^2 + x + 1)^(1/5) Math.Pow(x * x + x + 1, 1.0 / 5.0)
     * ln^2 * (|x+5|)^(1/2) Math.Pow(Math.Log(Math.Abs(x + 5)), 2) * Math.Pow(Math.Abs(x + 5), 0.5)
     * sin(x^2) + x^0,25 Math.Sin(Math.Pow(x, 2)) + Math.Pow(x, 0.25);
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = -3.9, b = 3.8, h = 0.15; // initial data

            // Clearing previous points
            this.chart1.Series.Clear();

            // the first function
            Series series1 = new Series("Function 1");
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 3;
            this.chart1.Series.Add(series1);

            double x1 = a;
            while (x1 <= b)
            {
                double y1 = Math.Pow(x1*x1 + x1 + 1, 0.2);
                series1.Points.AddXY(x1, y1);
                x1 += h;
            }

            // the second function
            Series series2 = new Series("Function 2");
            series2.ChartType = SeriesChartType.Line; 
            series2.BorderWidth = 3;
            this.chart1.Series.Add(series2);

            double x2 = a;
            while (x2 <= b)
            {
                double y2 = Math.Pow(Math.Log(Math.Abs(Math.Sqrt(x2 + 5))), 2);
                series2.Points.AddXY(x2, y2);
                x2 += h;
            }
            // the third function
            Series series3 = new Series("Function 3");
            series3.ChartType = SeriesChartType.Line; // 
            series3.BorderWidth = 3;
            this.chart1.Series.Add(series3);

            double x3 = a;
            while (x3 <= b)
            {
                double y3 = Math.Sin(Math.Pow(x3, 2)) + Math.Pow(x3, 0.25);
                series3.Points.AddXY(x3, y3);
                x3 += h;
            }
        }
    }
}
