using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioB.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioB.Views.DetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoScreen1 : ContentPage
    {
        public ObservableCollection<VeggieViewModel> veggies { get; set; }
        public InfoScreen1()
        {
            veggies = new ObservableCollection<VeggieViewModel>();
            ListView lstView = new ListView();
            lstView.RowHeight = 60;
            this.Title = "All Plants";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomVeggieCell));
            veggies.Add(new VeggieViewModel { Name = "Amaryllis", Type = "Plant", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "African Violet", Type = "Plant", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Angel Wing Begonia", Type = "Plant", Image = "zucchini.png" });
            lstView.ItemsSource = veggies;
            Content = lstView;
        }

        public class CustomVeggieCell : Xamarin.Forms.ViewCell
        {
            public CustomVeggieCell()
            {
                //instantiate each of our views
                var image = new Image();
                var nameLabel = new Label();
                var typeLabel = new Label();
                var verticaLayout = new StackLayout();
                var horizontalLayout = new StackLayout() { BackgroundColor = Color.Olive };

                //set bindings
                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                typeLabel.SetBinding(Label.TextProperty, new Binding("Type"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));

                //Set properties for desired design
                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                image.HorizontalOptions = LayoutOptions.End;
                nameLabel.FontSize = 24;

                //add views to the view hierarchy
                verticaLayout.Children.Add(nameLabel);
                verticaLayout.Children.Add(typeLabel);
                horizontalLayout.Children.Add(verticaLayout);
                horizontalLayout.Children.Add(image);

                // add to parent view
                View = horizontalLayout;
            }
        }
    }
}