using System.Globalization;

namespace _5M05desktPaszporty
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnOK(object sender, EventArgs e)
        {

        }
        private void entNrUnfocused(object sender, EventArgs e) 
            {
                
                string nazwaZdj = $"z{entNumer.Text}_zdjecie.png";
                string nazwaOdc = $"z{entNumer.Text}_odcisk.png";
                
                imgOdcisk.Source = nazwaOdc;
                imgZdjecie.Source = nazwaZdj;
            }
    }

}
