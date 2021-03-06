using Covid.Model.Country;
using System;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Usa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Infections_Usa : ContentPage
    {
        public int a;
        public int b;
        public Infections_Usa()
        {
            InitializeComponent();
            
        }

        private void Tap2_Clicked(object sender, EventArgs e)
        {
            Country_Infections vm;
            vm = new Country_Infections(a, b, 8);
            this.BindingContext = vm;
        }

        private void datepicker1_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date = new DateTime(2020, 1, 22);
            a = e.NewDate.Subtract(date).Days;
        }

        private void datepicker2_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime date = new DateTime(2020, 1, 22);
            b = e.NewDate.Subtract(date).Days;
        }
    }
}