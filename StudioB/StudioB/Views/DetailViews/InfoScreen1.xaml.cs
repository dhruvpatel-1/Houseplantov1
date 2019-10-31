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

            var entries2 = new[]
            {
                new Entry(30)
                {
                     Label = "21/10",
                     ValueLabel = "30%",
                     Color = SKColor.Parse("#2c3e50")
                },
                new Entry(44)
                {
                     Label = "22/10",
                     ValueLabel = "44%",
                     Color = SKColor.Parse("#77d065")
                },
                new Entry(56)
                {
                     Label = "23/10",
                     ValueLabel = "5%",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(60)
                {
                     Label = "24/10",
                     ValueLabel = "60%",
                     Color = SKColor.Parse("#3498db"), TextColor = SKColor.Parse("#b455b6")
                }
            };

            var entries3 = new[]
            {
                new Entry(86)
                {
                     Label = "21/10",
                     ValueLabel = "86%",
                     Color = SKColor.Parse("#2c3e50")
                },
                new Entry(90)
                {
                     Label = "22/10",
                     ValueLabel = "90%",
                     Color = SKColor.Parse("#77d065")
                },
                new Entry(60)
                {
                     Label = "23/10",
                     ValueLabel = "60%",
                     Color = SKColor.Parse("#b455b6")
                },
                new Entry(75)
                {
                     Label = "24/10",
                     ValueLabel = "75%",
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