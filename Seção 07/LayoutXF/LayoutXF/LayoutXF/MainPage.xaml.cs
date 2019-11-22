using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Absolute.AbsolutePage());
        }
        private void GoGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Grid.GridPage());
        }
        private void GoRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Relative.RelativePage());
        }
        private void GoScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Scroll.ScrollPage());
        }
        private void GoStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Stack.StackPage());
        }
    }
}
