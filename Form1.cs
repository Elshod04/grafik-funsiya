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
using AlphaVantage.FSharp;
using AlphaVantage.Net.Core.Client;
using AlphaVantage.Net; // Пространство имен для работы с валютами в AlphaVantage




namespace Elshod_kurs_ishi
{
    public partial class Form1 : Form
    {
        private Chart gunachart1;
        private string alphaVantageApiKey = "J6F5ZRV5IVAWVE6K";
        private const string AlphaVantageApiKey = "J6F5ZRV5IVAWVE6K";
        public Form1()
        {
            InitializeComponent();
            Chart dollarChart = new Chart
            {
                Dock = DockStyle.Fill
            };

            var chartArea = new ChartArea("MainArea");
            dollarChart.ChartAreas.Add(chartArea);

            var series = new Series("Dollar Rate")
            {
                ChartType = SeriesChartType.Line
            };

            dollarChart.Series.Add(series);

            this.Controls.Add(dollarChart);

            _ = LoadDollarRateAsync(); // Загрузка данных асинхронно
        }
        double a=0, b=0, c=0, d=0;
        double a1 = 0, b1= 0, c1 = 0, d1 = 0;



        private async Task LoadDollarRateAsync()
        {
            var client = new AlphaVantageClient(AlphaVantageApiKey);

            //var forexSeries = await client.Currency.GetTimeSeriesAsync(
            //    CurrencyExchange.From("USD", "EUR"),
            //    TimeSeriesInterval.Daily,
            //    TimeSeriesSize.Compact
            //);

            // Добавляем данные в график
            //foreach (var point in forexSeries.DataPoints)
            //{
            //    chart2.Series["dollar"].Points.AddXY(
            //        point.Timestamp.ToOADate(),
            //        Convert.ToDouble(point.Close)
            //    );
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            chart1.Series["f(x)"].Points.Clear();
            int n = comboBox1.SelectedIndex;
            
            switch (n)
            {
                case 0: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), c, d, n); break;
                case 1: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), c, d, n); break;
                case 2: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), c, d, n); break;
                case 3: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), c, d, n); break;
                case 4: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), c, d, n); break;
                case 5: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), double.Parse(textBoxc.Text), d, n); break;
                case 6: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), double.Parse(textBoxc.Text), d, n); break;
                case 7: grafik(double.Parse(textBoxa.Text), double.Parse(textBoxb.Text), double.Parse(textBoxc.Text), double.Parse(textBoxd.Text), n); break;
                case 8: grafik(double.Parse(textBoxa.Text), b, c, d, n); break;
                case 9: grafik(double.Parse(textBoxa.Text), b, c, d, n); break;

                
            }
        }

        
        private void yopish()
        {
            panela.Visible = false;
            panelb.Visible = false;
            panelc.Visible = false;
            paneld.Visible = false;
        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yopish();
            if(comboBox1.SelectedIndex == 0)
            {
                panela.Visible = true;
                panelb.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                panela.Visible = true;
                panelb.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                panela.Visible = true;
                panelb.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                panela.Visible = true;
                panelb.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                panela.Visible = true;
                panelb.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 5)
            {
                panela.Visible = true;
                panelb.Visible = true;
                panelc.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 6)
            {
                panela.Visible = true;
                panelb.Visible = true;
                panelc.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 7)
            {
                panela.Visible = true;
                panelb.Visible = true;
                panelc.Visible = true;
                paneld.Visible = true;

            }
            else if(comboBox1.SelectedIndex == 8)
            {
                panela.Visible = true;               

            }
            else if (comboBox1.SelectedIndex == 9)
            {
                panela.Visible = true;

            }

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yopish();
            comboBox1.SelectedIndex = 0;
        }

        private void grafik(double a, double b, double c, double d, int n)
        {
            var series = chart1.Series["f(x)"];

            // Define the range for x values
            double xMin = 0, xMax = 0;
            if(n < 4)
            {
                xMax = 10 * Math.PI;
                xMin = -10 * Math.PI;
            }           
            else
            {
                xMax = 20;
                xMin = -20;
            }
            int numberOfPoints = 10000; // Number of data points
            double step = (xMax - xMin) / numberOfPoints;

            // Add data points to the series
            switch(n)
            {
                case 0:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * Math.Sin(b * x);
                        series.Points.AddXY(x, y);
                    }break;

                case 1:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * Math.Cos(b * x);
                        series.Points.AddXY(x, y);
                    }break;

                case 2:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * Math.Tan(b * x);
                        series.Points.AddXY(x, y);
                    }break; 

                case 3:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a / Math.Tan(b * x);
                        series.Points.AddXY(x, y);
                    }break;
                case 4:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x + b;
                        series.Points.AddXY(x, y);
                    }break;
                case 5:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x*x + b*x+c;
                        series.Points.AddXY(x, y);
                    }break;
                case 6:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x*x*x*x + b*x+x+ c;
                        series.Points.AddXY(x, y);
                    }break;
                case 7:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x*x*x + b*x+x+ c*x+d;
                        series.Points.AddXY(x, y);
                    }break;
                case 8:
                    if(a == 1 || a < 0) return;
                    xMin = 0.0000001;
                    for (double x = xMin; x <= xMax; x += 0.0005)
                    {
                        double y = Math.Log(x);
                        series.Points.AddXY(x, y);
                    }break;
                
            }           

            // Optional: Configure chart area
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Title = "X-Axis (radians)";
            chartArea.AxisY.Title = "Y-Axis (sin(x))";
            chartArea.AxisX.Minimum = xMin;
            chartArea.AxisX.Maximum = xMax;



           
        }





        private void grafik2(double a, double b, double c, double d, int n)
        {
            var series = chart1.Series["g(x)"];

            // Define the range for x values
            double xMin = 0, xMax = 0;
            if (n < 4)
            {
                xMax = 10 * Math.PI;
                xMin = -10 * Math.PI;
            }
            else
            {
                xMax = 20;
                xMin = -20;
            }
            int numberOfPoints = 10000; // Number of data points
            double step = (xMax - xMin) / numberOfPoints;

            // Add data points to the series
            switch (n)
            {
                case 0:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * Math.Sin(b * x);
                        series.Points.AddXY(x, y);
                    }
                    break;

                case 1:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * Math.Cos(b * x);
                        series.Points.AddXY(x, y);
                    }
                    break;

                case 2:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * Math.Tan(b * x);
                        series.Points.AddXY(x, y);
                    }
                    break;

                case 3:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a / Math.Tan(b * x);
                        series.Points.AddXY(x, y);
                    }
                    break;
                case 4:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x + b;
                        series.Points.AddXY(x, y);
                    }
                    break;
                case 5:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x * x + b * x + c;
                        series.Points.AddXY(x, y);
                    }
                    break;
                case 6:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x * x * x * x + b * x + x + c;
                        series.Points.AddXY(x, y);
                    }
                    break;
                case 7:
                    for (double x = xMin; x <= xMax; x += step)
                    {
                        double y = a * x * x * x + b * x + x + c * x + d;
                        series.Points.AddXY(x, y);
                    }
                    break;
                case 8:
                    if (a == 1 || a < 0) return;
                    xMin = 0.0000001;
                    for (double x = xMin; x <= xMax; x += 0.0005)
                    {
                        double y = Math.Log(x);
                        series.Points.AddXY(x, y);
                    }
                    break;

            }

            // Optional: Configure chart area
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Title = "X-Axis (radians)";
            chartArea.AxisY.Title = "Y-Axis (sin(x))";
            chartArea.AxisX.Minimum = xMin;
            chartArea.AxisX.Maximum = xMax;




        }



        private Chart forexChart;

        private void panela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            yopishpasti();
            if (comboBox2.SelectedIndex == 0)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
                panelc1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
                panelc1.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 7)
            {
                panela1.Visible = true;
                panelb1.Visible = true;
                panelc1.Visible = true;
                paneld1.Visible = true;

            }
            else if (comboBox2.SelectedIndex == 8)
            {
                panela1.Visible = true;

            }
            else if (comboBox2.SelectedIndex == 9)
            {
                panela1.Visible = true;

            }
        }

        private void yopishpasti()
        {
            panela1.Visible = false;
            panelb1.Visible = false;
            panelc1.Visible = false;
            paneld1.Visible = false;
        }

       

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void panelb1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            chart1.Series["g(x)"].Points.Clear();
            int n = comboBox2.SelectedIndex;

            switch (n)
            {
                case 0: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), c, d, n); break;
                case 1: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), c, d, n); break;
                case 2: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), c, d, n); break;
                case 3: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), c, d, n); break;
                case 4: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), c, d, n); break;
                case 5: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), double.Parse(textBoxc1.Text), d, n); break;
                case 6: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), double.Parse(textBoxc1.Text), d, n); break;
                case 7: grafik2(double.Parse(textBoxa1.Text), double.Parse(textBoxb1.Text), double.Parse(textBoxc1.Text), double.Parse(textBoxd1.Text), n); break;
                case 8: grafik2(double.Parse(textBoxa1.Text), b, c, d, n); break;
                case 9: grafik2(double.Parse(textBoxa1.Text), b, c, d, n); break;


            }
        }

        private readonly string apiKey = "YOUR_API_KEY"; // Insert your Alpha Vantage API key

        public void ForexForm()
        {
            forexChart = new Chart
            {
                Dock = DockStyle.Fill
            };

            var chartArea = new ChartArea("MainArea");
            forexChart.ChartAreas.Add(chartArea);

            var series = new Series("USD/EUR")
            {
                ChartType = SeriesChartType.Line
            };

            forexChart.Series.Add(series);

            this.Controls.Add(forexChart);

            // Fetch data asynchronously
            _ = LoadForexData();
        }

        private async Task LoadForexData()
        {
            var client = new AlphaVantageClient(apiKey);

            // Daily forex rates for USD/EUR
            var forexData = await client.GetForexTimeSeriesAsync("USD", "EUR", "daily", "compact");

            foreach (var point in forexData.DataPoints)
            {
                forexChart.Series["USD/EUR"].Points.AddXY(point.Timestamp.ToOADate(), Convert.ToDouble(point.Close));
            }
        }
    }

    

    public class ForexDataPoint
    {
        public DateTime Timestamp { get; set; }
        public decimal Close { get; set; }
    }

    public class ForexTimeSeries
    {
        public string CurrencyPair { get; set; }
        public List<ForexDataPoint> DataPoints { get; set; }
    }

    public class AlphaVantageClient
    {
        private string apiKey;

        public AlphaVantageClient(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<ForexTimeSeries> GetForexTimeSeriesAsync(string baseCurrency, string quoteCurrency, string interval, string outputSize)
        {
            // Имитация асинхронного запроса к API
            await Task.Delay(1000); // Имитация задержки запроса

            // Здесь можно использовать HttpClient или другую библиотеку для выполнения реального запроса к API

            // Пример ответа с фейковыми данными
            var timeSeries = new ForexTimeSeries
            {
                CurrencyPair = $"{baseCurrency}/{quoteCurrency}",
                DataPoints = new List<ForexDataPoint>
            {
                new ForexDataPoint { Timestamp = DateTime.UtcNow.AddDays(-1), Close = 1.12M },
                new ForexDataPoint { Timestamp = DateTime.UtcNow.AddDays(-2), Close = 1.11M },
                // Добавьте больше точек данных при необходимости
            }
            };

            return timeSeries;
        }
    }

}
