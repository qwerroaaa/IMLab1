using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColumnTable()
        { 
            Label StepLabel = new Label();
            tableLayoutPanel1.Controls.Add(StepLabel, i + 1, 0);
            StepLabel.TextAlign = ContentAlignment.MiddleCenter;
            StepLabel.Dock = DockStyle.Fill;
            StepLabel.Text = Math.Round(dt,3).ToString();
            Label DistanceLabel = new Label();
            tableLayoutPanel1.Controls.Add(DistanceLabel, i + 1, 1);
            DistanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            DistanceLabel.Dock = DockStyle.Fill;
            DistanceLabel.Text = Math.Round(x,3).ToString();
            Label HeightLabel = new Label();
            tableLayoutPanel1.Controls.Add(HeightLabel, i + 1, 2);
            HeightLabel.TextAlign = ContentAlignment.MiddleCenter;
            HeightLabel.Dock = DockStyle.Fill;
            HeightLabel.Text = Math.Round(maxY,3).ToString();
            Label SpeedLabel = new Label();
            tableLayoutPanel1.Controls.Add(SpeedLabel, i + 1, 3);
            SpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            SpeedLabel.Dock = DockStyle.Fill;
            SpeedLabel.Text = Math.Round(vx,3).ToString()+" "+ Math.Round(vy, 2).ToString();
        }


        double t, dt, x, y, v0, cosa, sina, S, m, k, vx, vy, maxY;
        int i = 0;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            t = 0;
            x = 0;
            y = Convert.ToDouble(inputHeightBox.Text);
            v0 = Convert.ToDouble(inputSpeedBox.Text);
            double a = Convert.ToDouble(inputAngleBox.Text) * Math.PI / 180;
            cosa = Math.Cos(a);
            sina = Math.Sin(a);
            S = Convert.ToDouble(inputSizeBox.Text);
            m = Convert.ToDouble(inputWeightBox.Text);
            k = 0.5 * C * rho * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;
            dt = (double)1 / (double)(10 * (i + 1));
            chart1.Series[0].Points.AddXY(x, y);
            maxY = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            double v = Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            if ((maxY == 0) && ((y + vy * dt) < y))
            {
                maxY = y;
            }
            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                ColumnTable();
                i++;
                if (i == 6)
                    timer1.Stop();
                else
                    t = 0;
                    x = 0;
                    y = Convert.ToDouble(inputHeightBox.Text);
                    v0 = Convert.ToDouble(inputSpeedBox.Text);
                    double a = Convert.ToDouble(inputAngleBox.Text) * Math.PI / 180;
                    cosa = Math.Cos(a);
                    sina = Math.Sin(a);
                    S = Convert.ToDouble(inputSizeBox.Text);
                    m = Convert.ToDouble(inputWeightBox.Text);
                    k = 0.5 * C * rho * S / m;
                    vx = v0 * cosa;
                    vy = v0 * sina;
                    dt = (double)1 / (double)(10 * (i + 1));
                    chart1.Series[0].Points.AddXY(x, y);
                    maxY = 0;
                    timer1.Start();
            }
        }
    }
}
