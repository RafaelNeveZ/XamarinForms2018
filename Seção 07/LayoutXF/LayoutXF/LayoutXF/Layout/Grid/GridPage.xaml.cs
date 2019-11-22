using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutXF.Layout.Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
            GridD.ColumnDefinitions.Add(new ColumnDefinition{ Width = 150 });
            GridD.RowDefinitions.Add(new RowDefinition { Height = 100 });
            GridD.Children.Add(new BoxView { BackgroundColor = Color.Black, 
                                             HorizontalOptions = LayoutOptions.FillAndExpand,
                                             VerticalOptions = LayoutOptions.FillAndExpand, },3,3);

        }
    }
}