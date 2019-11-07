using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;
using Microcharts;
using Entry = Microcharts.Entry;


namespace StudioB.Views.DetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoScreen1 : ContentPage
    {
        public InfoScreen1()
        {
            InitializeComponent();
            var entries = new[]
            {
                new Entry(25)
                {
                     Label = "2019-11-07 00:53:51",
                     ValueLabel = "25°C",
                     Color = SKColor.Parse("#2c3e50")
                },
                new Entry(25)
                {
                     Label = "2019-11-07 00:57:51",
                     ValueLabel = "25°C",
                     Color = SKColor.Parse("#77d065")
                },
                new Entry(23)
                {
                     Label = "2019-11-07 01:01:51",
                     ValueLabel = "23°C",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(24)
                {
                     Label = "2019-11-07 01:05:51",
                     ValueLabel = "24°C",
                     Color = SKColor.Parse("#3498db"), TextColor = SKColor.Parse("#b455b6")
                }
            };

            var entries2 = new[]
            {
                new Entry(25)
                {
                     Label = "2019-11-07 00:53:51",
                     ValueLabel = "25%",
                     Color = SKColor.Parse("#2c3e50")
                },
                new Entry(27)
                {
                     Label = "2019-11-07 00:57:51",
                     ValueLabel = "27%",
                     Color = SKColor.Parse("#77d065")
                },
                new Entry(30)
                {
                     Label = "2019-11-07 01:01:51",
                     ValueLabel = "30%",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(28)
                {
                     Label = "2019-11-07 01:05:51",
                     ValueLabel = "28%",
                     Color = SKColor.Parse("#3498db"), TextColor = SKColor.Parse("#b455b6")
                }
            };

            var entries3 = new[]
            {
                new Entry(950)
                {
                     Label = "2019-11-07 00:53:51",
                     ValueLabel = "950Lux",
                     Color = SKColor.Parse("#2c3e50")
                },
                new Entry(800)
                {
                     Label = "2019-11-07 00:57:51",
                     ValueLabel = "800Lux",
                     Color = SKColor.Parse("#77d065")
                },
                new Entry(1000)
                {
                     Label = "2019-11-07 01:01:51",
                     ValueLabel = "1000Lux",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(900)
                {
                     Label = "2019-11-07 01:05:51",
                     ValueLabel = "900Lux",
                     Color = SKColor.Parse("#3498db"), TextColor = SKColor.Parse("#b455b6")
                }
            };




            var chart = new LineChart() { Entries = entries, LabelTextSize = 25, LineMode = LineMode.Straight, LineSize = 8, PointMode = PointMode.Square, PointSize = 18 };
            this.chartView.Chart = chart;

            var chart1 = new BarChart() { Entries = entries2, LabelTextSize = 25};
            this.chartView1.Chart = chart1;

            var chart2 = new RadialGaugeChart() { Entries = entries3, LabelTextSize = 25 };
            this.chartView2.Chart = chart2;


        }
    }
}