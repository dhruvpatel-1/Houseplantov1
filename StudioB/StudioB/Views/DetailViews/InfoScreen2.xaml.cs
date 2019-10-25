using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;
using Microcharts;
using Entry = Microcharts.Entry;


namespace StudioB.Views.DetailViews
{
    public partial class InfoScreen2 : ContentPage
    {
        public InfoScreen2()
        {
            
            InitializeComponent();
            var entries = new[]
            {
                new Entry(30)
                {
                     Label = "21/10",
                     ValueLabel = "30",
                     Color = SKColor.Parse("#2c3e50")
                },
                new Entry(40)
                {
                     Label = "22/10",
                     ValueLabel = "40",
                     Color = SKColor.Parse("#77d065")
                },
                new Entry(50)
                {
                     Label = "23/10",
                     ValueLabel = "50",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(20)
                {
                     Label = "24/10",
                     ValueLabel = "20",
                     Color = SKColor.Parse("#3498db"), TextColor = SKColor.Parse("#b455b6")
                }
            };




            var chart = new LineChart () { Entries = entries, LabelTextSize=25, LineMode=LineMode.Straight, LineSize = 8, PointMode = PointMode.Square, PointSize=18};
            this.chartView.Chart = chart;

            var chart1 = new BarChart() { Entries = entries, LabelTextSize = 25 };
            this.chartView1.Chart = chart1;

            var chart2 = new RadialGaugeChart() { Entries = entries, LabelTextSize = 25 };
            this.chartView2.Chart = chart2;


        }
    }
}